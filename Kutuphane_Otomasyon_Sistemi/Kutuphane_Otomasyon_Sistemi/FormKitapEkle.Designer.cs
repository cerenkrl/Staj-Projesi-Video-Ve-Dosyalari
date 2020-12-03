namespace Kutuphane_Otomasyon_Sistemi
{
    partial class FormKitapEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textSira = new System.Windows.Forms.TextBox();
            this.textRaf = new System.Windows.Forms.TextBox();
            this.cbDolap = new System.Windows.Forms.ComboBox();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.cbTürü = new System.Windows.Forms.ComboBox();
            this.textSayfaSayisi = new System.Windows.Forms.TextBox();
            this.textBasimYili = new System.Windows.Forms.TextBox();
            this.cbYayinevi = new System.Windows.Forms.ComboBox();
            this.textKitabinAdi = new System.Windows.Forms.TextBox();
            this.textKayit = new System.Windows.Forms.TextBox();
            this.cbYazarinAdi = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textFiltrele = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitabın Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazarın Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yayınevi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basım Yılı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dolap:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Raf:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sıra:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textSira, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.textRaf, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbDolap, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.textAciklama, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbTürü, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textSayfaSayisi, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBasimYili, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbYayinevi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textKitabinAdi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textKayit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbYazarinAdi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.502772F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30869F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.763401F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.839187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.687615F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 536);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // textSira
            // 
            this.textSira.Location = new System.Drawing.Point(185, 484);
            this.textSira.Name = "textSira";
            this.textSira.Size = new System.Drawing.Size(176, 22);
            this.textSira.TabIndex = 9;
            // 
            // textRaf
            // 
            this.textRaf.Location = new System.Drawing.Point(185, 448);
            this.textRaf.Name = "textRaf";
            this.textRaf.Size = new System.Drawing.Size(176, 22);
            this.textRaf.TabIndex = 8;
            // 
            // cbDolap
            // 
            this.cbDolap.FormattingEnabled = true;
            this.cbDolap.Location = new System.Drawing.Point(185, 407);
            this.cbDolap.Name = "cbDolap";
            this.cbDolap.Size = new System.Drawing.Size(176, 24);
            this.cbDolap.TabIndex = 7;
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(185, 336);
            this.textAciklama.Multiline = true;
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(176, 60);
            this.textAciklama.TabIndex = 6;
            // 
            // cbTürü
            // 
            this.cbTürü.FormattingEnabled = true;
            this.cbTürü.Location = new System.Drawing.Point(185, 291);
            this.cbTürü.Name = "cbTürü";
            this.cbTürü.Size = new System.Drawing.Size(176, 24);
            this.cbTürü.TabIndex = 5;
            // 
            // textSayfaSayisi
            // 
            this.textSayfaSayisi.Location = new System.Drawing.Point(185, 243);
            this.textSayfaSayisi.Name = "textSayfaSayisi";
            this.textSayfaSayisi.Size = new System.Drawing.Size(176, 22);
            this.textSayfaSayisi.TabIndex = 4;
            // 
            // textBasimYili
            // 
            this.textBasimYili.Location = new System.Drawing.Point(185, 195);
            this.textBasimYili.Name = "textBasimYili";
            this.textBasimYili.Size = new System.Drawing.Size(176, 22);
            this.textBasimYili.TabIndex = 3;
            // 
            // cbYayinevi
            // 
            this.cbYayinevi.FormattingEnabled = true;
            this.cbYayinevi.Location = new System.Drawing.Point(185, 147);
            this.cbYayinevi.Name = "cbYayinevi";
            this.cbYayinevi.Size = new System.Drawing.Size(176, 24);
            this.cbYayinevi.TabIndex = 2;
            // 
            // textKitabinAdi
            // 
            this.textKitabinAdi.Location = new System.Drawing.Point(185, 51);
            this.textKitabinAdi.Name = "textKitabinAdi";
            this.textKitabinAdi.Size = new System.Drawing.Size(176, 22);
            this.textKitabinAdi.TabIndex = 0;
            // 
            // textKayit
            // 
            this.textKayit.Location = new System.Drawing.Point(185, 3);
            this.textKayit.Name = "textKayit";
            this.textKayit.ReadOnly = true;
            this.textKayit.Size = new System.Drawing.Size(176, 22);
            this.textKayit.TabIndex = 11;
            // 
            // cbYazarinAdi
            // 
            this.cbYazarinAdi.FormattingEnabled = true;
            this.cbYazarinAdi.Location = new System.Drawing.Point(185, 99);
            this.cbYazarinAdi.Name = "cbYazarinAdi";
            this.cbYazarinAdi.Size = new System.Drawing.Size(176, 24);
            this.cbYazarinAdi.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonTemizle, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonKaydet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSil, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 559);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(364, 52);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.Indigo;
            this.buttonTemizle.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTemizle.Location = new System.Drawing.Point(245, 3);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(115, 46);
            this.buttonTemizle.TabIndex = 15;
            this.buttonTemizle.Text = "TEMİZLE";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.Indigo;
            this.buttonKaydet.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKaydet.Location = new System.Drawing.Point(3, 3);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(115, 46);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click_1);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Indigo;
            this.buttonSil.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSil.Location = new System.Drawing.Point(124, 3);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(115, 46);
            this.buttonSil.TabIndex = 14;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 15);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 533);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textFiltrele
            // 
            this.textFiltrele.Location = new System.Drawing.Point(1135, 574);
            this.textFiltrele.Name = "textFiltrele";
            this.textFiltrele.Size = new System.Drawing.Size(146, 22);
            this.textFiltrele.TabIndex = 14;
            this.textFiltrele.TextChanged += new System.EventHandler(this.textFiltrele_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1040, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Filtrele :";
            // 
            // FormKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1320, 629);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textFiltrele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormKitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKitapEkle";
            this.Load += new System.EventHandler(this.FormKitapEkle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textSira;
        private System.Windows.Forms.TextBox textRaf;
        private System.Windows.Forms.ComboBox cbDolap;
        private System.Windows.Forms.TextBox textAciklama;
        private System.Windows.Forms.ComboBox cbTürü;
        private System.Windows.Forms.TextBox textSayfaSayisi;
        private System.Windows.Forms.TextBox textBasimYili;
        private System.Windows.Forms.ComboBox cbYayinevi;
        private System.Windows.Forms.TextBox textKitabinAdi;
        private System.Windows.Forms.TextBox textKayit;
        private System.Windows.Forms.ComboBox cbYazarinAdi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textFiltrele;
        private System.Windows.Forms.Label label12;
    }
}