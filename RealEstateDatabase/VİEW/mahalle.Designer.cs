namespace RealEstateDatabase.VİEW
{
    partial class mahalle
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
            this.mahalleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahalleadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şehiridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakDataSet = new RealEstateDatabase.emlakDataSet();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mahalleTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.mahalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahalleidDataGridViewTextBoxColumn,
            this.mahalleadDataGridViewTextBoxColumn,
            this.şehiridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahalleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(260, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // mahalleidDataGridViewTextBoxColumn
            // 
            this.mahalleidDataGridViewTextBoxColumn.DataPropertyName = "mahalle_id";
            this.mahalleidDataGridViewTextBoxColumn.HeaderText = "mahalle_id";
            this.mahalleidDataGridViewTextBoxColumn.Name = "mahalleidDataGridViewTextBoxColumn";
            this.mahalleidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mahalleadDataGridViewTextBoxColumn
            // 
            this.mahalleadDataGridViewTextBoxColumn.DataPropertyName = "mahalle_ad";
            this.mahalleadDataGridViewTextBoxColumn.HeaderText = "mahalle_ad";
            this.mahalleadDataGridViewTextBoxColumn.Name = "mahalleadDataGridViewTextBoxColumn";
            // 
            // şehiridDataGridViewTextBoxColumn
            // 
            this.şehiridDataGridViewTextBoxColumn.DataPropertyName = "şehir_id";
            this.şehiridDataGridViewTextBoxColumn.HeaderText = "şehir_id";
            this.şehiridDataGridViewTextBoxColumn.Name = "şehiridDataGridViewTextBoxColumn";
            // 
            // mahalleBindingSource
            // 
            this.mahalleBindingSource.DataMember = "mahalle";
            this.mahalleBindingSource.DataSource = this.emlakDataSet;
            // 
            // emlakDataSet
            // 
            this.emlakDataSet.DataSetName = "emlakDataSet";
            this.emlakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(445, 192);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 18;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(353, 192);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(260, 192);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "şehir";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "mahalle";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // mahalleTableAdapter
            // 
            this.mahalleTableAdapter.ClearBeforeFill = true;
            // 
            // mahalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 379);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "mahalle";
            this.Text = "mahalle";
            this.Load += new System.EventHandler(this.mahalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private emlakDataSet emlakDataSet;
        private System.Windows.Forms.BindingSource mahalleBindingSource;
        private emlakDataSetTableAdapters.mahalleTableAdapter mahalleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahalleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahalleadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şehiridDataGridViewTextBoxColumn;
    }
}