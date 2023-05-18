using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Web.Controllers
{
    public class PrestationController : Controller
    {
        IServicePrestataire servicePrestataire;
        IServicePrestation servicePrestation;
        public PrestationController(IServicePrestataire servicePrestataire, IServicePrestation servicePrestation)
        {
            this.servicePrestataire = servicePrestataire;
            this.servicePrestation = servicePrestation;
        }

        // GET: PrestationController
        public ActionResult Index()
        {
            return View(servicePrestation.GetAll());
        }

        // GET: PrestationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestationController/Create
        public ActionResult Create()
        {
            ViewBag.PrestataireFK = new SelectList(servicePrestataire.GetAll(), "PrestataireId", "PrestataireNom");
            return View();
        }

        // POST: PrestationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prestation p)
        {
            try
            {
                servicePrestation.Add(p);
                servicePrestation.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestationController/Edit/5
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

        // GET: PrestationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestationController/Delete/5
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
