using ApiInternados.Data;
using ApiInternados.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiInternados.Controllers

{
    [ApiController]
    [Route("internados/")]
    public class InternadoController : Controller
    {
        private readonly InternadosContext db;
        
        public InternadoController(InternadosContext _db)
        {
            db = _db;
        }

        // GET: InternadoController
        [HttpGet("hello")]
        public String Index()
        {
            return "Hola soy Mar y ano";
        }

        // GET: InternadoController
        [HttpGet("all")]
        public List<Internado> GetInternados()
        {
            return db.Internado.ToList();
        }

        // GET: InternadoController
        [HttpGet("{name}")]
        public List<Internado> FindByName(string name)
        {
            return db.Internado.Where(internado => internado.NombreGarante.Equals(name)).ToList();
        }

        // GET: InternadoController/Details/5
        [HttpGet("Details/{id}")]
        public Internado Details(int id)
        {
            return db.Internado.Find(id);
        }

        // GET: InternadoController/uno/5
        [HttpGet("InternadoController/uno/{id}")]
        public ActionResult Uno(int id)
        {
            return View();
        }

        // GET: InternadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InternadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InternadoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InternadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InternadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InternadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
