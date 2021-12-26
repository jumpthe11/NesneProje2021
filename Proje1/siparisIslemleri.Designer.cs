namespace Proje1
{
    partial class siparisIslemleri
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sepetKapat = new System.Windows.Forms.Button();
            this.btnSepet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(524, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(623, 48);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 10;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(626, 404);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(542, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEPETE GİT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sepetKapat
            // 
            this.sepetKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sepetKapat.Location = new System.Drawing.Point(542, 406);
            this.sepetKapat.Name = "sepetKapat";
            this.sepetKapat.Size = new System.Drawing.Size(75, 47);
            this.sepetKapat.TabIndex = 3;
            this.sepetKapat.Text = "VAZGEÇ";
            this.sepetKapat.UseVisualStyleBackColor = true;
            this.sepetKapat.Click += new System.EventHandler(this.sepetKapat_Click);
            // 
            // btnSepet
            // 
            this.btnSepet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSepet.BackColor = System.Drawing.Color.LightYellow;
            this.btnSepet.BackgroundImage = global::Proje1.Properties.Resources.Fasticon_Shop_Cart_Shop_cart;
            this.btnSepet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSepet.Enabled = false;
            this.btnSepet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSepet.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSepet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSepet.Location = new System.Drawing.Point(542, 48);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(75, 68);
            this.btnSepet.TabIndex = 4;
            this.btnSepet.Text = "0";
            this.btnSepet.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÜRÜN LİSTESİ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(821, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "SEPETTEKİ ÜRÜNLER";
            // 
            // siparisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1261, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSepet);
            this.Controls.Add(this.sepetKapat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "siparisIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş İşlemleri";
            this.Load += new System.EventHandler(this.siparisIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private Button sepetKapat;
        private Button btnSepet;
        private Label label1;
        private Label label2;
    }
}