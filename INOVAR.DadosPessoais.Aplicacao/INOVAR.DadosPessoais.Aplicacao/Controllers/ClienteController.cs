using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INOVAR.DadosPessoais.Dominio.Modelo;

namespace INOVAR.DadosPessoais.Aplicacao.Controllers
{
    public class ClienteController : Controller
    {

        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View(Fachada.Negocio.Cliente.obterClientes().Lista);
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id = 0)
        {
            tbCliente cliente = Fachada.Negocio.Cliente.obterCliente(id).Objeto;
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbCliente tbcliente)
        {
            var salva = Fachada.Negocio.Cliente.salva(tbcliente);

            return RedirectToAction("../Cliente");

        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tbCliente cliente = Fachada.Negocio.Cliente.obterCliente(id).Objeto;
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbCliente tbcliente)
        {
            var ret = Fachada.Negocio.Cliente.salva(tbcliente);
            return RedirectToAction("../Cliente");
            
        }

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tbCliente cliente = Fachada.Negocio.Cliente.obterCliente(id).Objeto;
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var apaga = Fachada.Negocio.Cliente.apaga(id);
            return RedirectToAction("../Cliente");
        }

       
    }
}