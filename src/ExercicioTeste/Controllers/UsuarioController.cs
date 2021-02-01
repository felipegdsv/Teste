using ExercicioTeste.Context;
using ExercicioTeste.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExercicioTeste.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioContext _context;

        public UsuarioController(UsuarioContext dbContext)
        {
            _context = dbContext;
        }
        
        public ActionResult Index()
        {
            return View(_context.UsuarioData.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(collection);
                }

                _context.Add(collection);
                _context.SaveChanges();

                ViewBag.ShowDialogSucesso = true;

                return View(collection);
            }
            catch
            {
                return View();
            }
        }
    }
}
