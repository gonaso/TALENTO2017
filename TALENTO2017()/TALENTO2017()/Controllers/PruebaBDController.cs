
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TALENTO2017__.Models;

namespace TALENTO2017__.Controllers
{
    public class PruebaBDController : Controller
    {
        PGDbContext _context;
        public PruebaBDController()
        {
            _context = new PGDbContext();
            this._context.Database.Connection.Open();
            
        }
        public ActionResult Prueba()
        {
            var data = _context.Usr.ToList();
            return View(data);
        }
    }
}