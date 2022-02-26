using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BLL.IManagers;
using Restaurant.ENTITY;

namespace Restaurant.APP.Controllers
{
    public class UnitsController : Controller
    {

        private readonly IUnitManager _unitManager;


        public UnitsController(IUnitManager unitManager)
        {
            _unitManager = unitManager;
        }
        // GET: UnitsController
        public async Task<ActionResult> Index()
        {
            var units = await _unitManager.GetAllAsync();
            return View(units);
        }

        // GET: UnitsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var unit = await _unitManager.GetByIdAsync(id);
            return View(unit);
        }

        // GET: UnitsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnitsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Unit unit)
        { 
            if (ModelState.IsValid)
            {

                unit.CreatedAt = DateTime.Now;
                //unit.CreatedBy = HttpContext.Session.GetString("UserId");
                await _unitManager.AddAsync(unit);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: UnitsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnitsController/Edit/5
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

        // GET: UnitsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnitsController/Delete/5
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
