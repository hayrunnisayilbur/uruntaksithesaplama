using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urun_taksit_hesaplama
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int taksit, tutar;
            double taksitliTutar;
            taksit = Convert.ToInt32(txtTutar.Text);
            tutar = Convert.ToInt32(txtTutar.Text);

            taksitliTutar = (double)tutar / taksit;
            lblSonuc.Text = taksitliTutar.ToString();


        }

        private void tbTaksit_Scroll(object sender, EventArgs e)
        {
            lblTaksit.Text = tbTaksit.Value.ToString();
        }
    }
}
