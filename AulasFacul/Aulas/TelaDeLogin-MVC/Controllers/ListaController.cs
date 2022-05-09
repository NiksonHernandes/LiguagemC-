using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelaDeLogin_MVC.Models;

namespace TelaDeLogin_MVC.Controllers
{
    public class ListaController : Controller
    {
        public static List<ListaModel> lsLista = new List<ListaModel>();

        public IActionResult Index()
        {
            return View(lsLista);
        }

        public IActionResult AdicionarUsuario()
        {
            return View();
        }

        public IActionResult DeletarUsuario(int id)
        {
            lsLista.Remove(lsLista.Find(a => a.Codigo == id));
            //return View();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AdicionarUsuario(ListaModel obj)
        {
            lsLista.Add(obj);
            return RedirectToAction("Index");
        }

    }
}
