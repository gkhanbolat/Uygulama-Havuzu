using Microsoft.EntityFrameworkCore;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-F6SO9G3;database=HavuzProje;integrated security=true;");
        }

        public DbSet<ToDo> ToDos { get; set; }


    }
}
