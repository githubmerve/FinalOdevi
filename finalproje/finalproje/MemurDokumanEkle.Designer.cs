namespace finalproje
{
    partial class MemurDokumanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemurDokumanEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.manasayfaButton = new System.Windows.Forms.Button();
            this.mdkmListButton = new System.Windows.Forms.Button();
            this.mdkmEmanetButton = new System.Windows.Forms.Button();
            this.mdkmEkleButton = new System.Windows.Forms.Button();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rafnoButton = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dokumanIdButton = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.turCmbBox1 = new System.Windows.Forms.ComboBox();
            this.dokumanVerenButton = new System.Windows.Forms.TextBox();
            this.dokumanAcıklaButton = new System.Windows.Forms.TextBox();
            this.dokumanAdButton = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.manasayfaButton);
            this.panel1.Controls.Add(this.mdkmListButton);
            this.panel1.Controls.Add(this.mdkmEmanetButton);
            this.panel1.Controls.Add(this.mdkmEkleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 679);
            this.panel1.TabIndex = 0;
            // 
            // manasayfaButton
            // 
            this.manasayfaButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.manasayfaButton.FlatAppearance.BorderSize = 0;
            this.manasayfaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manasayfaButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manasayfaButton.Location = new System.Drawing.Point(0, 0);
            this.manasayfaButton.Name = "manasayfaButton";
            this.manasayfaButton.Size = new System.Drawing.Size(200, 70);
            this.manasayfaButton.TabIndex = 8;
            this.manasayfaButton.Text = "Anasayfa";
            this.manasayfaButton.UseVisualStyleBackColor = false;
            this.manasayfaButton.Click += new System.EventHandler(this.manasayfaButton_Click);
            // 
            // mdkmListButton
            // 
            this.mdkmListButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mdkmListButton.FlatAppearance.BorderSize = 0;
            this.mdkmListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdkmListButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mdkmListButton.Location = new System.Drawing.Point(0, 198);
            this.mdkmListButton.Name = "mdkmListButton";
            this.mdkmListButton.Size = new System.Drawing.Size(200, 70);
            this.mdkmListButton.TabIndex = 2;
            this.mdkmListButton.Text = "Döküman Listele";
            this.mdkmListButton.UseVisualStyleBackColor = false;
            this.mdkmListButton.Click += new System.EventHandler(this.mdkmListButton_Click);
            // 
            // mdkmEmanetButton
            // 
            this.mdkmEmanetButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mdkmEmanetButton.FlatAppearance.BorderSize = 0;
            this.mdkmEmanetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdkmEmanetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mdkmEmanetButton.Location = new System.Drawing.Point(0, 132);
            this.mdkmEmanetButton.Name = "mdkmEmanetButton";
            this.mdkmEmanetButton.Size = new System.Drawing.Size(200, 70);
            this.mdkmEmanetButton.TabIndex = 1;
            this.mdkmEmanetButton.Text = "Döküman Emaneti";
            this.mdkmEmanetButton.UseVisualStyleBackColor = false;
            this.mdkmEmanetButton.Click += new System.EventHandler(this.mdkmEmanetButton_Click);
            // 
            // mdkmEkleButton
            // 
            this.mdkmEkleButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mdkmEkleButton.FlatAppearance.BorderSize = 0;
            this.mdkmEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdkmEkleButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mdkmEkleButton.Location = new System.Drawing.Point(0, 65);
            this.mdkmEkleButton.Name = "mdkmEkleButton";
            this.mdkmEkleButton.Size = new System.Drawing.Size(200, 70);
            this.mdkmEkleButton.TabIndex = 0;
            this.mdkmEkleButton.Text = "Döküman Ekle";
            this.mdkmEkleButton.UseVisualStyleBackColor = false;
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.kullaniciBilgiPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kullaniciBilgiPanel.BackgroundImage")));
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(200, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(1054, 34);
            this.kullaniciBilgiPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 210);
            this.dataGridView1.TabIndex = 38;
            // 
            // rafnoButton
            // 
            this.rafnoButton.Location = new System.Drawing.Point(419, 265);
            this.rafnoButton.Name = "rafnoButton";
            this.rafnoButton.Size = new System.Drawing.Size(193, 22);
            this.rafnoButton.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(251, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Raf No";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(720, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 34;
            this.button1.Text = "Döküman Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dokumanIdButton
            // 
            this.dokumanIdButton.Location = new System.Drawing.Point(419, 89);
            this.dokumanIdButton.Name = "dokumanIdButton";
            this.dokumanIdButton.Size = new System.Drawing.Size(193, 22);
            this.dokumanIdButton.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(251, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Döküman Id";
            // 
            // turCmbBox1
            // 
            this.turCmbBox1.FormattingEnabled = true;
            this.turCmbBox1.Items.AddRange(new object[] {
            "Sınav Belgesi",
            "Yoklama Listesi",
            "Mali Belge",
            "Personel Belgesi",
            "Mazaret Belgesi",
            "Harç Dekontu",
            "Staj Belgesi"});
            this.turCmbBox1.Location = new System.Drawing.Point(419, 204);
            this.turCmbBox1.Name = "turCmbBox1";
            this.turCmbBox1.Size = new System.Drawing.Size(193, 24);
            this.turCmbBox1.TabIndex = 31;
            // 
            // dokumanVerenButton
            // 
            this.dokumanVerenButton.Location = new System.Drawing.Point(944, 146);
            this.dokumanVerenButton.Name = "dokumanVerenButton";
            this.dokumanVerenButton.Size = new System.Drawing.Size(198, 22);
            this.dokumanVerenButton.TabIndex = 30;
            // 
            // dokumanAcıklaButton
            // 
            this.dokumanAcıklaButton.Location = new System.Drawing.Point(944, 92);
            this.dokumanAcıklaButton.Name = "dokumanAcıklaButton";
            this.dokumanAcıklaButton.Size = new System.Drawing.Size(198, 22);
            this.dokumanAcıklaButton.TabIndex = 29;
            // 
            // dokumanAdButton
            // 
            this.dokumanAdButton.Location = new System.Drawing.Point(419, 143);
            this.dokumanAdButton.Name = "dokumanAdButton";
            this.dokumanAdButton.Size = new System.Drawing.Size(193, 22);
            this.dokumanAdButton.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(944, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(251, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dökümanın Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(716, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Döküman Ekleme Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Döküman Adı\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(716, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Teslim Veren";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(716, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dökümanın Açıklaması";
            // 
            // MemurDokumanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 679);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rafnoButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dokumanIdButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.turCmbBox1);
            this.Controls.Add(this.dokumanVerenButton);
            this.Controls.Add(this.dokumanAcıklaButton);
            this.Controls.Add(this.dokumanAdButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MemurDokumanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemurDokumanEkle";
            this.Load += new System.EventHandler(this.MemurDokumanEkle_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Button mdkmEmanetButton;
        private System.Windows.Forms.Button mdkmEkleButton;
        private System.Windows.Forms.Button mdkmListButton;
        private System.Windows.Forms.Button manasayfaButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox rafnoButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dokumanIdButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox turCmbBox1;
        private System.Windows.Forms.TextBox dokumanVerenButton;
        private System.Windows.Forms.TextBox dokumanAcıklaButton;
        private System.Windows.Forms.TextBox dokumanAdButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
