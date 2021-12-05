using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locadora_de_veiculos.Controllers
{
    public class VeiculosController : Controller
    {
        // GET: Veiculos
        public ActionResult Index()
        {
            return View();
        }
    }
}