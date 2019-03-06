namespace RealEstateDatabase.VİEW
{
    partial class şehirler
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
            this.şehiridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şehirismiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şehirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakDataSet = new RealEstateDatabase.emlakDataSet();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.şehir = new System.Windows.Forms.Label();
            this.şehirTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.şehirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.şehirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.şehiridDataGridViewTextBoxColumn,
            this.şehirismiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.şehirBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(261, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // şehiridDataGridViewTextBoxColumn
            // 
            this.şehiridDataGridViewTextBoxColumn.DataPropertyName = "şehir_id";
            this.şehiridDataGridViewTextBoxColumn.HeaderText = "şehir_id";
            this.şehiridDataGridViewTextBoxColumn.Name = "şehiridDataGridViewTextBoxColumn";
            this.şehiridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // şehirismiDataGridViewTextBoxColumn
            // 
            this.şehirismiDataGridViewTextBoxColumn.DataPropertyName = "şehir_ismi";
            this.şehirismiDataGridViewTextBoxColumn.HeaderText = "şehir_ismi";
            this.şehirismiDataGridViewTextBoxColumn.Name = "şehirismiDataGridViewTextBoxColumn";
            // 
            // şehirBindingSource
            // 
            this.şehirBindingSource.DataMember = "şehir";
            this.şehirBindingSource.DataSource = this.emlakDataSet;
            // 
            // emlakDataSet
            // 
            this.emlakDataSet.DataSetName = "emlakDataSet";
            this.emlakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(449, 209);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 18;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(357, 209);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(264, 209);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // şehir
            // 
            this.şehir.AutoSize = true;
            this.şehir.Location = new System.Drawing.Point(29, 33);
            this.şehir.Name = "şehir";
            this.şehir.Size = new System.Drawing.Size(29, 13);
            this.şehir.TabIndex = 10;
            this.şehir.Text = "şehir";
            // 
            // şehirTableAdapter
            // 
            this.şehirTableAdapter.ClearBeforeFill = true;
            // 
            // şehirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.şehir);
            this.Name = "şehirler";
            this.Text = "şehirler";
            this.Load += new System.EventHandler(this.şehirler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.şehirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label şehir;
        private emlakDataSet emlakDataSet;
        private System.Windows.Forms.BindingSource şehirBindingSource;
        private emlakDataSetTableAdapters.şehirTableAdapter şehirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn şehiridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şehirismiDataGridViewTextBoxColumn;
    }
}