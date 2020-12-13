using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAvion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAutobus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (rbAvion.Checked) {
                string txt = "odabrali ste prijevoz avionom";
                txtIspis.Text = txt;
            }
            if (rbAutobus.Checked) {
                string txt2 = "odabrali ste prijevoz autobusom";
                txtIspis.Text = txt2;
            }
            if (rbVlastitiPrijevoz.Checked)
            {
                string txt3 = "odabrali ste prijevoz avionom";
                 txtIspis.Text=txt3;
            }
        }

        private void txtIspis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
