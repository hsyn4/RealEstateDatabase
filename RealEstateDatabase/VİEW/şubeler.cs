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
    public partial class şubeler : Form
    {
        public şubeler()
        {
            InitializeComponent();
        }
        ShowPresenter presenter = new ShowPresenter();
        şehirler frmşehir = new şehirler();
        mahalle frmmah = new mahalle();
        private void btnŞehir_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmşehir);
        }

        private void btnMahalle_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmmah);
        }

        private void şubeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.dükkan' table. You can move, or remove it, as needed.
            this.dükkanTableAdapter.Fill(this.emlakDataSet.dükkan);

        }
    }
}
