using CarGaleryProject.DAL.Model.ORM.Entity.Concrete;
using CarGaleryProject.DAL.Model.ORM.Entity.Enum;
using CarGaleryProject.Repository.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarGaleryProject.Repository.Service.Concrete
{
    public class UserRepository :DbBasecs, IUserRepository
    {
        User user = new User();

        public void add(string name, string surname, string city, string adress, string tel, Role.Roles roles)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(adress) || string.IsNullOrWhiteSpace(tel))
            {
                MessageBox.Show("Lütfen bilgeri boş girmeyiniz");
                return;
            }


            user.FirstName = name;
            user.LastName = surname;
            user.City = city;
            user.Adress = adress;
            user.Tel = tel;
            user.roles = roles;
            db.User.Add(user);
            db.SaveChanges();
            
            
        }

        public List<User> DateAddUser(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {

            user = db.User.FirstOrDefault(i => i.ID == id);
            user.status = DAL.Model.ORM.Entity.Enum.Enum.Status.Delete;
            user.DeleteDate = DateTime.Now;
            db.SaveChanges();
        }

        public List<User> FindUser(string name)
        {
            return db.User.Where(i=>i.FirstName==name).ToList();
        }

        public List<User> GetAllUser()
        {
            return db.User.ToList();
        }

        public void GetEnum(ComboBox comboBox,ComboBox comboBox1)
        {
            comboBox.Items.AddRange(System.Enum.GetNames(typeof(Role.Roles)));
            comboBox.SelectedIndex = 0;

            comboBox1.Items.AddRange(System.Enum.GetNames(typeof(Role.Roles)));
            comboBox1.SelectedIndex = 0;
        }

        public void update(int id, string name, string surname, string city, string adress, string tel, Role.Roles roles)
        {

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(adress) || string.IsNullOrWhiteSpace(tel))
            {
                MessageBox.Show("Lütfen bilgeri boş girmeyiniz");
                return;
            }

            try
            {
                user = db.User.FirstOrDefault(i => i.ID == id);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen düzgün bir id değeri giriniz"+ex);
            }
            
            user.FirstName = name;
            user.LastName = surname;
            user.City = city;
            user.Adress = adress;
            user.Tel = tel;
            user.roles = roles;
            user.UpdateDate = DateTime.Now;
            user.status = DAL.Model.ORM.Entity.Enum.Enum.Status.Update;
            db.SaveChanges();
        }
    }
}
