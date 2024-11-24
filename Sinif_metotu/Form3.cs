using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_metotu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Bina cv = new Bina();
            cv.renk = "Kahverengi";
            cv.binasene = 8;
            cv.yukseklik = 120.454;
            cv.kat = '5';
            cv.odasayi = 3;
            cv.KİRA = 6000;
            cv.KİRACI = "Aile";

            label1.Text = cv.renk;
            label2.Text = cv.binasene.ToString();
            label3.Text = cv.yukseklik.ToString();
            label4.Text = cv.kat.ToString();
            label5.Text = cv.odasayi.ToString();
            label6.Text = cv.KİRA.ToString();
            label7.Text = cv.KİRACI;

            pictureBox1.BackColor = Color.Brown;
        }
    }
}
