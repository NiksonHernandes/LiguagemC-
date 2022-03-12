using Microsoft.AspNetCore.Mvc;

namespace AplicaçãoSite_Parte1.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar() //para view Cadastrar 
        {
            return View();
        }
    }
}