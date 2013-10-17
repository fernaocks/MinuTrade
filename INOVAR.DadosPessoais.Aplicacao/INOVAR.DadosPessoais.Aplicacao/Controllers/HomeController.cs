using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INOVAR.DadosPessoais.Aplicacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Captação de dados para a empresa XYZ";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Informações de Contato.";

            return View();
        }
    }
}
