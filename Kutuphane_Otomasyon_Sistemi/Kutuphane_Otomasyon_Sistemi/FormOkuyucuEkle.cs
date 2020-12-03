﻿using Kutuphane_Otomasyon_Sistemi.Modeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKOS.Model;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class FormOkuyucuEkle : Form
    {
        public FormOkuyucuEkle()
        {
            InitializeComponent();
        }

        int okuyucuId = 0;
        string okuyucuFoto = "";
        private void FormOkuyucuEkle_Load(object sender, EventArgs e)
        {
            okuyucularLoad();
        }
        void okuyucuEkle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
            string cinsiyet = "";
            if (radiobtnErkek.Checked)
            {
                cinsiyet = radiobtnErkek.Text;
            }
            else if (radioBtnKadin.Checked)
            {
                cinsiyet = radioBtnKadin.Text;
            }
            parameters.Add(new SqlParameter("@cinsiyeti", SqlDbType.VarChar) { Value = cinsiyet });
            parameters.Add(new SqlParameter("@tc", SqlDbType.VarChar) { Value = txtTc.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedCepTel.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });

            object value = IDataBase.executeScalar("insert into okuyucular (adi, soyadi, cinsiyeti, tc, cepTel, adres) values (@adi, @soyadi, @cinsiyeti, @tc, @cepTel, @adres) select @@IDENTITY", parameters);
            okuyucuId = Convert.ToInt32(value);

            fotoSave();
            okuyucularLoad();
            MessageBox.Show("Okuyucu ekleme işlemi başarılı");
        }

        void okuyucuGuncelle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
            string cinsiyet = "";
            if (radiobtnErkek.Checked)
            {
                cinsiyet = radiobtnErkek.Text;
            }
            else if (radioBtnKadin.Checked)
            {
                cinsiyet = radioBtnKadin.Text;
            }
            parameters.Add(new SqlParameter("@cinsiyeti", SqlDbType.VarChar) { Value = cinsiyet });
            parameters.Add(new SqlParameter("@tc", SqlDbType.VarChar) { Value = txtTc.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedCepTel.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });
            parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId });

            IDataBase.executeNonQuery("update okuyucular set adi = @adi, soyadi = @soyadi, cinsiyeti = @cinsiyeti, tc = @tc, cepTel = @cepTel, adres = @adres where id = @id", parameters);
          

            okuyucularLoad();
            MessageBox.Show("Okuyucu güncelleme işlemi başarılı");
        }

        void okuyucuSil()
        {
            IDataBase.executeNonQuery("update okuyucular set aktif = 0 where id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId });
            temizle();
            okuyucularLoad();
        }

        void temizle()
        {
            okuyucuId = 0;
           radiobtnErkek.Checked = false;
            radioBtnKadin.Checked = false;

            foreach (var item in tableLayoutPanel.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }

                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";
                }
            }
        }
        void okuyucularLoad()
        {
            dgv.DataSource = IDataBase.DataToDataTable(
                "select * from okuyucular where aktif = 1 and adi+' '+soyadi like @search",
                    new SqlParameter("@search", SqlDbType.VarChar) { Value = string.Format("%{0}%", txtFiltrele.Text) });

            dgv.Columns["id"].Visible = false;
        }

        void fotoSave()
        {
            if (!string.IsNullOrEmpty(okuyucuFoto))
            {
                File.Copy(okuyucuFoto, Application.StartupPath + "/profil/" + okuyucuId + ".jpg", true);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (okuyucuId > 0)
            {
                okuyucuGuncelle();
            }
            else
            {
                okuyucuEkle();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                okuyucuId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["id"].Value);

               pictureProfil.ImageLocation = Helper.profilPath(okuyucuId);

                radiobtnErkek.Checked = false;
                radioBtnKadin.Checked = true;

                foreach (DataRow row in IDataBase.DataToDataTable("select * from okuyucular where aktif = 1 and id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
                {
                    txtAd.Text = row["adi"].ToString();
                    txtSoyad.Text = row["soyadi"].ToString();
                    string cinsiyet = row["cinsiyeti"].ToString();
                    if (cinsiyet == radiobtnErkek.Text)
                    {
                        radiobtnErkek.Checked = true;
                    }
                    else if (cinsiyet == radioBtnKadin.Text)
                    {
                        radioBtnKadin.Checked = true;
                    }
                    txtTc.Text = row["tc"].ToString();
                    maskedCepTel.Text = row["cepTel"].ToString();
                    txtAdres.Text = row["adres"].ToString();
                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (okuyucuId > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili okuyucuyu silmek istediğinize emin misiniz?", "Okuyucu Sil", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    okuyucuSil();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi");
                }
            }
            else
            {
                MessageBox.Show("Okuyucu Seçiniz");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtFiltrele_TextChanged(object sender, EventArgs e)
        {
            okuyucularLoad();
        }

        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "(*jpg)|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                okuyucuFoto = openFileDialog.FileName;
                pictureProfil.ImageLocation = okuyucuFoto;
            }
        }
    }
}
