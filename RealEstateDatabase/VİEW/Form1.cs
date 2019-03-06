using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateDatabase.PRESENTER;
using RealEstateDatabase.VİEW;
using RealEstateDatabase.MODEL;

namespace RealEstateDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
    
        ShowPresenter presenter = new ShowPresenter();
        evler frmev = new evler();
        evsahibi frmevs = new evsahibi();
        kayıtlar frmkayıt = new kayıtlar();
        şubeler frmşube = new şubeler();
        temsilciler frmtemsil = new temsilciler();
        kiracılar frmkiracı = new kiracılar();

       // metadata=res://*/MODEL.Model1.csdl|res://*/MODEL.Model1.ssdl|res://*/MODEL.Model1.msl;provider=System.Data.SqlClient;provider connection string="data source=ASUS;initial catalog=emlak;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"

        private void button5_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmev);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmkayıt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmevs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmkiracı);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmtemsil);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            presenter.FormShow(frmşube);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
