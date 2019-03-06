using RealEstateDatabase.MODEL;
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
    public partial class evsahibi : Form
    {
        public evsahibi()
        {
            InitializeComponent();
        }
      //  ev_sahibi EvSahibi = new ev_sahibi();
        emlakEntities emlakent = new emlakEntities();
        evsahibipresenter evspres= new evsahibipresenter();
       
        
        private void evsahibi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet.ev_sahibi' table. You can move, or remove it, as needed.
            this.ev_sahibiTableAdapter.Fill(this.emlakDataSet.ev_sahibi);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            evspres.evsahibiInsert(textBox1.Text,textBox2.Text,textBox3.Text);
          

          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           int dk=(int)dataGridView1.CurrentRow.Cells[0].Value;
            evspres.evsahibiDelete(dk);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            int dkk = (int)dataGridView1.CurrentRow.Cells[0].Value;
            evspres.evsahibiUpdate(dkk,textBox1.Text,textBox2.Text,textBox3.Text);

        }
    }
}
