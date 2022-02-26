using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BLL.IManagers;

namespace Restaurant.API.Controllers
{
    [Route("api/units")]
    [ApiController]
    public class UnitControllers : ControllerBase
    {

        private readonly IUnitManager _unitManager;

        public UnitControllers(IUnitManager unitmanager)
        {
            _unitManager= unitmanager;
        }
        // GET: UnitControllers
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var units= await _unitManager.GetAllAsync();
            return Ok(units);
        }

        [HttpGet("{id}")]
        // GET: UnitControllers/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var unit = await _unitManager.GetByIdAsync(id);
            return Ok(unit);
        }

        // GET: UnitControllers/Create
        [HttpGet]
        public ActionResult Create()
        {
            return Ok();
        }

        // POST: UnitControllers/Create
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
                return Ok();
            }
        }

        // GET: UnitControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return Ok();
        }

        // POST: UnitControllers/Edit/5
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
                return Ok();
            }
        }

        // GET: UnitControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return Ok();
        }

        // POST: UnitControllers/Delete/5
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
                return Ok();
            }
        }
    }
}
