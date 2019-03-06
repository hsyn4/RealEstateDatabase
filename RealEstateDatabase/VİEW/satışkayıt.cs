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
    public partial class satışkayıt : Form
    {
        public satışkayıt()
        {
            InitializeComponent();
        }
        satışkayıtpresenter skpresenter = new satışkayıtpresenter();
        private void satışkayıt_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            skpresenter.satışkayıtInsert(comboBox4.SelectedValue.ToString(), comboBox3.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), textBox6.Text);
    
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            skpresenter.satışkayıtDelete(dkk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            skpresenter.satışkayıtUpdate(dkk, comboBox4.SelectedValue.ToString(), comboBox3.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), textBox6.Text);
     
        }
    }
}
