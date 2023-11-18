using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hava_sıcaklığı_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sicaklik = Convert.ToInt32(txtSicaklik.Text);

            if (sicaklik < 10)
            {
                lblSonuc.Text = "hava soğuk: " + sicaklik + "C°";
            }
            else if (sicaklik> 10 && sicaklik<25 ) 
            {
                lblSonuc.Text = "hava hafif sıcak: " + sicaklik+ "C°";
            }
            else
            {
                lblSonuc.Text = "çok sıcak: " + sicaklik + "C°";
            }
        }
    }
}
