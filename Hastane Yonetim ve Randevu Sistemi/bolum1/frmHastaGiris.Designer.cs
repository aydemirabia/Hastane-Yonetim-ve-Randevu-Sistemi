
namespace bolum1
{
    partial class frmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHastaGirisYap = new System.Windows.Forms.Button();
            this.linkGirisYap = new System.Windows.Forms.LinkLabel();
            this.mskdHastaGirisTC = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaGirisSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(123, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // btnHastaGirisYap
            // 
            this.btnHastaGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGirisYap.Location = new System.Drawing.Point(145, 194);
            this.btnHastaGirisYap.Name = "btnHastaGirisYap";
            this.btnHastaGirisYap.Size = new System.Drawing.Size(112, 31);
            this.btnHastaGirisYap.TabIndex = 3;
            this.btnHastaGirisYap.Text = "Giriş Yap";
            this.btnHastaGirisYap.UseVisualStyleBackColor = true;
            this.btnHastaGirisYap.Click += new System.EventHandler(this.btnHastaGirisYap_Click);
            // 
            // linkGirisYap
            // 
            this.linkGirisYap.AutoSize = true;
            this.linkGirisYap.Location = new System.Drawing.Point(162, 252);
            this.linkGirisYap.Name = "linkGirisYap";
            this.linkGirisYap.Size = new System.Drawing.Size(77, 13);
            this.linkGirisYap.TabIndex = 4;
            this.linkGirisYap.TabStop = true;
            this.linkGirisYap.Text = "ÜYE OLUNUZ";
            this.linkGirisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGirisYap_LinkClicked);
            // 
            // mskdHastaGirisTC
            // 
            this.mskdHastaGirisTC.Location = new System.Drawing.Point(185, 92);
            this.mskdHastaGirisTC.Mask = "00000000000";
            this.mskdHastaGirisTC.Name = "mskdHastaGirisTC";
            this.mskdHastaGirisTC.Size = new System.Drawing.Size(149, 20);
            this.mskdHastaGirisTC.TabIndex = 5;
            this.mskdHastaGirisTC.ValidatingType = typeof(int);
            // 
            // txtHastaGirisSifre
            // 
            this.txtHastaGirisSifre.Location = new System.Drawing.Point(185, 143);
            this.txtHastaGirisSifre.Name = "txtHastaGirisSifre";
            this.txtHastaGirisSifre.PasswordChar = '*';
            this.txtHastaGirisSifre.Size = new System.Drawing.Size(149, 20);
            this.txtHastaGirisSifre.TabIndex = 6;
            // 
            // frmHastaGiris
            // 
            this.AcceptButton = this.btnHastaGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(399, 301);
            this.Controls.Add(this.txtHastaGirisSifre);
            this.Controls.Add(this.mskdHastaGirisTC);
            this.Controls.Add(this.linkGirisYap);
            this.Controls.Add(this.btnHastaGirisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHastaGiris";
            this.Text = "Hasta Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHastaGirisYap;
        private System.Windows.Forms.LinkLabel linkGirisYap;
        private System.Windows.Forms.MaskedTextBox mskdHastaGirisTC;
        private System.Windows.Forms.TextBox txtHastaGirisSifre;
    }
}