using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class TesteController : Controller
    {
        public string Exemplo01()
        {
            return "Isto é um método.";
        }

        public ViewResult Exemplo02()
        {
            return View();
        }

        public ViewResult Exemplo03()
        {
            var fornecedor = new FornecedorViewModel();
            fornecedor.Nome = "Papelaria ASP.NET";
            fornecedor.Email = "papel@asp.net";
            fornecedor.Telefone = "1234-5678";
            return View(fornecedor);
        }
    }
}