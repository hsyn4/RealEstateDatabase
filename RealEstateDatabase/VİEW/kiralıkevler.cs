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
    public partial class kiralıkevler : Form
    {
        public kiralıkevler()
        {
            InitializeComponent();
        }
        kiralıkevpresenter kiralıkpr = new kiralıkevpresenter();

        private void kiralıkevler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.kiralık_ev' table. You can move, or remove it, as needed.
            this.kiralık_evTableAdapter.Fill(this.emlakDataSet.kiralık_ev);
            }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kiralıkpr.kiralıkevInsert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
       
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            kiralıkpr.kiralıkevDelete(dk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            int dk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            kiralıkpr.kiralıkevUpdate(dk,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
       

        }
    }
}
