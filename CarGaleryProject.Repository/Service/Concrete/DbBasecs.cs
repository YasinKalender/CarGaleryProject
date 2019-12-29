using CarGaleryProject.DAL.ProjectContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGaleryProject.Repository.Service.Abstract
{
    public class DbBasecs
    {

        public CarsContext db;

        public DbBasecs()
        {

           db = new CarsContext();
        }

        public void TextDelete(GroupBox groupBox)
        {

            foreach (Control item in groupBox.Controls)
            {

                if (item is TextBox)
                {
                    item.Text = "";
                }

                if (item is RichTextBox)
                {
                    item.Text = "";
                }

            }



        }

    }
}
