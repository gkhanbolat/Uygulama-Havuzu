using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.IDal
{
    public interface IToDoDal
    {
        void Insert(ToDo toDo);
        void Delete(ToDo toDo);
        void Update(ToDo toDo);
        List<ToDo> GetListAll();
        ToDo GetById(int id);
    }
}
