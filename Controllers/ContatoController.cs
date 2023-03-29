using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Altsystems.ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Incluir()
        {
            return View();
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
