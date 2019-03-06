namespace RealEstateDatabase.VİEW
{
    partial class evler
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
            this.btnKiralık = new System.Windows.Forms.Button();
            this.btnSatılık = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKiralık
            // 
            this.btnKiralık.Location = new System.Drawing.Point(12, 28);
            this.btnKiralık.Name = "btnKiralık";
            this.btnKiralık.Size = new System.Drawing.Size(75, 56);
            this.btnKiralık.TabIndex = 1;
            this.btnKiralık.Text = "kiralık evler";
            this.btnKiralık.UseVisualStyleBackColor = true;
            this.btnKiralık.Click += new System.EventHandler(this.btnKiralık_Click);
            // 
            // btnSatılık
            // 
            this.btnSatılık.Location = new System.Drawing.Point(135, 28);
            this.btnSatılık.Name = "btnSatılık";
            this.btnSatılık.Size = new System.Drawing.Size(75, 56);
            this.btnSatılık.TabIndex = 2;
            this.btnSatılık.Text = "satılık evler";
            this.btnSatılık.UseVisualStyleBackColor = true;
            this.btnSatılık.Click += new System.EventHandler(this.btnSatılık_Click);
            // 
            // evler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSatılık);
            this.Controls.Add(this.btnKiralık);
            this.Name = "evler";
            this.Text = "evler";
            this.Load += new System.EventHandler(this.evler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKiralık;
        private System.Windows.Forms.Button btnSatılık;
    }
}