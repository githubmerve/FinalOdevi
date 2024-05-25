namespace finalproje
{
    partial class DokumanListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DokumanListele));
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dkmGuncelleButton = new System.Windows.Forms.Button();
            this.anasayfaButton = new System.Windows.Forms.Button();
            this.dkmSilButtton = new System.Windows.Forms.Button();
            this.dkmListButton = new System.Windows.Forms.Button();
            this.dkmEmanetButton = new System.Windows.Forms.Button();
            this.dkmEkleButton = new System.Windows.Forms.Button();
            this.dataGridViewEmanet = new System.Windows.Forms.DataGridView();
            this.dataGridViewDokuman = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDokuman)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.kullaniciBilgiPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kullaniciBilgiPanel.BackgroundImage")));
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(200, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(1034, 30);
            this.kullaniciBilgiPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dkmGuncelleButton);
            this.panel1.Controls.Add(this.anasayfaButton);
            this.panel1.Controls.Add(this.dkmSilButtton);
            this.panel1.Controls.Add(this.dkmListButton);
            this.panel1.Controls.Add(this.dkmEmanetButton);
            this.panel1.Controls.Add(this.dkmEkleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 679);
            this.panel1.TabIndex = 2;
            // 
            // dkmGuncelleButton
            // 
            this.dkmGuncelleButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dkmGuncelleButton.FlatAppearance.BorderSize = 0;
            this.dkmGuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dkmGuncelleButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dkmGuncelleButton.Location = new System.Drawing.Point(0, 207);
            this.dkmGuncelleButton.Name = "dkmGuncelleButton";
            this.dkmGuncelleButton.Size = new System.Drawing.Size(200, 70);
            this.dkmGuncelleButton.TabIndex = 1;
            this.dkmGuncelleButton.Text = "Döküman Güncelle";
            this.dkmGuncelleButton.UseVisualStyleBackColor = false;
            this.dkmGuncelleButton.Click += new System.EventHandler(this.dkmGuncelleButton_Click);
            // 
            // anasayfaButton
            // 
            this.anasayfaButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.anasayfaButton.FlatAppearance.BorderSize = 0;
            this.anasayfaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfaButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaButton.Location = new System.Drawing.Point(0, 0);
            this.anasayfaButton.Name = "anasayfaButton";
            this.anasayfaButton.Size = new System.Drawing.Size(200, 70);
            this.anasayfaButton.TabIndex = 8;
            this.anasayfaButton.Text = "Anasayfa";
            this.anasayfaButton.UseVisualStyleBackColor = false;
            this.anasayfaButton.Click += new System.EventHandler(this.anasayfaButton_Click);
            // 
            // dkmSilButtton
            // 
            this.dkmSilButtton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dkmSilButtton.FlatAppearance.BorderSize = 0;
            this.dkmSilButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dkmSilButtton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dkmSilButtton.Location = new System.Drawing.Point(0, 140);
            this.dkmSilButtton.Name = "dkmSilButtton";
            this.dkmSilButtton.Size = new System.Drawing.Size(200, 70);
            this.dkmSilButtton.TabIndex = 0;
            this.dkmSilButtton.Text = "Döküman Sil";
            this.dkmSilButtton.UseVisualStyleBackColor = false;
            this.dkmSilButtton.Click += new System.EventHandler(this.dkmSilButtton_Click_1);
            // 
            // dkmListButton
            // 
            this.dkmListButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dkmListButton.FlatAppearance.BorderSize = 0;
            this.dkmListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dkmListButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dkmListButton.Location = new System.Drawing.Point(0, 334);
            this.dkmListButton.Name = "dkmListButton";
            this.dkmListButton.Size = new System.Drawing.Size(200, 70);
            this.dkmListButton.TabIndex = 2;
            this.dkmListButton.Text = "Döküman Listele";
            this.dkmListButton.UseVisualStyleBackColor = false;
            this.dkmListButton.Click += new System.EventHandler(this.dkmListButton_Click);
            // 
            // dkmEmanetButton
            // 
            this.dkmEmanetButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dkmEmanetButton.FlatAppearance.BorderSize = 0;
            this.dkmEmanetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dkmEmanetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dkmEmanetButton.Location = new System.Drawing.Point(0, 270);
            this.dkmEmanetButton.Name = "dkmEmanetButton";
            this.dkmEmanetButton.Size = new System.Drawing.Size(200, 70);
            this.dkmEmanetButton.TabIndex = 1;
            this.dkmEmanetButton.Text = "Döküman Emaneti";
            this.dkmEmanetButton.UseVisualStyleBackColor = false;
            this.dkmEmanetButton.Click += new System.EventHandler(this.dkmEmanetButton_Click);
            // 
            // dkmEkleButton
            // 
            this.dkmEkleButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dkmEkleButton.FlatAppearance.BorderSize = 0;
            this.dkmEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dkmEkleButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dkmEkleButton.Location = new System.Drawing.Point(0, 70);
            this.dkmEkleButton.Name = "dkmEkleButton";
            this.dkmEkleButton.Size = new System.Drawing.Size(200, 70);
            this.dkmEkleButton.TabIndex = 0;
            this.dkmEkleButton.Text = "Döküman Ekle";
            this.dkmEkleButton.UseVisualStyleBackColor = false;
            this.dkmEkleButton.Click += new System.EventHandler(this.dkmEkleButton_Click);
            // 
            // dataGridViewEmanet
            // 
            this.dataGridViewEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmanet.Location = new System.Drawing.Point(239, 100);
            this.dataGridViewEmanet.Name = "dataGridViewEmanet";
            this.dataGridViewEmanet.RowHeadersWidth = 51;
            this.dataGridViewEmanet.RowTemplate.Height = 24;
            this.dataGridViewEmanet.Size = new System.Drawing.Size(962, 221);
            this.dataGridViewEmanet.TabIndex = 3;
            this.dataGridViewEmanet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewDokuman
            // 
            this.dataGridViewDokuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDokuman.Location = new System.Drawing.Point(239, 386);
            this.dataGridViewDokuman.Name = "dataGridViewDokuman";
            this.dataGridViewDokuman.RowHeadersWidth = 51;
            this.dataGridViewDokuman.RowTemplate.Height = 24;
            this.dataGridViewDokuman.Size = new System.Drawing.Size(962, 240);
            this.dataGridViewDokuman.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "EMANETTEKİ DÖKÜMANLAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(233, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "DÖKÜMANLAR";
            // 
            // DokumanListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDokuman);
            this.Controls.Add(this.dataGridViewEmanet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Name = "DokumanListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DokumanListele";
            this.Load += new System.EventHandler(this.DokumanListele_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDokuman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dkmGuncelleButton;
        private System.Windows.Forms.Button anasayfaButton;
        private System.Windows.Forms.Button dkmSilButtton;
        private System.Windows.Forms.Button dkmListButton;
        private System.Windows.Forms.Button dkmEmanetButton;
        private System.Windows.Forms.Button dkmEkleButton;
        private System.Windows.Forms.DataGridView dataGridViewEmanet;
        private System.Windows.Forms.DataGridView dataGridViewDokuman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}