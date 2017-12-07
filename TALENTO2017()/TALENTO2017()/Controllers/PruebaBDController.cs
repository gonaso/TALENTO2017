
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
        //Variable que se utiliza para obtener datos del modelo
        PGDbContext _context;
        //Constructor que instancia el contexto en el que esta ubicado la base de datos
        public PruebaBDController()
        {
            _context = new PGDbContext();
            //Abre la conexion con la base de datos
            this._context.Database.Connection.Open();
            
        }
        
        public ActionResult Prueba()
        {
            //Variable que recupera
            List<Users> data = _context.Usr.ToList();
            return View(data);
        }
    }
}