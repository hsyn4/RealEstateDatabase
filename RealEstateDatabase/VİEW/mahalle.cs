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
    public partial class mahalle : Form
    {
        public mahalle()
        {
            InitializeComponent();
        }
        mahallepresenter mpre = new mahallepresenter();

        private void mahalle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.mahalle' table. You can move, or remove it, as needed.
            this.mahalleTableAdapter.Fill(this.emlakDataSet.mahalle);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            mpre.mahalleInsert(textBox1.Text,comboBox1.SelectedValue.ToString());
        }

        private void btnSil_Click(object sender, EventArgs e){
        int dk = (int)dataGridView1.CurrentRow.Cells[0].Value;

            mpre.mahalleDelete(dk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {int dk = (int)dataGridView1.CurrentRow.Cells[0].Value;
        mpre.mahalleUpdate(dk, textBox1.Text, comboBox1.SelectedValue.ToString());
        }
    }
}
