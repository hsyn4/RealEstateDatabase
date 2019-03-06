using RealEstateDatabase.PRESENTER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateDatabase.VİEW
{
    public partial class kayıtlar : Form
    {
        public kayıtlar()
        {
            InitializeComponent();
        }
        satışkayıt frmsatış = new satışkayıt();
        kirakayıt frmkirakayıt = new kirakayıt();
        ShowPresenter presenter = new ShowPresenter();


        private void btnKiraKayıt_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmkirakayıt);
        }

        private void btnSatışKayıt_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmsatış);
        }
    }
}
