using Locadora_de_veiculos.Context;
using Locadora_de_veiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locadora_de_veiculos.Controllers
{
    public class ClientesController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        //Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //Edit


    }
}