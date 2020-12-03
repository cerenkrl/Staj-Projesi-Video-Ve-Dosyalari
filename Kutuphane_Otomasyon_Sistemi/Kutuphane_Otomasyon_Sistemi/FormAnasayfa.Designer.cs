namespace Kutuphane_Otomasyon_Sistemi
{
    partial class FormAnasayfa
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
            this.buttonEmanetIslem = new System.Windows.Forms.Button();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.buttonOkuyucuEkle = new System.Windows.Forms.Button();
            this.buttonIstatistik = new System.Windows.Forms.Button();
            this.buttonAyarlar = new System.Windows.Forms.Button();
            this.buttonCIKIS = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dgEmanetler = new System.Windows.Forms.TabPage();
            this.dgvEmanetler = new System.Windows.Forms.DataGridView();
            this.dgMevcutKitaplar = new System.Windows.Forms.TabPage();
            this.dgvMevcutKitaplar = new System.Windows.Forms.DataGridView();
            this.dgOkuyucular = new System.Windows.Forms.TabPage();
            this.dgvOkuyucular = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.dgEmanetler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).BeginInit();
            this.dgMevcutKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutKitaplar)).BeginInit();
            this.dgOkuyucular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOkuyucular)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEmanetIslem
            // 
            this.buttonEmanetIslem.BackColor = System.Drawing.Color.Indigo;
            this.buttonEmanetIslem.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEmanetIslem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEmanetIslem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEmanetIslem.Location = new System.Drawing.Point(12, 48);
            this.buttonEmanetIslem.Name = "buttonEmanetIslem";
            this.buttonEmanetIslem.Size = new System.Drawing.Size(154, 75);
            this.buttonEmanetIslem.TabIndex = 0;
            this.buttonEmanetIslem.Text = "Emanet İşlemleri";
            this.buttonEmanetIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEmanetIslem.UseVisualStyleBackColor = false;
            this.buttonEmanetIslem.Click += new System.EventHandler(this.buttonEmanetIslem_Click);
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.BackColor = System.Drawing.Color.Indigo;
            this.buttonKitapEkle.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKitapEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKitapEkle.Location = new System.Drawing.Point(172, 48);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(156, 75);
            this.buttonKitapEkle.TabIndex = 1;
            this.buttonKitapEkle.Text = "Kitap Ekle";
            this.buttonKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKitapEkle.UseVisualStyleBackColor = false;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // buttonOkuyucuEkle
            // 
            this.buttonOkuyucuEkle.BackColor = System.Drawing.Color.Indigo;
            this.buttonOkuyucuEkle.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOkuyucuEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOkuyucuEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOkuyucuEkle.Location = new System.Drawing.Point(334, 48);
            this.buttonOkuyucuEkle.Name = "buttonOkuyucuEkle";
            this.buttonOkuyucuEkle.Size = new System.Drawing.Size(151, 75);
            this.buttonOkuyucuEkle.TabIndex = 2;
            this.buttonOkuyucuEkle.Text = "Okuyucu Ekle";
            this.buttonOkuyucuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOkuyucuEkle.UseVisualStyleBackColor = false;
            this.buttonOkuyucuEkle.Click += new System.EventHandler(this.buttonOkuyucuEkle_Click);
            // 
            // buttonIstatistik
            // 
            this.buttonIstatistik.BackColor = System.Drawing.Color.Indigo;
            this.buttonIstatistik.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIstatistik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonIstatistik.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIstatistik.Location = new System.Drawing.Point(647, 48);
            this.buttonIstatistik.Name = "buttonIstatistik";
            this.buttonIstatistik.Size = new System.Drawing.Size(152, 75);
            this.buttonIstatistik.TabIndex = 3;
            this.buttonIstatistik.Text = "İstatistik";
            this.buttonIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIstatistik.UseVisualStyleBackColor = false;
            this.buttonIstatistik.Click += new System.EventHandler(this.buttonIstatistik_Click);
            // 
            // buttonAyarlar
            // 
            this.buttonAyarlar.BackColor = System.Drawing.Color.Indigo;
            this.buttonAyarlar.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAyarlar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAyarlar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAyarlar.Location = new System.Drawing.Point(491, 48);
            this.buttonAyarlar.Name = "buttonAyarlar";
            this.buttonAyarlar.Size = new System.Drawing.Size(150, 75);
            this.buttonAyarlar.TabIndex = 4;
            this.buttonAyarlar.Text = "Ayarlar";
            this.buttonAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAyarlar.UseVisualStyleBackColor = false;
            this.buttonAyarlar.Click += new System.EventHandler(this.buttonAyarlar_Click);
            // 
            // buttonCIKIS
            // 
            this.buttonCIKIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCIKIS.BackColor = System.Drawing.Color.Indigo;
            this.buttonCIKIS.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCIKIS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCIKIS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCIKIS.Location = new System.Drawing.Point(877, 48);
            this.buttonCIKIS.Name = "buttonCIKIS";
            this.buttonCIKIS.Size = new System.Drawing.Size(148, 75);
            this.buttonCIKIS.TabIndex = 5;
            this.buttonCIKIS.Text = "ÇIKIŞ";
            this.buttonCIKIS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCIKIS.UseVisualStyleBackColor = false;
            this.buttonCIKIS.Click += new System.EventHandler(this.buttonCIKIS_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dgEmanetler);
            this.tabControl1.Controls.Add(this.dgMevcutKitaplar);
            this.tabControl1.Controls.Add(this.dgOkuyucular);
            this.tabControl1.Location = new System.Drawing.Point(12, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 408);
            this.tabControl1.TabIndex = 6;
            // 
            // dgEmanetler
            // 
            this.dgEmanetler.Controls.Add(this.dgvEmanetler);
            this.dgEmanetler.Location = new System.Drawing.Point(4, 25);
            this.dgEmanetler.Name = "dgEmanetler";
            this.dgEmanetler.Padding = new System.Windows.Forms.Padding(3);
            this.dgEmanetler.Size = new System.Drawing.Size(1009, 379);
            this.dgEmanetler.TabIndex = 0;
            this.dgEmanetler.Text = "Emanet Kitaplar";
            this.dgEmanetler.UseVisualStyleBackColor = true;
            // 
            // dgvEmanetler
            // 
            this.dgvEmanetler.AllowUserToAddRows = false;
            this.dgvEmanetler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmanetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmanetler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanetler.Location = new System.Drawing.Point(7, 4);
            this.dgvEmanetler.MultiSelect = false;
            this.dgvEmanetler.Name = "dgvEmanetler";
            this.dgvEmanetler.ReadOnly = true;
            this.dgvEmanetler.RowHeadersVisible = false;
            this.dgvEmanetler.RowHeadersWidth = 51;
            this.dgvEmanetler.RowTemplate.Height = 24;
            this.dgvEmanetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmanetler.Size = new System.Drawing.Size(1019, 390);
            this.dgvEmanetler.TabIndex = 0;
            // 
            // dgMevcutKitaplar
            // 
            this.dgMevcutKitaplar.Controls.Add(this.dgvMevcutKitaplar);
            this.dgMevcutKitaplar.Location = new System.Drawing.Point(4, 25);
            this.dgMevcutKitaplar.Name = "dgMevcutKitaplar";
            this.dgMevcutKitaplar.Padding = new System.Windows.Forms.Padding(3);
            this.dgMevcutKitaplar.Size = new System.Drawing.Size(1009, 379);
            this.dgMevcutKitaplar.TabIndex = 1;
            this.dgMevcutKitaplar.Text = "Mevcut Kitaplar";
            this.dgMevcutKitaplar.UseVisualStyleBackColor = true;
            // 
            // dgvMevcutKitaplar
            // 
            this.dgvMevcutKitaplar.AllowUserToAddRows = false;
            this.dgvMevcutKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMevcutKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMevcutKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMevcutKitaplar.Location = new System.Drawing.Point(7, 7);
            this.dgvMevcutKitaplar.MultiSelect = false;
            this.dgvMevcutKitaplar.Name = "dgvMevcutKitaplar";
            this.dgvMevcutKitaplar.ReadOnly = true;
            this.dgvMevcutKitaplar.RowHeadersVisible = false;
            this.dgvMevcutKitaplar.RowHeadersWidth = 51;
            this.dgvMevcutKitaplar.RowTemplate.Height = 24;
            this.dgvMevcutKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMevcutKitaplar.Size = new System.Drawing.Size(1212, 391);
            this.dgvMevcutKitaplar.TabIndex = 0;
            // 
            // dgOkuyucular
            // 
            this.dgOkuyucular.Controls.Add(this.dgvOkuyucular);
            this.dgOkuyucular.Location = new System.Drawing.Point(4, 25);
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.Padding = new System.Windows.Forms.Padding(3);
            this.dgOkuyucular.Size = new System.Drawing.Size(1009, 379);
            this.dgOkuyucular.TabIndex = 2;
            this.dgOkuyucular.Text = "Okuyucular";
            this.dgOkuyucular.UseVisualStyleBackColor = true;
            // 
            // dgvOkuyucular
            // 
            this.dgvOkuyucular.AllowUserToAddRows = false;
            this.dgvOkuyucular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOkuyucular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOkuyucular.Location = new System.Drawing.Point(9, 3);
            this.dgvOkuyucular.MultiSelect = false;
            this.dgvOkuyucular.Name = "dgvOkuyucular";
            this.dgvOkuyucular.ReadOnly = true;
            this.dgvOkuyucular.RowHeadersVisible = false;
            this.dgvOkuyucular.RowHeadersWidth = 51;
            this.dgvOkuyucular.RowTemplate.Height = 24;
            this.dgvOkuyucular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOkuyucular.Size = new System.Drawing.Size(1004, 380);
            this.dgvOkuyucular.TabIndex = 0;
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1054, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCIKIS);
            this.Controls.Add(this.buttonAyarlar);
            this.Controls.Add(this.buttonIstatistik);
            this.Controls.Add(this.buttonOkuyucuEkle);
            this.Controls.Add(this.buttonKitapEkle);
            this.Controls.Add(this.buttonEmanetIslem);
            this.Name = "FormAnasayfa";
            this.Text = "FormAnasayfa";
            this.Activated += new System.EventHandler(this.FormAnasayfa_Activated);
            this.Load += new System.EventHandler(this.FormAnasayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.dgEmanetler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).EndInit();
            this.dgMevcutKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutKitaplar)).EndInit();
            this.dgOkuyucular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOkuyucular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmanetIslem;
        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.Button buttonOkuyucuEkle;
        private System.Windows.Forms.Button buttonIstatistik;
        private System.Windows.Forms.Button buttonAyarlar;
        private System.Windows.Forms.Button buttonCIKIS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dgEmanetler;
        private System.Windows.Forms.DataGridView dgvEmanetler;
        private System.Windows.Forms.TabPage dgMevcutKitaplar;
        private System.Windows.Forms.DataGridView dgvMevcutKitaplar;
        private System.Windows.Forms.TabPage dgOkuyucular;
        private System.Windows.Forms.DataGridView dgvOkuyucular;
    }
}