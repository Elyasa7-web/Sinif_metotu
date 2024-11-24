using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_metotu
{
    internal class Bina
    {
        public string renk;
        public int binasene;
        public double yukseklik;
        public char kat;
        public int odasayi;
        private int kira;
        private string kiracialimi;

        public int KİRA
        {
            get { return kira; }
            set { kira = Math.Abs(value); }
        }
        public string KİRACI
        {
            get { return kiracialimi; }
            set { kiracialimi = value.ToUpper(); }
        }
       
    }

}

