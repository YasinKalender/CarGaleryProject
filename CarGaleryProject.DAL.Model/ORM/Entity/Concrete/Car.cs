using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGaleryProject.DAL.Model.ORM.Entity.Concrete
{
    public class Car :BaseCar
    {

        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public string CarDescription { get; set; }
        public int CarYear { get; set; }
        public decimal CarPrice { get; set; }

        public string pictureURL { get; set; }

        public int CategoryID { get; set; }
        public virtual Category category { get; set; }

        public int UserID { get; set; }

        public virtual User user { get; set; }
    }
}
