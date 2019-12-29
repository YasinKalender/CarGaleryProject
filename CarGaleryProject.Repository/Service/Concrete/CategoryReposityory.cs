using CarGaleryProject.DAL.Model.ORM.Entity.Concrete;
using CarGaleryProject.Repository.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGaleryProject.Repository.Service.Concrete
{
    public class CategoryReposityory :DbBasecs, ICategoryRepository
    {

        Category category = new Category();
        public void add(string name, string categorydescription)
        {

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(categorydescription))
            {
                MessageBox.Show("Lütfen değerleri boş girmeyiniz..");
                return;
            }

            category.CategoryName = name;
            category.CategoryDescription = categorydescription;
            db.Category.Add(category);
            db.SaveChanges();

            


        }

        public List<Category> dateCategory(DateTime start, DateTime end)
        {
            return db.Category.Where(i => i.AddDate >= start && i.AddDate <= end).ToList();
        }

        public void delete(int id)
        {
            category = db.Category.FirstOrDefault(i => i.ID == id);
            category.status = DAL.Model.ORM.Entity.Enum.Enum.Status.Delete;
            category.DeleteDate = DateTime.Now;
            db.SaveChanges();
        }

        public List<Category> findName(string name)
        {
            return db.Category.Where(i => i.CategoryName == name).ToList();
        }

        public List<Category> getAll()
        {
            return db.Category.ToList();
        }

        public void update(int id, string name, string categorydescription)
        {

            if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(name)|| string.IsNullOrWhiteSpace(categorydescription))
            {
                MessageBox.Show("Lütfen değerleri kontrol ediniz");
                return;
            }


            category = db.Category.FirstOrDefault(i => i.ID == id);
            category.CategoryName = name;
            category.CategoryDescription = categorydescription;
            category.UpdateDate = DateTime.Now;
            category.status = DAL.Model.ORM.Entity.Enum.Enum.Status.Update;
            db.SaveChanges();
        }
    }
}
