using Microsoft.AspNetCore.Mvc;
using Proje.EfRepositories;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Controllers
{
    public class ToDoController : Controller
    {
        ToDoRepositories<ToDo> c = new();
        [HttpGet]
        public IActionResult Index()
        {
            var values = c.GetListAll();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(ToDo todo)
        {
            todo.Status = false;
            c.Insert(todo);

            return RedirectToAction("Index", "ToDo");
        }
        
        public IActionResult Delete(int id)
        {
            var value = c.GetById(id);
            c.Delete(value);

            return RedirectToAction("Index", "ToDo");


        }
        
        public IActionResult Update(int id)
        {
            var value = c.GetById(id);
            if (value.Status == true)
            {
                value.Status = false;
                c.Update(value);
                return RedirectToAction("Index", "ToDo");
            }
            else
            {
                value.Status = true;
                c.Update(value);
                return RedirectToAction("Index", "ToDo");
            }
            


        }



    }
}
