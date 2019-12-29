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
    public partial class CarAdd : Form
    {
        public CarAdd()
        {
            InitializeComponent();
        }
        CarRepository carRepository = new CarRepository();
        private void CarAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = carRepository.TakeCategory();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;

            comboBox2.DataSource = carRepository.TakeUser();
            comboBox2.DisplayMember = "FirstName";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedIndex = -1;
        }
        string fileName;
        private void Button1_Click(object sender, EventArgs e)
        {
            ofdAdd.Filter = "JPG | *.jpg";
            if (ofdAdd.ShowDialog() == DialogResult.OK)
            {
                txtAddPictureUrl.Text = ofdAdd.FileName;
                fileName = ofdAdd.FileName;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            carRepository.add(txtCarName.Text, txtCarModel.Text, txtCarColor.Text, txtCarDesc.Text, Convert.ToInt32(txtYear.Text), Convert.ToDecimal(txtprice.Text),fileName ,(int)(comboBox1.SelectedValue), (int)(comboBox2.SelectedValue));
            carRepository.TextDelete(groupBox1);
        }
    }
}
