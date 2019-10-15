using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Presentation.Models; //camada de modelo
using Projeto.Data.Contracts;
using Projeto.Data.Entities;

namespace Projeto.Presentation.Controllers
{
    public class ProdutoController : Controller
    {
        //atributo..
        private IProdutoRepository repository;

        //construtor para inicializar o atributo 'repository'
        public ProdutoController(IProdutoRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //Recebe o SUBMIT (envio dos dados) do formulário
        public IActionResult Cadastro(ProdutoCadastroModel model)
        {
            //verificar se os campos da model passaram nas validações
            if(ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;

                    repository.Inserir(produto);

                    TempData["Mensagem"] = $"Produto {produto.Nome}, cadastrado com sucesso.";
                    ModelState.Clear(); //limpa os campos do formulário
                }
                catch(Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View();
        }

        public IActionResult Consulta()
        {
            List<ProdutoConsultaModel> lista = new List<ProdutoConsultaModel>();

            try
            {
                foreach(var item in repository.ObterTodos())
                {
                    ProdutoConsultaModel model = new ProdutoConsultaModel();
                    model.IdProduto = item.IdProduto;
                    model.Nome = item.Nome;
                    model.Preco = item.Preco;
                    model.Quantidade = item.Quantidade;
                    model.Total = item.Preco * item.Quantidade;
                    model.DataCadastro = item.DataCadastro;

                    lista.Add(model);
                }
            }
            catch(Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return View(lista);
        }

        public ActionResult Exclusao(int id)
        {
            try
            {
                repository.Excluir(id);

                TempData["Mensagem"] = "Produto Excluído com sucesso";

            }
            catch(Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return RedirectToAction("Consulta");

        }

        public ActionResult Edicao(int id)
        {
            ProdutoEdicaoModel model = new ProdutoEdicaoModel();

            try
            {
                Produto produto = repository.ObterPorId(id);
                model.IdProduto = produto.IdProduto;
                model.Nome = produto.Nome;
                model.Preco = produto.Preco;
                model.Quantidade = produto.Quantidade;
            }
            catch(Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return View(model);
        }

        [HttpPost] //Recebe o SUBMIT (envio dos dados) do formulário
        public IActionResult Edicao(ProdutoEdicaoModel model)
        {
            //verificar se os campos da model passaram nas validações
            if (ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    produto.IdProduto = model.IdProduto;
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;

                    repository.Alterar(produto);  

                    TempData["Mensagem"] = $"Produto {produto.Nome}, atualizado com sucesso.";
                    return RedirectToAction("consulta");
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View();
        }




    }






}