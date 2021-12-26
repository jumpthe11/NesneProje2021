namespace Proje1
{
    partial class yoneticiEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYoneticiekle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYoneticiekle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textSifre);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 250);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnYoneticiekle
            // 
            this.btnYoneticiekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYoneticiekle.Image = global::Proje1.Properties.Resources.Kyo_Tux_Phuzion_Sign_Add;
            this.btnYoneticiekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiekle.Location = new System.Drawing.Point(100, 106);
            this.btnYoneticiekle.Name = "btnYoneticiekle";
            this.btnYoneticiekle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnYoneticiekle.Size = new System.Drawing.Size(175, 33);
            this.btnYoneticiekle.TabIndex = 26;
            this.btnYoneticiekle.Text = "YÖNETİCİ EKLE";
            this.btnYoneticiekle.UseVisualStyleBackColor = true;
            this.btnYoneticiekle.Click += new System.EventHandler(this.btnYoneticiekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(42, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(52, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "TC";
            // 
            // textSifre
            // 
            this.textSifre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textSifre.Location = new System.Drawing.Point(100, 51);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(175, 23);
            this.textSifre.TabIndex = 21;
            // 
            // txtTC
            // 
            this.txtTC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTC.Location = new System.Drawing.Point(100, 22);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(175, 23);
            this.txtTC.TabIndex = 18;
            // 
            // yoneticiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(342, 274);
            this.Controls.Add(this.groupBox1);
            this.Name = "yoneticiEkle";
            this.Text = "Yönetici Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnYoneticiekle;
        private Label label8;
        private Label label7;
        private TextBox textSifre;
        private TextBox txtTC;
    }
}