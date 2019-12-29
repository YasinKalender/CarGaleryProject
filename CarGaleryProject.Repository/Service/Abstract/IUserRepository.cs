using CarGaleryProject.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarGaleryProject.DAL.Model.ORM.Entity.Enum.Role;

namespace CarGaleryProject.Repository.Service.Abstract
{
    public interface IUserRepository
    {
        void add(string name, string surname,string city,string adress,string tel,Roles roles);
        void update(int id,string name, string surname, string city, string adress, string tel, Roles roles);

        void delete(int id);

        List<User> FindUser(string name);

        List<User> GetAllUser();

        List<User> DateAddUser(DateTime start, DateTime end);

        void GetEnum(ComboBox comboBox, ComboBox comboBox1);


    }
}
