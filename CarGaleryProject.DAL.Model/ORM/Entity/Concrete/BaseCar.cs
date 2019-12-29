using CarGaleryProject.DAL.Model.ORM.Entity.Abstract;
using CarGaleryProject.DAL.Model.ORM.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGaleryProject.DAL.Model.ORM.Entity.Concrete
{
    public class BaseCar : ICore
    {
        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        private Enum.Enum.Status _status = Enum.Enum.Status.Active;
        public Enum.Enum.Status status { get { return _status; } set { _status = value; } }
    }
}
