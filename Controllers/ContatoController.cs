using Altsystems.ControleDeContatos.Models;
using Altsystems.ControleDeContatos.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Altsystems.ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {

        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public IActionResult Index()
        {
            List<Contato> contatos =  _contatoRepository.BuscarTodos();

            return View(contatos);
        }
 // **********************INCLUIR***************************************** //
        
        public IActionResult Incluir()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Incluir(Contato contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso.";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não foi possível cadastrar seu contato, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
            
        }

// **********************EDITAR******************************************* //
        
        public IActionResult Editar(int id)
        {
            Contato contato = _contatoRepository.ListarPorId(id);

            return View(contato);
        }

        [HttpPost]
        public IActionResult Alterar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepository.Atualizar(contato);
                return RedirectToAction("Index");
            }

            return View("Editar", contato);
        }

 // ********************EXCLUIR******************************************** //

        public IActionResult ExcluirConfirmacao(int id)
        {
            Contato contato = _contatoRepository.ListarPorId(id);

            return View(contato);
        }

        public IActionResult Excluir(int id)
        {
            _contatoRepository.Excluir(id);

            return RedirectToAction("Index");

        }

    }
}
