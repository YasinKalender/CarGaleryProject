using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGaleryProject.DAL.Model.ORM.Entity.Concrete
{
    public class Category:BaseCar
    {

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public virtual List<Car> car { get; set; }
    }
}
