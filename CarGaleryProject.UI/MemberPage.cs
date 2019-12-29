using CarGaleryProject.DAL.Model.ORM.Entity.Concrete;
using CarGaleryProject.DAL.ProjectContext;
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
    public partial class MemberPage : Form
    {
        public MemberPage()
        {
            InitializeComponent();
        }


        CarsContext db = new CarsContext();

        int EklenenButonlar_Height = 0;
        int Soldan = 0, Ustten = 0;
        private void MemberPage_Load(object sender, EventArgs e)
        {

            List<Car> cars = db.Car.Where(i => i.status == DAL.Model.ORM.Entity.Enum.Enum.Status.Active || i.status == DAL.Model.ORM.Entity.Enum.Enum.Status.Update).ToList();

            foreach (var item in cars)
            {

                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                GroupBox groupBox = new GroupBox();
                PictureBox pictureBox = new PictureBox();
                Label labeltitle = new Label();
                Label labelContent = new Label();

                flowLayoutPanel.Width = 55555200;
                flowLayoutPanel.Height = 600;
                flowLayoutPanel.Location = new Point(200, 80);

                groupBox.Size = new Size(1000, 1000);

                labeltitle.Text = item.CarName;
                labeltitle.AutoSize = true;
                labeltitle.Width = flowLayoutPanel.Width;

                pictureBox.Height = 329;
                pictureBox.Image = new Bitmap(item.pictureURL);
                pictureBox.Width = flowLayoutPanel.Width;

                labelContent.AutoSize = false;
                labelContent.Text = item.CarDescription;
                labelContent.Height = 100;
                labelContent.Width = flowLayoutPanel.Width;

                flowLayoutPanel.Controls.Add(labeltitle);
                flowLayoutPanel.Controls.Add(pictureBox);
                flowLayoutPanel.Controls.Add(labelContent);
                this.Controls.Add(flowLayoutPanel);
                Ustten = (flowLayoutPanel.Height * (EklenenButonlar_Height / flowLayoutPanel.Height));

                EklenenButonlar_Height += flowLayoutPanel.Height;

                switch (EklenenButonlar_Height > this.Height)
                {
                    case true:
                        Ustten = 0;
                        Soldan += flowLayoutPanel.Width + 100;
                        EklenenButonlar_Height = flowLayoutPanel.Height;
                        break;
                }
                flowLayoutPanel.Location = new Point(Soldan + 0, Ustten + 20);

            }

        }
    }
}
