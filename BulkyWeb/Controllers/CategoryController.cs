using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
        List<Category> categories = _db.Categories.ToList();
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
            _db.Categories.Add(category);
            _db.SaveChanges(); 
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
        
        Category category = _db.Categories.Find(id) ?? throw new ArgumentNullException("_db.Categories.Find(id)");
        return View(category);
    }
    
    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {
            _db.Categories.Update(category);
            _db.SaveChanges(); 
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
        
        Category category = _db.Categories.Find(id) ?? throw new ArgumentNullException("_db.Categories.Find(id)");
        return View(category);
    }
    
    [HttpPost, ActionName("Delete")]
    public IActionResult Delete(Category category)
    {
        if (ModelState.IsValid)
        {
            _db.Categories.Remove(category);
            _db.SaveChanges(); 
            TempData["Success"] = "Category successfully deleted!";
            return RedirectToAction("Index");
        }

        return View();


    }
}