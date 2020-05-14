using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKA
{
    public partial class Hesap_Bilgisi : Form
    {
        public Hesap_Bilgisi()
        {
            InitializeComponent();
        }

        private void EVET_Click(object sender, EventArgs e)
        {
            HESAP_MENÜSÜ git = new HESAP_MENÜSÜ(); //hesap formuna gider
            git.Show(); //git gösterir
            this.Hide(); //hesap bilgisini gizler

            
        }

        private void Hesap_Bilgisi_Load(object sender, EventArgs e)
        {

        }

        private void HAYIR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İŞLEMİNİZ BİTMİŞTİR."); // ekrana işleminiz bitmiştir. iyi günler yazar
            Application.Exit(); //işlemi sonlandırır
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
