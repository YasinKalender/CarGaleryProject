using CarGaleryProject.DAL.Model.ORM.Entity.Concrete;
using CarGaleryProject.Repository.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGaleryProject.Repository.Service.Concrete
{
    public class CarRepository :DbBasecs, ICarRepository
    {

        Car car = new Car();
        public void add(string name, string model, string color, string description, int year, decimal price, string pictureUrl, int categoryID, int userID)
        {
            car.CarName = name;
            car.CarModel = model;
            car.CarColor = color;
            car.CarDescription = description;
            car.CarYear = year;
            car.CarPrice = price;
            car.pictureURL = pictureUrl;
            car.CategoryID = categoryID;
            car.UserID = userID;
            db.Car.Add(car);
            db.SaveChanges();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> findCar(string name)
        {
            throw new NotImplementedException();
        }

        public List<Car> getAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> TakeCategory()
        {
            return db.Category.Where(i => i.status == DAL.Model.ORM.Entity.Enum.Enum.Status.Active || i.status == DAL.Model.ORM.Entity.Enum.Enum.Status.Update).ToList();
        }

        public List<User> TakeUser()
        {
            return db.User.Where(i => i.status == DAL.Model.ORM.Entity.Enum.Enum.Status.Active || i.status == DAL.Model.ORM.Entity.Enum.Enum.Status.Update).ToList();
        }

        public void update(int id, string name, string model, string color, string description, int year, decimal price, string picture, string pictureUrl, int categoryID, int userID)
        {
            throw new NotImplementedException();
        }

       
    }
}
