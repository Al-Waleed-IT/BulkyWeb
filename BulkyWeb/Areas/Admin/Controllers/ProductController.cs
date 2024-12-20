using System.Data.Common;
using Bulky.Models;
using Bulky.Models.ViewModels;
using BulkyWeb.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Areas.Admin
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly String _componentTitle;
        private readonly IWebHostEnvironment _webHostEnvironment;

        // Inject IUnitOfWork instead of UnitOfWork for proper DI
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _componentTitle = "Product";
            _webHostEnvironment = webHostEnvironment;
        }

        // GET
        public IActionResult Index()
        {
            List<Product> obj = _unitOfWork.Product.GetAll().ToList();

            return View(obj);
        }

        public IActionResult Upsert(int? id)
        {
            ProductVM productVm = new()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }),
                Product = new Product()
            };

            if (id == null || id == 0)
            {
                return View(productVm);
            }
            else
            {
                productVm.Product = _unitOfWork.Product.Get(u=> u.Id == id);
                return View(productVm);
            }

        }
        
        [HttpPost]
        public IActionResult Upsert(ProductVM obj, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwrootPath = _webHostEnvironment.WebRootPath;

                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwrootPath, @"images/product");

                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    
                    obj.Product.ImageUrl = @"/images/product/" + fileName;
                }

                if (obj.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(obj.Product);
                }
                else
                {
                    _unitOfWork.Product.Update(obj.Product);
                }
                

                _unitOfWork.Product.Save();
                
                TempData["Success"] = $"{_componentTitle} created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                IEnumerable<SelectListItem> categoryListItems = _unitOfWork.Category.GetAll().Select(x=> new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                });
                
                obj.CategoryList = categoryListItems;
   
                
                return View(obj);
            }

           
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            Product product = _unitOfWork.Product.Get(x => x.Id == id);
            
            IEnumerable<SelectListItem> categoryListItems = _unitOfWork.Category.GetAll().Select(x=> new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            
            // ViewBag.categoryListItems = categoryListItems;
            ProductVM obj = new()
            {
                Product = product,
                CategoryList = categoryListItems
            };
            return View(obj);
        }
        
        [HttpPost]
        public IActionResult Edit(ProductVM obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(obj.Product);
                _unitOfWork.Product.Save();
                TempData["Success"] = $"{_componentTitle} updated successfully";
                return RedirectToAction("Index");
            }
            else
            {
                IEnumerable<SelectListItem> categoryListItems = _unitOfWork.Category.GetAll().Select(x=> new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                });
                
                obj.CategoryList = categoryListItems;
                return View(obj);
            }


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

        #region API CALLS

[HttpGet]
[HttpGet]
public IActionResult GetProducts()
{
    // Get DataTable request parameters
    var draw = HttpContext.Request.Query["draw"].FirstOrDefault();
    var start = HttpContext.Request.Query["start"].FirstOrDefault();
    var length = HttpContext.Request.Query["length"].FirstOrDefault();
    var sortColumnIndex = HttpContext.Request.Query["order[0][column]"].FirstOrDefault();
    var sortDirection = HttpContext.Request.Query["order[0][dir]"].FirstOrDefault();
    var searchValue = HttpContext.Request.Query["search[value]"].FirstOrDefault();

    // Convert parameters to appropriate data types
    int pageSize = string.IsNullOrEmpty(length) ? 0 : Convert.ToInt32(length);
    int skip = string.IsNullOrEmpty(start) ? 0 : Convert.ToInt32(start);

    // Get the data source as an IQueryable
    var productQuery = _unitOfWork.Product.GetAll(); // Ensure GetAll() returns IQueryable<Product>

    // Apply filtering
    if (!string.IsNullOrEmpty(searchValue))
    {
        productQuery = productQuery.Where(p =>
            p.Title.Contains(searchValue) ||  // Replace 'Title' with the actual property
            p.Author.Contains(searchValue)); // Replace 'Author' with the actual property
    }

    // Apply sorting
    switch (sortColumnIndex)
    {
        case "0": // ID column
            productQuery = sortDirection == "asc"
                ? productQuery.OrderBy(p => p.Id)
                : productQuery.OrderByDescending(p => p.Id);
            break;
        case "1": // Title column
            productQuery = sortDirection == "asc"
                ? productQuery.OrderBy(p => p.Title)
                : productQuery.OrderByDescending(p => p.Title);
            break;
        case "2": // ISBN column
            productQuery = sortDirection == "asc"
                ? productQuery.OrderBy(p => p.ISBN)
                : productQuery.OrderByDescending(p => p.ISBN);
            break;
        case "3": // Author column
            productQuery = sortDirection == "asc"
                ? productQuery.OrderBy(p => p.Author)
                : productQuery.OrderByDescending(p => p.Author);
            break;
        case "4": // Price column
            productQuery = sortDirection == "asc"
                ? productQuery.OrderBy(p => p.Price)
                : productQuery.OrderByDescending(p => p.Price);
            break;
    }

    // Get total record count before pagination
    var totalRecords = productQuery.Count();

    // Apply pagination
    var data = productQuery.Skip(skip).Take(pageSize).ToList();

    // Return data in the format required by DataTables
    return Json(new
    {
        draw = draw,
        recordsTotal = totalRecords,
        recordsFiltered = totalRecords, // Adjust if additional filtering is applied
        data = data
    });
}



        #endregion
    }
}