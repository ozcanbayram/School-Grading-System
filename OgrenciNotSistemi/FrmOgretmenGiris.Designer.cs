namespace OgrenciNotSistemi
{
    partial class FrmOgretmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenGiris));
            this.mskOgretmenNo = new System.Windows.Forms.MaskedTextBox();
            this.btnOgretmenGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskOgretmenNo
            // 
            this.mskOgretmenNo.Location = new System.Drawing.Point(50, 76);
            this.mskOgretmenNo.Mask = "0000";
            this.mskOgretmenNo.Name = "mskOgretmenNo";
            this.mskOgretmenNo.Size = new System.Drawing.Size(132, 34);
            this.mskOgretmenNo.TabIndex = 6;
            this.mskOgretmenNo.ValidatingType = typeof(int);
            // 
            // btnOgretmenGiris
            // 
            this.btnOgretmenGiris.Location = new System.Drawing.Point(50, 129);
            this.btnOgretmenGiris.Name = "btnOgretmenGiris";
            this.btnOgretmenGiris.Size = new System.Drawing.Size(132, 41);
            this.btnOgretmenGiris.TabIndex = 5;
            this.btnOgretmenGiris.Text = "Giriş Yap";
            this.btnOgretmenGiris.UseVisualStyleBackColor = true;
            this.btnOgretmenGiris.Click += new System.EventHandler(this.btnOgretmenGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğretmen No";
            // 
            // FrmOgretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(232, 203);
            this.Controls.Add(this.mskOgretmenNo);
            this.Controls.Add(this.btnOgretmenGiris);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgretmenGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Giriş Sayfası";
            this.Load += new System.EventHandler(this.FrmOgretmenGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskOgretmenNo;
        private System.Windows.Forms.Button btnOgretmenGiris;
        private System.Windows.Forms.Label label1;
    }
}