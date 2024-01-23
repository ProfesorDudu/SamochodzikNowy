using Microsoft.AspNetCore.Mvc;

namespace Samochodzik.Controllers
{
    using global::Samochodzik.Models.Samochodzik.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System;

    public class CarRepairController : Controller
    {
        private readonly CarRepairContext _context;

        public CarRepairController(CarRepairContext context)
        {
            _context = context;
        }

        // GET: CarRepair
        public IActionResult Index()
        {
            var carRepairs = _context.CarRepairs.ToList();
            return View(carRepairs);
        }

        // GET: CarRepair/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRepair = _context.CarRepairs.FirstOrDefault(m => m.CarRepairID == id);

            if (carRepair == null)
            {
                return NotFound();
            }

            return View(carRepair);
        }

        // GET: CarRepair/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarRepair/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CarRepairID,CarModel,CustomerName,RepairDate,Price")] CarRepair carRepair)
        {
            if (carRepair is null)
            {
                throw new ArgumentNullException(nameof(carRepair));
            }

            if (ModelState.IsValid)
            {
                _context.Add(carRepair);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(carRepair);
        }

        // GET: CarRepair/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRepair = _context.CarRepairs.FirstOrDefault(m => m.CarRepairID == id);

            if (carRepair == null)
            {
                return NotFound();
            }

            return View(carRepair);
        }

        // POST: CarRepair/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("CarRepairID,CarModel,CustomerName,RepairDate,Price")] CarRepair carRepair)
        {
            if (id != carRepair.CarRepairID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carRepair);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarRepairExists(carRepair.CarRepairID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carRepair);
        }

        // GET: CarRepair/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carRepair = _context.CarRepairs.Find(id);

            if (carRepair == null)
            {
                return NotFound();
            }

            // Usunięcie obiektu z kontekstu bazy danych
            _context.CarRepairs.Remove(carRepair);

            // Zapisanie zmian w bazie danych
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // POST: CarRepair/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var carRepair = _context.CarRepairs.Find(id);
            NewMethod(carRepair);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

            void NewMethod(CarRepair? carRepair)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<CarRepair> entityEntry = _context.CarRepairs.Remove(carRepair);
            }
        }

        private bool CarRepairExists(int id)
        {
            return _context.CarRepairs.Any(e => e.CarRepairID == id);
        }
    }

}
