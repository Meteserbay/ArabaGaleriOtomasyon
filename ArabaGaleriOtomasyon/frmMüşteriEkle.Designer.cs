namespace ArabaGaleriOtomasyon
{
    partial class frmMüşteriEkle
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
            this.txtmusteriad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmusterisoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmusteritelefon = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmusteriad
            // 
            this.txtmusteriad.Location = new System.Drawing.Point(158, 51);
            this.txtmusteriad.Name = "txtmusteriad";
            this.txtmusteriad.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // txtmusterisoyad
            // 
            this.txtmusterisoyad.Location = new System.Drawing.Point(158, 84);
            this.txtmusterisoyad.Name = "txtmusterisoyad";
            this.txtmusterisoyad.Size = new System.Drawing.Size(100, 20);
            this.txtmusterisoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // txtmusteritelefon
            // 
            this.txtmusteritelefon.Location = new System.Drawing.Point(158, 116);
            this.txtmusteritelefon.Name = "txtmusteritelefon";
            this.txtmusteritelefon.Size = new System.Drawing.Size(100, 20);
            this.txtmusteritelefon.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(32, 162);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 36);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(169, 162);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(89, 36);
            this.btnCıkıs.TabIndex = 7;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // frmMüşteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtmusteritelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmusterisoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmusteriad);
            this.Name = "frmMüşteriEkle";
            this.Text = "Müşteri Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmusteriad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmusterisoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmusteritelefon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCıkıs;
    }
}