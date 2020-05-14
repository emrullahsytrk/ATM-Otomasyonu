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
    public partial class ALICI : Form
    {
        public ALICI()
        {
            InitializeComponent();
        }

        private void EVET_Click(object sender, EventArgs e)
        {
            HESAP_MENÜSÜ git = new HESAP_MENÜSÜ(); //hesap formuna gider
            git.Show(); //git gösterir
            this.Hide(); //hesap bilgisini gizler
        }

        private void HAYIR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşleminiz Bitmiştir.İyi Günler"); // ekrana işleminiz bitmiştir. iyi günler yazar
            Application.Exit(); //işlemi sonlandırır
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
