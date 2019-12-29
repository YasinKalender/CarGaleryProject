
using CarGaleryProject.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGaleryProject.Repository.Service.Abstract
{
    public interface ICarRepository
    {

        void add(string name, string model, string color, string description, int year, decimal price,string pictureUrl, int categoryID, int userID);

        void update(int id,string name, string model, string color, string description, int year, decimal price, string picture, string pictureUrl, int categoryID, int userID);

        void delete(int id);

        List<Car> findCar(string name);

        List<Car> getAll();

        List<Category> TakeCategory();

        List<User> TakeUser();
    }
}
