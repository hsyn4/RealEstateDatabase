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
    public partial class temsilciler : Form
    {
        public temsilciler()
        {
            InitializeComponent();
        }
        temsilcipresenter tmslpr = new temsilcipresenter();
        private void temsilciler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.dükkan' table. You can move, or remove it, as needed.
            this.dükkanTableAdapter.Fill(this.emlakDataSet.dükkan);
            // TODO: This line of code loads data into the 'emlakDataSet.temsilci' table. You can move, or remove it, as needed.
            this.temsilciTableAdapter.Fill(this.emlakDataSet.temsilci);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tmslpr.temsilciInsert(textBox1.Text, textBox2.Text, textBox3.Text,comboBox1.SelectedValue.ToString());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            tmslpr.temsilciDelete(dk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            tmslpr.temsilciUpdate(dkk, textBox1.Text, textBox2.Text, textBox3.Text,comboBox1.SelectedValue.ToString());
        }
    }
}
