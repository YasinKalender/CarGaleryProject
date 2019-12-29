using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarGaleryProject.DAL.Model.ORM.Entity.Enum.Role;

namespace CarGaleryProject.DAL.Model.ORM.Entity.Concrete
{
    public class User :BaseCar
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string Adress { get; set; }

        public string Tel { get; set; }

        public Roles roles { get; set; }

        public virtual List<Car> car { get; set; }

    }
}
