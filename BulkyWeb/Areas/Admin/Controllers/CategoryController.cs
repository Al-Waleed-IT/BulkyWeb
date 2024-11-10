using Bulky.Models;
using BulkyWeb.Data;
using BulkyWeb.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Areas.Admin
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        // Inject IUnitOfWork instead of UnitOfWork for proper DI
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET
        public IActionResult Index()
        {
            List<Category> categories = _unitOfWork.Category.GetAll().ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(category);
                _unitOfWork.Category.Save();
                TempData["Success"] = "Category created successfully";
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
            
            Category category = _unitOfWork.Category.Get(x => x.Id == id);
            return View(category);
        }
        
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(category);
                _unitOfWork.Category.Save();
                TempData["Success"] = "Category updated successfully";
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
            
            Category category = _unitOfWork.Category.Get(x => x.Id == id);
            return View(category);
        }
        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Category category = _unitOfWork.Category.Get(x => x.Id == id);
            if (category != null)
            {
                _unitOfWork.Category.Delete(category);
                _unitOfWork.Category.Save();
                TempData["Success"] = "Category successfully deleted!";
                return RedirectToAction("Index");
            }

            return NotFound();
        }
    }
}