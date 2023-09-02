namespace OgrenciNotSistemi
{
    partial class FrmOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.mskOgrenciNo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.Location = new System.Drawing.Point(46, 123);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(132, 41);
            this.btnOgrenciGiris.TabIndex = 2;
            this.btnOgrenciGiris.Text = "Giriş Yap";
            this.btnOgrenciGiris.UseVisualStyleBackColor = true;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // mskOgrenciNo
            // 
            this.mskOgrenciNo.Location = new System.Drawing.Point(46, 70);
            this.mskOgrenciNo.Mask = "0000";
            this.mskOgrenciNo.Name = "mskOgrenciNo";
            this.mskOgrenciNo.Size = new System.Drawing.Size(132, 34);
            this.mskOgrenciNo.TabIndex = 3;
            this.mskOgrenciNo.ValidatingType = typeof(int);
            // 
            // FrmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(232, 203);
            this.Controls.Add(this.mskOgrenciNo);
            this.Controls.Add(this.btnOgrenciGiris);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Giriş Sayfası";
            this.Load += new System.EventHandler(this.FrmOgrenciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciGiris;
        private System.Windows.Forms.MaskedTextBox mskOgrenciNo;
    }
}