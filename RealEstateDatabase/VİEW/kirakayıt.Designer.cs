namespace RealEstateDatabase.VİEW
{
    partial class kirakayıt
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
            this.kirakayıtidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evsahibiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralıkevidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temsilciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiracıidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralamafiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kirakayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakDataSet = new RealEstateDatabase.emlakDataSet();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.evsahibiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.kiralıkevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kira_kayıtTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.kira_kayıtTableAdapter();
            this.ev_sahibiTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.ev_sahibiTableAdapter();
            this.kiralık_evTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.kiralık_evTableAdapter();
            this.temsilciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temsilciTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.temsilciTableAdapter();
            this.kiracıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiracıTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.kiracıTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirakayıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evsahibiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralıkevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temsilciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiracıBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kirakayıtidDataGridViewTextBoxColumn,
            this.evsahibiidDataGridViewTextBoxColumn,
            this.kiralıkevidDataGridViewTextBoxColumn,
            this.temsilciidDataGridViewTextBoxColumn,
            this.kiracıidDataGridViewTextBoxColumn,
            this.kiralamafiyatıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kirakayıtBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(230, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 150);
            this.dataGridView1.TabIndex = 65;
            // 
            // kirakayıtidDataGridViewTextBoxColumn
            // 
            this.kirakayıtidDataGridViewTextBoxColumn.DataPropertyName = "kira_kayıt_id";
            this.kirakayıtidDataGridViewTextBoxColumn.HeaderText = "kira_kayıt_id";
            this.kirakayıtidDataGridViewTextBoxColumn.Name = "kirakayıtidDataGridViewTextBoxColumn";
            this.kirakayıtidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evsahibiidDataGridViewTextBoxColumn
            // 
            this.evsahibiidDataGridViewTextBoxColumn.DataPropertyName = "ev_sahibi_id";
            this.evsahibiidDataGridViewTextBoxColumn.HeaderText = "ev_sahibi_id";
            this.evsahibiidDataGridViewTextBoxColumn.Name = "evsahibiidDataGridViewTextBoxColumn";
            // 
            // kiralıkevidDataGridViewTextBoxColumn
            // 
            this.kiralıkevidDataGridViewTextBoxColumn.DataPropertyName = "kiralık_ev_id";
            this.kiralıkevidDataGridViewTextBoxColumn.HeaderText = "kiralık_ev_id";
            this.kiralıkevidDataGridViewTextBoxColumn.Name = "kiralıkevidDataGridViewTextBoxColumn";
            // 
            // temsilciidDataGridViewTextBoxColumn
            // 
            this.temsilciidDataGridViewTextBoxColumn.DataPropertyName = "temsilci_id";
            this.temsilciidDataGridViewTextBoxColumn.HeaderText = "temsilci_id";
            this.temsilciidDataGridViewTextBoxColumn.Name = "temsilciidDataGridViewTextBoxColumn";
            // 
            // kiracıidDataGridViewTextBoxColumn
            // 
            this.kiracıidDataGridViewTextBoxColumn.DataPropertyName = "kiracı_id";
            this.kiracıidDataGridViewTextBoxColumn.HeaderText = "kiracı_id";
            this.kiracıidDataGridViewTextBoxColumn.Name = "kiracıidDataGridViewTextBoxColumn";
            // 
            // kiralamafiyatıDataGridViewTextBoxColumn
            // 
            this.kiralamafiyatıDataGridViewTextBoxColumn.DataPropertyName = "kiralama_fiyatı";
            this.kiralamafiyatıDataGridViewTextBoxColumn.HeaderText = "kiralama_fiyatı";
            this.kiralamafiyatıDataGridViewTextBoxColumn.Name = "kiralamafiyatıDataGridViewTextBoxColumn";
            // 
            // kirakayıtBindingSource
            // 
            this.kirakayıtBindingSource.DataMember = "kira_kayıt";
            this.kirakayıtBindingSource.DataSource = this.emlakDataSet;
            // 
            // emlakDataSet
            // 
            this.emlakDataSet.DataSetName = "emlakDataSet";
            this.emlakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(414, 184);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 64;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(322, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 63;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(230, 184);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 62;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(90, 139);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "kiracı";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kirakayıtBindingSource, "kiracı_id", true));
            this.comboBox1.DataSource = this.kiracıBindingSource;
            this.comboBox1.DisplayMember = "ad";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 82;
            this.comboBox1.ValueMember = "kiracı_id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "ev sahibi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "kiralık ev";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "temsilci";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kirakayıtBindingSource, "ev_sahibi_id", true));
            this.comboBox4.DataSource = this.evsahibiBindingSource;
            this.comboBox4.DisplayMember = "ad";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(91, 21);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 78;
            this.comboBox4.ValueMember = "ev_sahibi_id";
            // 
            // evsahibiBindingSource
            // 
            this.evsahibiBindingSource.DataMember = "ev_sahibi";
            this.evsahibiBindingSource.DataSource = this.emlakDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kirakayıtBindingSource, "kiralık_ev_id", true));
            this.comboBox3.DataSource = this.kiralıkevBindingSource;
            this.comboBox3.DisplayMember = "kiralık_ev_id";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(91, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 77;
            this.comboBox3.ValueMember = "kiralık_ev_id";
            // 
            // kiralıkevBindingSource
            // 
            this.kiralıkevBindingSource.DataMember = "kiralık_ev";
            this.kiralıkevBindingSource.DataSource = this.emlakDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kirakayıtBindingSource, "temsilci_id", true));
            this.comboBox2.DataSource = this.temsilciBindingSource;
            this.comboBox2.DisplayMember = "ad";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 76;
            this.comboBox2.ValueMember = "temsilci_id";
            // 
            // kira_kayıtTableAdapter
            // 
            this.kira_kayıtTableAdapter.ClearBeforeFill = true;
            // 
            // ev_sahibiTableAdapter
            // 
            this.ev_sahibiTableAdapter.ClearBeforeFill = true;
            // 
            // kiralık_evTableAdapter
            // 
            this.kiralık_evTableAdapter.ClearBeforeFill = true;
            // 
            // temsilciBindingSource
            // 
            this.temsilciBindingSource.DataMember = "temsilci";
            this.temsilciBindingSource.DataSource = this.emlakDataSet;
            // 
            // temsilciTableAdapter
            // 
            this.temsilciTableAdapter.ClearBeforeFill = true;
            // 
            // kiracıBindingSource
            // 
            this.kiracıBindingSource.DataMember = "kiracı";
            this.kiracıBindingSource.DataSource = this.emlakDataSet;
            // 
            // kiracıTableAdapter
            // 
            this.kiracıTableAdapter.ClearBeforeFill = true;
            // 
            // kirakayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 354);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "kirakayıt";
            this.Text = "kirakayıt";
            this.Load += new System.EventHandler(this.kirakayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kirakayıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evsahibiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralıkevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temsilciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiracıBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private emlakDataSet emlakDataSet;
        private System.Windows.Forms.BindingSource kirakayıtBindingSource;
        private emlakDataSetTableAdapters.kira_kayıtTableAdapter kira_kayıtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kirakayıtidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evsahibiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralıkevidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temsilciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiracıidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamafiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource evsahibiBindingSource;
        private emlakDataSetTableAdapters.ev_sahibiTableAdapter ev_sahibiTableAdapter;
        private System.Windows.Forms.BindingSource kiralıkevBindingSource;
        private emlakDataSetTableAdapters.kiralık_evTableAdapter kiralık_evTableAdapter;
        private System.Windows.Forms.BindingSource temsilciBindingSource;
        private emlakDataSetTableAdapters.temsilciTableAdapter temsilciTableAdapter;
        private System.Windows.Forms.BindingSource kiracıBindingSource;
        private emlakDataSetTableAdapters.kiracıTableAdapter kiracıTableAdapter;

    }
}