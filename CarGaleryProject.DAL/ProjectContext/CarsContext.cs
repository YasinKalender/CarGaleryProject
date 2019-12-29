using CarGaleryProject.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGaleryProject.DAL.ProjectContext
{
    public class CarsContext : DbContext
    {

        public CarsContext()
        {
            Database.Connection.ConnectionString = @"Server=.; Database=CarsGaleryProject; integrated security=true ";
        }

        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Car> Car { get; set; }
    }
}
