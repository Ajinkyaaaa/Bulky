using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _Db;
        public CategoryController(ApplicationDbContext Db)
        {
            _Db = Db;
            
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _Db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
           if(ModelState.IsValid)
            {
                _Db.Categories.Add(obj);
                _Db.SaveChanges();
              

            }
            TempData["Success"] = "Category Created Successfully";
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();

            }
            Category categoryfromDb = _Db.Categories.Find(id);
            if(categoryfromDb == null)
            {

                return NotFound();
            }
            return View(categoryfromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _Db.Categories.Update(obj);
                _Db.SaveChanges();

            }
            TempData["Success"] = "Category Updated Successfully";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }
            Category categoryfromDb = _Db.Categories.Find(id);
            if (categoryfromDb == null)
            {

                return NotFound();
            }
            return View(categoryfromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category obj = _Db.Categories.Find(id); 
            if (obj == null)
            {
                return NotFound();
            }
            _Db.Categories.Remove(obj);
            _Db.SaveChanges();
            TempData["Success"] = "Category Deleted Successfully";
            return RedirectToAction("Index");

         

          
        }

    }
}
