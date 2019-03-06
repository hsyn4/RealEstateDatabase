namespace RealEstateDatabase.VİEW
{
    partial class satılıkevler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.satılıkevidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sokakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapınoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adaparselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katsayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulunduğukatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odasayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonsayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evsahibiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahalleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temsilciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satılıkevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakDataSet = new RealEstateDatabase.emlakDataSet();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.satılık_evTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.satılık_evTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satılıkevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satılıkevidDataGridViewTextBoxColumn,
            this.sokakDataGridViewTextBoxColumn,
            this.kapınoDataGridViewTextBoxColumn,
            this.adaparselDataGridViewTextBoxColumn,
            this.katsayısıDataGridViewTextBoxColumn,
            this.bulunduğukatDataGridViewTextBoxColumn,
            this.odasayısıDataGridViewTextBoxColumn,
            this.salonsayısıDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.evsahibiidDataGridViewTextBoxColumn,
            this.mahalleidDataGridViewTextBoxColumn,
            this.temsilciidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satılıkevBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 150);
            this.dataGridView1.TabIndex = 61;
            // 
            // satılıkevidDataGridViewTextBoxColumn
            // 
            this.satılıkevidDataGridViewTextBoxColumn.DataPropertyName = "satılık_ev_id";
            this.satılıkevidDataGridViewTextBoxColumn.HeaderText = "satılık_ev_id";
            this.satılıkevidDataGridViewTextBoxColumn.Name = "satılıkevidDataGridViewTextBoxColumn";
            this.satılıkevidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sokakDataGridViewTextBoxColumn
            // 
            this.sokakDataGridViewTextBoxColumn.DataPropertyName = "sokak";
            this.sokakDataGridViewTextBoxColumn.HeaderText = "sokak";
            this.sokakDataGridViewTextBoxColumn.Name = "sokakDataGridViewTextBoxColumn";
            // 
            // kapınoDataGridViewTextBoxColumn
            // 
            this.kapınoDataGridViewTextBoxColumn.DataPropertyName = "kapı_no";
            this.kapınoDataGridViewTextBoxColumn.HeaderText = "kapı_no";
            this.kapınoDataGridViewTextBoxColumn.Name = "kapınoDataGridViewTextBoxColumn";
            // 
            // adaparselDataGridViewTextBoxColumn
            // 
            this.adaparselDataGridViewTextBoxColumn.DataPropertyName = "ada_parsel";
            this.adaparselDataGridViewTextBoxColumn.HeaderText = "ada_parsel";
            this.adaparselDataGridViewTextBoxColumn.Name = "adaparselDataGridViewTextBoxColumn";
            // 
            // katsayısıDataGridViewTextBoxColumn
            // 
            this.katsayısıDataGridViewTextBoxColumn.DataPropertyName = "kat_sayısı";
            this.katsayısıDataGridViewTextBoxColumn.HeaderText = "kat_sayısı";
            this.katsayısıDataGridViewTextBoxColumn.Name = "katsayısıDataGridViewTextBoxColumn";
            // 
            // bulunduğukatDataGridViewTextBoxColumn
            // 
            this.bulunduğukatDataGridViewTextBoxColumn.DataPropertyName = "bulunduğu_kat";
            this.bulunduğukatDataGridViewTextBoxColumn.HeaderText = "bulunduğu_kat";
            this.bulunduğukatDataGridViewTextBoxColumn.Name = "bulunduğukatDataGridViewTextBoxColumn";
            // 
            // odasayısıDataGridViewTextBoxColumn
            // 
            this.odasayısıDataGridViewTextBoxColumn.DataPropertyName = "oda_sayısı";
            this.odasayısıDataGridViewTextBoxColumn.HeaderText = "oda_sayısı";
            this.odasayısıDataGridViewTextBoxColumn.Name = "odasayısıDataGridViewTextBoxColumn";
            // 
            // salonsayısıDataGridViewTextBoxColumn
            // 
            this.salonsayısıDataGridViewTextBoxColumn.DataPropertyName = "salon_sayısı";
            this.salonsayısıDataGridViewTextBoxColumn.HeaderText = "salon_sayısı";
            this.salonsayısıDataGridViewTextBoxColumn.Name = "salonsayısıDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // evsahibiidDataGridViewTextBoxColumn
            // 
            this.evsahibiidDataGridViewTextBoxColumn.DataPropertyName = "ev_sahibi_id";
            this.evsahibiidDataGridViewTextBoxColumn.HeaderText = "ev_sahibi_id";
            this.evsahibiidDataGridViewTextBoxColumn.Name = "evsahibiidDataGridViewTextBoxColumn";
            // 
            // mahalleidDataGridViewTextBoxColumn
            // 
            this.mahalleidDataGridViewTextBoxColumn.DataPropertyName = "mahalle_id";
            this.mahalleidDataGridViewTextBoxColumn.HeaderText = "mahalle_id";
            this.mahalleidDataGridViewTextBoxColumn.Name = "mahalleidDataGridViewTextBoxColumn";
            // 
            // temsilciidDataGridViewTextBoxColumn
            // 
            this.temsilciidDataGridViewTextBoxColumn.DataPropertyName = "temsilci_id";
            this.temsilciidDataGridViewTextBoxColumn.HeaderText = "temsilci_id";
            this.temsilciidDataGridViewTextBoxColumn.Name = "temsilciidDataGridViewTextBoxColumn";
            // 
            // satılıkevBindingSource
            // 
            this.satılıkevBindingSource.DataMember = "satılık_ev";
            this.satılıkevBindingSource.DataSource = this.emlakDataSet;
            // 
            // emlakDataSet
            // 
            this.emlakDataSet.DataSetName = "emlakDataSet";
            this.emlakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(194, 141);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 60;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(102, 141);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 59;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(9, 141);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 58;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(518, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "mahalle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "temsilci";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "ev sahibi";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(567, 9);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 53;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(567, 36);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 52;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(567, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 51;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(84, 92);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "kat sayısı";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(320, 92);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "fiyat";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "ada\\parsel";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(84, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "kapı no";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(84, 14);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "sokak";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(320, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "salon";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "oda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "kat";
            // 
            // satılık_evTableAdapter
            // 
            this.satılık_evTableAdapter.ClearBeforeFill = true;
            // 
            // satılıkevler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 406);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "satılıkevler";
            this.Text = "satılıkevler";
            this.Load += new System.EventHandler(this.satılıkevler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satılıkevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private emlakDataSet emlakDataSet;
        private System.Windows.Forms.BindingSource satılıkevBindingSource;
        private emlakDataSetTableAdapters.satılık_evTableAdapter satılık_evTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn satılıkevidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sokakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapınoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adaparselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katsayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulunduğukatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odasayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonsayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evsahibiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahalleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temsilciidDataGridViewTextBoxColumn;
    }
}