﻿using Empresa.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empresa.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var db = new ClienteDb();
            var lista = db.Listar();
            return View(lista);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);
            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
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

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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