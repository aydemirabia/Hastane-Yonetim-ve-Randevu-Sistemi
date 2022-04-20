
namespace bolum1
{
    partial class frmDoktorBilgiDuzenle
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
            this.mskdDoktorDuzenTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoktorDuzenSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoktorDuzenSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoktorDuzenAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDoktorDuzenBrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mskdDoktorDuzenTC
            // 
            this.mskdDoktorDuzenTC.Location = new System.Drawing.Point(147, 103);
            this.mskdDoktorDuzenTC.Mask = "00000000000";
            this.mskdDoktorDuzenTC.Name = "mskdDoktorDuzenTC";
            this.mskdDoktorDuzenTC.Size = new System.Drawing.Size(149, 20);
            this.mskdDoktorDuzenTC.TabIndex = 42;
            this.mskdDoktorDuzenTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "TC Kimlik No:";
            // 
            // txtDoktorDuzenSifre
            // 
            this.txtDoktorDuzenSifre.Location = new System.Drawing.Point(147, 177);
            this.txtDoktorDuzenSifre.Name = "txtDoktorDuzenSifre";
            this.txtDoktorDuzenSifre.Size = new System.Drawing.Size(149, 20);
            this.txtDoktorDuzenSifre.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(85, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Şifre:";
            // 
            // txtDoktorDuzenSoyad
            // 
            this.txtDoktorDuzenSoyad.Location = new System.Drawing.Point(147, 61);
            this.txtDoktorDuzenSoyad.Name = "txtDoktorDuzenSoyad";
            this.txtDoktorDuzenSoyad.Size = new System.Drawing.Size(149, 20);
            this.txtDoktorDuzenSoyad.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Soyad:";
            // 
            // txtDoktorDuzenAd
            // 
            this.txtDoktorDuzenAd.Location = new System.Drawing.Point(147, 23);
            this.txtDoktorDuzenAd.Name = "txtDoktorDuzenAd";
            this.txtDoktorDuzenAd.Size = new System.Drawing.Size(149, 20);
            this.txtDoktorDuzenAd.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(98, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ad:";
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBilgiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(147, 220);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(149, 32);
            this.btnBilgiGuncelle.TabIndex = 43;
            this.btnBilgiGuncelle.Text = "Bilgi Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Branş:";
            // 
            // cbDoktorDuzenBrans
            // 
            this.cbDoktorDuzenBrans.FormattingEnabled = true;
            this.cbDoktorDuzenBrans.Location = new System.Drawing.Point(147, 137);
            this.cbDoktorDuzenBrans.Name = "cbDoktorDuzenBrans";
            this.cbDoktorDuzenBrans.Size = new System.Drawing.Size(149, 21);
            this.cbDoktorDuzenBrans.TabIndex = 45;
            // 
            // frmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 286);
            this.Controls.Add(this.cbDoktorDuzenBrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.mskdDoktorDuzenTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoktorDuzenSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDoktorDuzenSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoktorDuzenAd);
            this.Controls.Add(this.label3);
            this.Name = "frmDoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.frmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdDoktorDuzenTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoktorDuzenSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoktorDuzenSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoktorDuzenAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBilgiGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDoktorDuzenBrans;
    }
}