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
    public partial class satılıkevler : Form
    {
        public satılıkevler()
        {
            InitializeComponent();
        }
        satılıkevpresenter sepresenter = new satılıkevpresenter();
        private void satılıkevler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.satılık_ev' table. You can move, or remove it, as needed.
            this.satılık_evTableAdapter.Fill(this.emlakDataSet.satılık_ev);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sepresenter.satılıkevInsert(textBox6.Text,textBox5.Text,textBox4.Text,textBox8.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox7.Text,comboBox4.SelectedValue.ToString(),comboBox3.SelectedValue.ToString(),comboBox2.SelectedValue.ToString(),);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            sepresenter.satılıkevDelete(dkk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {  int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            sepresenter.satılıkevUpdate(dkk,textBox6.Text,textBox5.Text,textBox4.Text,textBox8.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox7.Text,comboBox4.SelectedValue.ToString(),comboBox3.SelectedValue.ToString(),comboBox2.SelectedValue.ToString(),);
      
        }
    }
}
