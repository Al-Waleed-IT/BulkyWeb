using Bulky.Models;

using BulkyWeb.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Areas.Admin
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly String _componentTitle;

        // Inject IUnitOfWork instead of UnitOfWork for proper DI
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _componentTitle = "Product";
        }

        // GET
        public IActionResult Index()
        {
            List<Product> obj = _unitOfWork.Product.GetAll().ToList();
            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Add(obj);
                _unitOfWork.Product.Save();
                TempData["Success"] = $"{_componentTitle} created successfully";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            Product category = _unitOfWork.Product.Get(x => x.Id == id);
            return View(category);
        }
        
        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(obj);
                _unitOfWork.Product.Save();
                TempData["Success"] = $"{_componentTitle} updated successfully";
                return RedirectToAction("Index");
            }

            return View();
        }
        
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            Product obj = _unitOfWork.Product.Get(x => x.Id == id);
            return View(obj);
        }
        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Product obj = _unitOfWork.Product.Get(x => x.Id == id);
            if (obj != null)
            {
                _unitOfWork.Product.Delete(obj);
                _unitOfWork.Product.Save();
                TempData["Success"] = $"{_componentTitle} successfully deleted!";
                return RedirectToAction("Index");
            }

            return NotFound();
        }
    }
}