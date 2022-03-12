using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VídeoExplicativo_AulaProgramaçãoWeb.Models;

namespace VídeoExplicativo_AulaProgramaçãoWeb.Controllers
{
    public class Biblioteca : Controller
    {

        //lista estática
        public static List<BibliotecaModel> lsLivros = new List<BibliotecaModel>();

        public IActionResult Estante1()
        {
            return View(lsLivros);
        }

        public IActionResult AdicionarLivro()
        {
            return View();
        }

        [HttpPost] //para avisar o controler q vc ta recebendo um post do AdicionarLivro
        public IActionResult AdicionarLivro(BibliotecaModel objeto)
        {
            //adicionar na lista, mostra qual é ela
            lsLivros.Add(objeto);
            return RedirectToAction("Estante1");//redirecionar para o estante1
                
        }
    }
}
