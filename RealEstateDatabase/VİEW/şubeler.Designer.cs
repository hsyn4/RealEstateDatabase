namespace RealEstateDatabase.VİEW
{
    partial class şubeler
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
            this.btnŞehir = new System.Windows.Forms.Button();
            this.btnMahalle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emlakDataSet = new RealEstateDatabase.emlakDataSet();
            this.dükkanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dükkanTableAdapter = new RealEstateDatabase.emlakDataSetTableAdapters.dükkanTableAdapter();
            this.dükkanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dükkanadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dükkantelnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dükkanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnŞehir
            // 
            this.btnŞehir.Location = new System.Drawing.Point(736, 27);
            this.btnŞehir.Name = "btnŞehir";
            this.btnŞehir.Size = new System.Drawing.Size(75, 23);
            this.btnŞehir.TabIndex = 0;
            this.btnŞehir.Text = "şehirler";
            this.btnŞehir.UseVisualStyleBackColor = true;
            this.btnŞehir.Click += new System.EventHandler(this.btnŞehir_Click);
            // 
            // btnMahalle
            // 
            this.btnMahalle.Location = new System.Drawing.Point(736, 97);
            this.btnMahalle.Name = "btnMahalle";
            this.btnMahalle.Size = new System.Drawing.Size(75, 23);
            this.btnMahalle.TabIndex = 1;
            this.btnMahalle.Text = "mahalle";
            this.btnMahalle.UseVisualStyleBackColor = true;
            this.btnMahalle.Click += new System.EventHandler(this.btnMahalle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dükkanidDataGridViewTextBoxColumn,
            this.dükkanadıDataGridViewTextBoxColumn,
            this.dükkantelnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dükkanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(271, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(456, 211);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 22;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(364, 211);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(271, 211);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "şube";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "tel no";
            // 
            // emlakDataSet
            // 
            this.emlakDataSet.DataSetName = "emlakDataSet";
            this.emlakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dükkanBindingSource
            // 
            this.dükkanBindingSource.DataMember = "dükkan";
            this.dükkanBindingSource.DataSource = this.emlakDataSet;
            // 
            // dükkanTableAdapter
            // 
            this.dükkanTableAdapter.ClearBeforeFill = true;
            // 
            // dükkanidDataGridViewTextBoxColumn
            // 
            this.dükkanidDataGridViewTextBoxColumn.DataPropertyName = "dükkan_id";
            this.dükkanidDataGridViewTextBoxColumn.HeaderText = "dükkan_id";
            this.dükkanidDataGridViewTextBoxColumn.Name = "dükkanidDataGridViewTextBoxColumn";
            this.dükkanidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dükkanadıDataGridViewTextBoxColumn
            // 
            this.dükkanadıDataGridViewTextBoxColumn.DataPropertyName = "dükkan_adı";
            this.dükkanadıDataGridViewTextBoxColumn.HeaderText = "dükkan_adı";
            this.dükkanadıDataGridViewTextBoxColumn.Name = "dükkanadıDataGridViewTextBoxColumn";
            // 
            // dükkantelnoDataGridViewTextBoxColumn
            // 
            this.dükkantelnoDataGridViewTextBoxColumn.DataPropertyName = "dükkan_telno";
            this.dükkantelnoDataGridViewTextBoxColumn.HeaderText = "dükkan_telno";
            this.dükkantelnoDataGridViewTextBoxColumn.Name = "dükkantelnoDataGridViewTextBoxColumn";
            // 
            // şubeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 330);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnMahalle);
            this.Controls.Add(this.btnŞehir);
            this.Name = "şubeler";
            this.Text = "şubeler";
            this.Load += new System.EventHandler(this.şubeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dükkanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnŞehir;
        private System.Windows.Forms.Button btnMahalle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private emlakDataSet emlakDataSet;
        private System.Windows.Forms.BindingSource dükkanBindingSource;
        private emlakDataSetTableAdapters.dükkanTableAdapter dükkanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dükkanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dükkanadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dükkantelnoDataGridViewTextBoxColumn;
    }
}