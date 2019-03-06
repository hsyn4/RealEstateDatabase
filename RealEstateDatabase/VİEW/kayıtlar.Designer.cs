namespace RealEstateDatabase.VİEW
{
    partial class kayıtlar
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
            this.btnKiraKayıt = new System.Windows.Forms.Button();
            this.btnSatışKayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKiraKayıt
            // 
            this.btnKiraKayıt.Location = new System.Drawing.Point(12, 30);
            this.btnKiraKayıt.Name = "btnKiraKayıt";
            this.btnKiraKayıt.Size = new System.Drawing.Size(107, 87);
            this.btnKiraKayıt.TabIndex = 0;
            this.btnKiraKayıt.Text = "kira kayıt";
            this.btnKiraKayıt.UseVisualStyleBackColor = true;
            this.btnKiraKayıt.Click += new System.EventHandler(this.btnKiraKayıt_Click);
            // 
            // btnSatışKayıt
            // 
            this.btnSatışKayıt.Location = new System.Drawing.Point(155, 30);
            this.btnSatışKayıt.Name = "btnSatışKayıt";
            this.btnSatışKayıt.Size = new System.Drawing.Size(107, 87);
            this.btnSatışKayıt.TabIndex = 1;
            this.btnSatışKayıt.Text = "Satış Kayıt";
            this.btnSatışKayıt.UseVisualStyleBackColor = true;
            this.btnSatışKayıt.Click += new System.EventHandler(this.btnSatışKayıt_Click);
            // 
            // kayıtlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 262);
            this.Controls.Add(this.btnSatışKayıt);
            this.Controls.Add(this.btnKiraKayıt);
            this.Name = "kayıtlar";
            this.Text = "kayıtlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKiraKayıt;
        private System.Windows.Forms.Button btnSatışKayıt;
    }
}