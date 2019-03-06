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
    public partial class kiracılar : Form
    {
        public kiracılar()
        {
            InitializeComponent();
        }
        kiracıpresenter kirapres = new kiracıpresenter();

        private void kiracılar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.kiracı' table. You can move, or remove it, as needed.
            this.kiracıTableAdapter.Fill(this.emlakDataSet.kiracı);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kirapres.kiracıInsert(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            kirapres.kiracıDelete(dk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            kirapres.kiracıUpdate(dkk, textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }
}
