using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locadora_de_veiculos.Controllers
{
    public class VeiculosController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Veiculoss
        public ActionResult Index()
        {
            return View(context.V);
        }
    }
}