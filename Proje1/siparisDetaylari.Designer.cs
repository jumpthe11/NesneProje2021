namespace Proje1
{
    partial class siparisDetaylari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGeridon = new System.Windows.Forms.Button();
            this.btnOdemeyap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGeridon
            // 
            this.btnGeridon.Location = new System.Drawing.Point(12, 423);
            this.btnGeridon.Name = "btnGeridon";
            this.btnGeridon.Size = new System.Drawing.Size(165, 23);
            this.btnGeridon.TabIndex = 1;
            this.btnGeridon.Text = "SEPETE GERİ DÖN";
            this.btnGeridon.UseVisualStyleBackColor = true;
            this.btnGeridon.Click += new System.EventHandler(this.btnGeridon_Click);
            // 
            // btnOdemeyap
            // 
            this.btnOdemeyap.Location = new System.Drawing.Point(930, 423);
            this.btnOdemeyap.Name = "btnOdemeyap";
            this.btnOdemeyap.Size = new System.Drawing.Size(165, 23);
            this.btnOdemeyap.TabIndex = 1;
            this.btnOdemeyap.Text = "ÖDEME YAP";
            this.btnOdemeyap.UseVisualStyleBackColor = true;
            this.btnOdemeyap.Click += new System.EventHandler(this.btnOdemeyap_Click);
            // 
            // siparisDetaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1107, 458);
            this.Controls.Add(this.btnOdemeyap);
            this.Controls.Add(this.btnGeridon);
            this.Controls.Add(this.dataGridView1);
            this.Name = "siparisDetaylari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet Detayları";
            this.Load += new System.EventHandler(this.siparisDetaylari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGeridon;
        private Button btnOdemeyap;
    }
}