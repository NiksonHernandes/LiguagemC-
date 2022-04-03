using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelaDeLogin_MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Entrar()
        {
            return View();
        }
        public IActionResult Logado()
        {
            return View();
        }
        public IActionResult NaoLogado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(string usuario, string senha)
        {
            if(usuario == "admin" && senha == "admin")
            {
                return RedirectToAction("Logado");
            }
            else
            {
                return RedirectToAction("NaoLogado");
            }
        }
       
    }
}
