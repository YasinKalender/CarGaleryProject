using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarGaleryProject.DAL.Model.ORM.Entity.Enum.Enum;

namespace CarGaleryProject.DAL.Model.ORM.Entity.Abstract
{
    public interface ICore
    {
        int ID { get; set; }

        DateTime AddDate { get; set; }

        DateTime? DeleteDate { get; set; }
        DateTime? UpdateDate { get; set; }

        Status status { get; set; }




    }
}
