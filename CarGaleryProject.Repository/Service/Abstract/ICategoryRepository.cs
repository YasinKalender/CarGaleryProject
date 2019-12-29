using CarGaleryProject.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGaleryProject.Repository.Service.Abstract
{
    public interface ICategoryRepository
    {

        
        void add(string name, string categorydescription);
        void update(int id, string name, string categorydescription);

        void delete(int id);

        List<Category> getAll();

        List<Category> findName(string name);

        List<Category> dateCategory(DateTime start, DateTime end);


    }
}
