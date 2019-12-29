
using CarGaleryProject.DAL.Model.ORM.Entity.Enum;
using CarGaleryProject.Repository.Service.Abstract;
using CarGaleryProject.Repository.Service.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGaleryProject.UI
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }


        UserRepository userRepository = new UserRepository();
     
        private void UserAdd_Load(object sender, EventArgs e)
        {

            userRepository.GetEnum(cmbxRole,cmbxURole);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            userRepository.add(txtName.Text,txtLastName.Text,txtCity.Text,rchAdress.Text,mskdTel.Text,(Role.Roles)System.Enum.Parse(typeof(Role.Roles),cmbxRole.Text));
            dataGridView1.DataSource = userRepository.GetAllUser();
            userRepository.TextDelete(groupBox1);


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                userRepository.update(Convert.ToInt32(txtUID.Text), txtUName.Text, txtULast.Text, txtUCity.Text, rchUAdress.Text, mskdUTel.Text, (Role.Roles)System.Enum.Parse(typeof(Role.Roles), cmbxURole.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen değerleri kontrol ediniz");
            }
            dataGridView1.DataSource = userRepository.GetAllUser();
            userRepository.TextDelete(groupBox2);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                userRepository.delete(Convert.ToInt32(txtDUser.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen geçerli bir id giriniz");
            }

            
            


            dataGridView1.DataSource = userRepository.GetAllUser();
            userRepository.TextDelete(groupBox4);

        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = userRepository.FindUser(txtFUser.Text);
            userRepository.TextDelete(groupBox5);



        }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            userRepository.GetAllUser();
            dataGridView1.DataSource = userRepository.GetAllUser();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = userRepository.DateAddUser(Convert.ToDateTime(mskedStart.Text), Convert.ToDateTime(mskedEnd.Text));
        }
    }
}
