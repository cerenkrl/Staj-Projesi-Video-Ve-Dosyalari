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
    public partial class FormKayıt : Form
    {
        public FormKayıt()
        {
            InitializeComponent();
        }

        private void FormKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAd.Text) ||
                string.IsNullOrEmpty(textSoyad.Text) ||
                string.IsNullOrEmpty(textKullaniciAdi.Text) ||
                string.IsNullOrEmpty(textSifre.Text) ||
                string.IsNullOrEmpty(textSifreTekrar.Text))
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
                return;
            }
            if (textSifre.Text != textSifreTekrar.Text )
            {
                MessageBox.Show("Girilen Şifreler Aynı Değil!");
                return;
            }
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = textAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = textSoyad.Text });
            parameters.Add(new SqlParameter("@kullaniciAdi", SqlDbType.VarChar) { Value = textKullaniciAdi.Text });
            parameters.Add(new SqlParameter("@sifre", SqlDbType.VarChar) { Value = textSifre.Text });
            IDataBase.executeNonQuery("insert into kullanicilar(adi, soyadi, kullaniciAdi, sifre)values(@adi, @soyadi, @kullaniciAdi,@sifre)", parameters);

            FormKayıt formKayıt = new FormKayıt();
            formKayıt.Show();

            this.Hide();

        }
    }
}
