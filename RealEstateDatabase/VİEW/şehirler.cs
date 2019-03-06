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
    public partial class şehirler : Form
    {
        public şehirler()
        {
            InitializeComponent();
        }
        şehirpresenter shpr = new şehirpresenter();
        private void şehirler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.şehir' table. You can move, or remove it, as needed.
            this.şehirTableAdapter.Fill(this.emlakDataSet.şehir);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            shpr.şehirInsert(textBox1.Text);
   
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            shpr.şehirDelete(dk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            int dk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            shpr.şehirUpdate(dk,textBox1.Text);
        }
    }
}
