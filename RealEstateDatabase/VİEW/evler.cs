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
    public partial class evler : Form
    {
        public evler()
        {
            InitializeComponent();
        }
        ShowPresenter presenter = new ShowPresenter();
        kiralıkevler frmkira = new kiralıkevler();
        satılıkevler frmsatılık = new satılıkevler();
       

        private void evler_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKiralık_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmkira);
        }

        private void btnSatılık_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmsatılık);
        }
    }
}
