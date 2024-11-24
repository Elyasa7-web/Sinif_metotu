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
    public partial class sinif_metot_ornek_alistirma : Form
    {
        public sinif_metot_ornek_alistirma()
        {
            InitializeComponent();
        }

        private void sinif_metot_ornek_alistirma_Load(object sender, EventArgs e)
        {
            Bina tr = new Bina();
            tr.renk = "Yeşil/Sarı";
            tr.binasene = 2;
            tr.yukseklik = 150.876;
            tr.kat = '8';
            tr.odasayi = 4;
            tr.KİRA = 5000;
            tr.KİRACI = "Memur,Öğretmen,Mühendis";


            label1.Text = tr.renk;
            label2.Text = tr.binasene.ToString();
            label3.Text = tr.yukseklik.ToString();
            label4.Text = tr.kat.ToString();
            label5.Text=tr.odasayi.ToString();
            label6.Text = tr.KİRA.ToString();
            label7.Text = tr.KİRACI;

            pictureBox1.BackColor = Color.GreenYellow;
        }
    }
}
