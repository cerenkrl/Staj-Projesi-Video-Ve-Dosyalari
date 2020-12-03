using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKOS.Model;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class FormKitapEkle : Form
    {
        public FormKitapEkle()
        {
            InitializeComponent();
        }

        int kitapId = 0;

        private void FormKitapEkle_Load(object sender, EventArgs e)
        {
            comboBoxFill();
            kitaplarLoad();
        }
        
        void comboBoxFill()
        {
            foreach (DataRow row in IDataBase.DataToDataTable("select * from dolaplar").Rows)
                cbDolap.Items.Add(row["adi"].ToString());

            foreach (DataRow row in IDataBase.DataToDataTable("select * from türler").Rows)
                cbTürü.Items.Add(row["adi"].ToString());

            foreach (DataRow row in IDataBase.DataToDataTable("select * from yayinevleri").Rows)
                cbYayinevi.Items.Add(row["adi"].ToString());

            foreach (DataRow row in IDataBase.DataToDataTable("select * from yazarlar").Rows)
                cbYazarinAdi.Items.Add(row["adi"].ToString());
        }

        void kitaplarLoad()
        {
            dataGridView1.DataSource = IDataBase.DataToDataTable("select * from kitaplar where aktif = 1 and yazarAdi+' '+KitapAdi like @search",
                    new SqlParameter("@search", SqlDbType.VarChar) { Value = string.Format("%{0}%", textFiltrele.Text) });

            dataGridView1.Columns["id"].Visible = false;
        }
      

        int getKayitNo()
        {
            foreach (DataRow row in IDataBase.DataToDataTable("select ISNULL(MAX(kayitNo), 0) + 1 from kitaplar where aktif = 1").Rows)
            {
                return Convert.ToInt32(row[0]);
            }
            return 1;
        }


        void kitapEkle()
        {
           int kayitNo = getKayitNo();

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kayitNo", SqlDbType.Int) { Value = kayitNo });
            parameters.Add(new SqlParameter("@KitapAdi", SqlDbType.VarChar) { Value = textKitabinAdi.Text });
            parameters.Add(new SqlParameter("@yazarAdi", SqlDbType.VarChar) { Value = cbYazarinAdi.Text });
            parameters.Add(new SqlParameter("@yayinevi", SqlDbType.VarChar) { Value = cbYayinevi.Text });
            parameters.Add(new SqlParameter("@basimYili", SqlDbType.VarChar) { Value = textBasimYili.Text });
            parameters.Add(new SqlParameter("@sayfaSayisi", SqlDbType.VarChar) { Value = textSayfaSayisi.Text });
            parameters.Add(new SqlParameter("@tur", SqlDbType.VarChar) { Value = cbTürü.Text });
            parameters.Add(new SqlParameter("@aciklama", SqlDbType.VarChar) { Value = textAciklama.Text });
            parameters.Add(new SqlParameter("@dolap", SqlDbType.VarChar) { Value = cbDolap.Text });
            parameters.Add(new SqlParameter("@raf", SqlDbType.VarChar) { Value = textRaf.Text });
            parameters.Add(new SqlParameter("@sira", SqlDbType.VarChar) { Value = textSira.Text });

            IDataBase.executeNonQuery("insert into kitaplar (kayitNo, KitapAdi, yazarAdi, yayinevi, basimYili, sayfaSayisi, tur, aciklama, dolap, raf, sira) values (@kayitNo, @KitapAdi, @yazarAdi, @yayinevi, @basimYili, @sayfaSayisi, @tur, @aciklama, @dolap, @raf, @sira)", parameters);

            textKayit.Text = kayitNo.ToString();
            kitaplarLoad();

            MessageBox.Show("Kitap ekleme işlemi başarılı");
        }

        void kitapGuncelle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@KitapAdi", SqlDbType.VarChar) { Value = textKitabinAdi.Text });
            parameters.Add(new SqlParameter("@yazarAdi", SqlDbType.VarChar) { Value = cbYazarinAdi.Text });
            parameters.Add(new SqlParameter("@yayinevi", SqlDbType.VarChar) { Value = cbYayinevi.Text });
            parameters.Add(new SqlParameter("@basimYili", SqlDbType.VarChar) { Value = textBasimYili.Text });
            parameters.Add(new SqlParameter("@sayfaSayisi", SqlDbType.VarChar) { Value = textSayfaSayisi.Text });
            parameters.Add(new SqlParameter("@tur", SqlDbType.VarChar) { Value = cbTürü.Text });
            parameters.Add(new SqlParameter("@aciklama", SqlDbType.VarChar) { Value = textAciklama.Text });
            parameters.Add(new SqlParameter("@dolap", SqlDbType.VarChar) { Value = cbDolap.Text });
            parameters.Add(new SqlParameter("@raf", SqlDbType.VarChar) { Value = textRaf.Text });
            parameters.Add(new SqlParameter("@sira", SqlDbType.VarChar) { Value = textSira.Text });
            parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = kitapId });

            IDataBase.executeNonQuery("update kitaplar set KitapAdi = @KitapAdi, yazarAdi = @yazarAdi, basimYili = @basimYili, sayfaSayisi = @sayfaSayisi, tur = @tur, aciklama = @aciklama, dolap = @dolap, raf = @raf, sira = @sira where id = @id", parameters);

            kitaplarLoad();

            MessageBox.Show("Kitap güncelleme işlemi başarılı");

        }

        void kitapSil()
        {
            IDataBase.executeNonQuery("update kitaplar set aktif = 0 where id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = kitapId });
            kitaplarLoad();

            MessageBox.Show("Kitap silme işlemi başarılı");
        }

        void temizle()
        {
            kitapId = 0;

            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }

                if (item is ComboBox)
                {
                    ((ComboBox)item).Text = "";
                }
            }
        }

      
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void buttonKaydet_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textKitabinAdi.Text) ||
              string.IsNullOrEmpty(cbYazarinAdi.Text) ||
              string.IsNullOrEmpty(cbTürü.Text))
            {
                MessageBox.Show("Kitap Adı, Yazar Adı ve Kitap Türü alanları boş geçilemez");
                return;
            }

            if (kitapId > 0)
            {
                kitapGuncelle();
            }
            else
            {
                kitapEkle();
            }
        }

        private void buttonSil_Click_1(object sender, EventArgs e)
        {
            if (kitapId > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Seçili kitabı silmek istediğinize emin misiniz?", "Kitap Sil", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    kitapSil();
                    temizle();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi!");
                }
            }
            else
            {
                MessageBox.Show("Kitap Seçiniz!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                kitapId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                foreach (DataRow row in IDataBase.DataToDataTable("select * from kitaplar where aktif = 1 and id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = kitapId }).Rows)
                {
                    textKayit.Text = row["kayitNo"].ToString();
                    textKitabinAdi.Text = row["KitapAdi"].ToString();
                    cbYazarinAdi.Text = row["yazarAdi"].ToString();
                    cbYayinevi.Text = row["yayinevi"].ToString();
                    textBasimYili.Text = row["basimYili"].ToString();
                    textSayfaSayisi.Text = row["sayfaSayisi"].ToString();
                    cbTürü.Text = row["tur"].ToString();
                    textAciklama.Text = row["aciklama"].ToString();
                    cbDolap.Text = row["dolap"].ToString();
                    textRaf.Text = row["raf"].ToString();
                    textSira.Text = row["sira"].ToString();
                }
            }
        }

        private void textFiltrele_TextChanged(object sender, EventArgs e)
        {
            kitaplarLoad();
        }
    }
}
