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
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }
        CategoryReposityory categoryReposityory = new CategoryReposityory();

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            categoryReposityory.add(txtAddName.Text, richtextDescription.Text);
            dataGridView1.DataSource = categoryReposityory.getAll();
            categoryReposityory.TextDelete(groupBox1);

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                categoryReposityory.update(Convert.ToInt32(txtUId.Text), txtUCategoryName.Text, richtxtUDescription.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen değerleri boş girmeyiniz");
            }
            
            dataGridView1.DataSource = categoryReposityory.getAll();
            categoryReposityory.TextDelete(groupBox3);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                categoryReposityory.delete(Convert.ToInt32(txtCdelete.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen değeri boş girmeyiniz..");
            }
            dataGridView1.DataSource = categoryReposityory.getAll();
            categoryReposityory.TextDelete(groupBox4);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryReposityory.findName(txtFind.Text);
            categoryReposityory.TextDelete(groupBox5);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryReposityory.getAll();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryReposityory.dateCategory(Convert.ToDateTime(mskedStart.Text), Convert.ToDateTime(mskedEnd.Text));
        }
    }
}
