using Proje.Concrete;
using Proje.Entity;
using Proje.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.EfRepositories
{
    public class ToDoRepositories<T> : IToDoDal
    {

        Context c = new Context(); 
        public void Delete(ToDo toDo)
        {
            c.Remove(toDo);
            c.SaveChanges();
        }

        public ToDo GetById(int id)
        {
            return c.ToDos.Find(id);
        }

        public List<ToDo> GetListAll()
        {
            return c.ToDos.ToList();
        }

        public void Insert(ToDo toDo)
        {
            c.Add(toDo);
            c.SaveChanges();
        }

        public void Update(ToDo toDo)
        {
            c.Update(toDo);
            c.SaveChanges();
        }
    }
}
