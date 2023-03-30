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

        // chama a view para incluir / inclui no banco o contato
        public IActionResult Incluir()
        {
            return View();
        }        

        [HttpPost]
        public IActionResult Incluir(Contato contato)
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");            
        }



        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ExcluirConfirmacao()
        {
            return View();
        }

    }
}
