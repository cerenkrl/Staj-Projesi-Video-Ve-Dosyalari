using Kutuphane_Otomasyon_Sistemi.Modeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKOS.Model;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        void dataGridViewLoad()
        {
            dgvEmanetler.DataSource = IDataBase.DataToDataTable("select kayitNo as [Kayıt No], kitapAdi as [Kitap Adı], yazarAdi as [Yazar Adı], yayinevi as [Yayınevi], basimYili as [Basım Yılı], sayfaSayisi as [Sayfa Sayısı], tur as [Tür] from kitaplar where aktif = 1 and durum = 0");
            dgvMevcutKitaplar.DataSource = IDataBase.DataToDataTable("select kayitNo as [Kayıt No], kitapAdi as [Kitap Adı], yazarAdi as [Yazar Adı], yayinevi as [Yayınevi], basimYili as [Basım Yılı], sayfaSayisi as [Sayfa Sayısı], tur as [Tür] from kitaplar where aktif = 1 and durum = 1");
            dgvOkuyucular.DataSource = IDataBase.DataToDataTable("select adi as [Adı], soyadi as [Soyadı], cinsiyeti as [Cinsiyeti], tc as [T.C. No], cepTel as [Cep Telefonu], adres as [Adres]  from okuyucular where aktif = 1");
        }
        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            FormKitapEkle formKitapEkle = new FormKitapEkle();
            formKitapEkle.Show();
        }

        private void buttonOkuyucuEkle_Click(object sender, EventArgs e)
        {
            FormOkuyucuEkle formOkuyucuEkle = new FormOkuyucuEkle();
            formOkuyucuEkle.Show();
        }

        private void buttonAyarlar_Click(object sender, EventArgs e)
        {
            FormDuzenle formDuzenle = new FormDuzenle();
            formDuzenle.Show();
        }

        private void buttonEmanetIslem_Click(object sender, EventArgs e)
        {
            FormEmanet formEmanet = new FormEmanet();
            formEmanet.Show();
        }

        private void buttonIstatistik_Click(object sender, EventArgs e)
        {
            FormIstatistik formIstatistik = new FormIstatistik();
            formIstatistik.Show();
        }

        private void FormAnasayfa_Activated(object sender, EventArgs e)
        {
            dataGridViewLoad();
        }

        private void buttonCIKIS_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
