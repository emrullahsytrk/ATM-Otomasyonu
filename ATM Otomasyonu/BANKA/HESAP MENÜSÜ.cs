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
    public partial class HESAP_MENÜSÜ : Form
    {
        public HESAP_MENÜSÜ()
        {
            InitializeComponent();
        }

        private void ÇEK_Click(object sender, EventArgs e)
        {
            PARA_ÇEKME çekme = new PARA_ÇEKME(); //para çekme Formunu Çağırır.
            çekme.Show(); // çekmeyi gösterir.
            this.Hide(); // GİRİŞ Formunu gizler.

        }

        private void TRANSFERİ_Click(object sender, EventArgs e)
        {
            PARA_TRANSFERİ TRANSFER = new PARA_TRANSFERİ(); //PARA TRANSFERİ Formunu Çağırır.
            TRANSFER.Show();
            this.Hide();

        }

        private void YATIR_Click(object sender, EventArgs e)
        {
            PARA_YATIRMA yatırma = new PARA_YATIRMA(); //PARA YATIRMA Formunu Çağırır.
            yatırma.Show(); // yatırmayı gösterir.
            this.Hide(); // GİRİŞ Formunu gizler

        }

        private void BİLGİSİ_Click(object sender, EventArgs e)
        {
            Hesap_Bilgisi bilgi = new Hesap_Bilgisi();
            bilgi.Show();
            this.Hide();
        }
    }
}
