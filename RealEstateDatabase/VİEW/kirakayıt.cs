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
    public partial class kirakayıt : Form
    {
        public kirakayıt()
        {
            InitializeComponent();
        }
        kirakayıtpresenter kkpresenter = new kirakayıtpresenter();
        private void kirakayıt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.kiracı' table. You can move, or remove it, as needed.
            this.kiracıTableAdapter.Fill(this.emlakDataSet.kiracı);
            // TODO: This line of code loads data into the 'emlakDataSet.temsilci' table. You can move, or remove it, as needed.
            this.temsilciTableAdapter.Fill(this.emlakDataSet.temsilci);
            // TODO: This line of code loads data into the 'emlakDataSet.kiralık_ev' table. You can move, or remove it, as needed.
            this.kiralık_evTableAdapter.Fill(this.emlakDataSet.kiralık_ev);
            // TODO: This line of code loads data into the 'emlakDataSet.ev_sahibi' table. You can move, or remove it, as needed.
            this.ev_sahibiTableAdapter.Fill(this.emlakDataSet.ev_sahibi);
            // TODO: This line of code loads data into the 'emlakDataSet.kira_kayıt' table. You can move, or remove it, as needed.
            this.kira_kayıtTableAdapter.Fill(this.emlakDataSet.kira_kayıt);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kkpresenter.kirakayıtInsert(comboBox4.SelectedValue.ToString(), comboBox3.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(),textBox6.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            kkpresenter.kirakayıtDelete(dkk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            kkpresenter.kirakayıtUpdate(dkk, comboBox4.SelectedValue.ToString(), comboBox3.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), textBox6.Text);
        }
    }
}
