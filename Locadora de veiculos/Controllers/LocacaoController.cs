using Locadora_de_veiculos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locadora_de_veiculos.Controllers
{
    public class LocacaoController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Locacao
        public ActionResult Index()
        {
            return View(context.Locacaos.OrderBy(c => c.Nome));
        }

        // GET: Locacao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Locacao/Create
        public ActionResult Create()
        {
            ViewBag.ClienteID = new SelectList(context.Clientes.OrderBy(b => b.Nome),
                "ClienteID", "Nome");
            ViewBag.VeiculoID = new SelectList(context.Veiculos.OrderBy(b => b.Nome),
                "VeiculoID", "Nome");
            return View();
        }

        // POST: Locacao/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Locacao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Locacao/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Locacao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Locacao/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
