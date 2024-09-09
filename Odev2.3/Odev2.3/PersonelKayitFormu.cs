using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2._3
{
    public partial class PersonelKayitFormu : Form
    {
        public PersonelKayitFormu()
        {
            InitializeComponent();
        }       

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string cinsiyet = rb_kadin.Checked ? "Kadın" : rb_erkek.Checked ? "Erkek" : "Cinsiyet Seçilmedi";
            string medenihal = rb_evli.Checked ? "Evli" : "Bekar";
            string uyruk = cb_uyruk.SelectedItem != null ? cb_uyruk.SelectedItem.ToString() : "Uyruğu Seçilmedi";
            string cocuksayisi = cb_cocuksayisi.SelectedItem != null ? cb_cocuksayisi.SelectedItem.ToString() : "Çocuk Sayısı Seçilmedi";
            List<string> diller = new List<string>();
            if (chb_ingilizce.Checked) diller.Add("İngilizce");
            if (chb_fransizca.Checked) diller.Add("Fransızca");
            if (chb_almanca.Checked) diller.Add("Almanca");
            if (chb_italyanca.Checked) diller.Add("İtalyanca");
            if (chb_cince.Checked) diller.Add("Çince");
            if (chb_rusca.Checked) diller.Add("Rusça");

            string yabanciDiller = diller.Count > 0 ? string.Join(", ", diller) : "Yabancı Dil Seçilmedi";
            string egitimSeviyesi = cb_egitimseviyesi.SelectedItem != null ? cb_egitimseviyesi.SelectedItem.ToString() : "Eğitim Seviyesi Seçilmedi";
            string departman = cb_departman.SelectedItem != null ? cb_departman.SelectedItem.ToString() : "Departman Bilgisi Girilmedi";
            string calismasekli = cb_calismasekli.SelectedItem != null ? cb_calismasekli.SelectedItem.ToString() : "Çalışma Şekli Seçilmedi";
            string dogumTarihi = mc_dogumtarihi.SelectionStart.ToShortDateString();

            string personelBilgileri = "İsim: " + tb_isim.Text + "\n" +
                                       "Soyisim: " + tb_soyisim.Text + "\n" +
                                       "Kimlik: " + mtb_kimlik.Text + "\n" +
                                       "Baba Adı: " + tb_babaadi.Text + "\n" +
                                       "Doğum Tarihi: " + dogumTarihi + "\n" +
                                       "E-mail: " + tb_email.Text + "\n" +
                                       "Telefon No: " + mtb_telefonno.Text + "\n" +
                                       "Memleket: " + (cb_memleket.SelectedItem != null ? cb_memleket.SelectedItem.ToString() : "Memleket Seçilmedi") + "\n" +
                                       "Cinsiyet: " + cinsiyet + "\n" +
                                       "Medeni Hal: " + medenihal + "\n" +
                                       "Uyruğu: " + uyruk + "\n" +
                                       "Çocuk Sayısı: " + cocuksayisi + "\n" +
                                       "Adres: " + tb_adres.Text + "\n" +
                                       "Yabancı Diller: " + yabanciDiller + "\n" +
                                       "Eğitim Seviyesi: " + egitimSeviyesi + "\n" +
                                       "Departman: " + departman + "\n" +
                                       "İşe Başlama Tarihi: " + mtb_isebaslamatarihi.Text + "\n" +
                                       "Çalışma Şekli: " + calismasekli + "\n" +
                                       "Acil Durumda Aranacak Telefon No: " + mtb_acildurumno.Text + "\n" +
                                       "Hastalık(varsa): " + tb_hastalik.Text + "\n" +
                                       "IBAN: " + mtb_iban.Text + "\n" +
                                       "Personel Hakkında Notlar: " + tb_notlar.Text;

            string path = "C:\\Users\\serap\\OneDrive\\Personel Kayıtları";

            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                di.Create();
            }

            string dosyaAdi = $"{tb_isim.Text}_{tb_soyisim.Text}.txt";

            string dosyaYolu = path +"\\"+ dosyaAdi;

            File.WriteAllText(dosyaYolu, personelBilgileri);

            lbl_sonuc.Text = personelBilgileri;

        }

        private void btn_personellistele_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\serap\\OneDrive\\Personel Kayıtları";

            lb_personeller.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] dosyalar = di.GetFiles("*.txt");

            int index = 1;
            foreach (FileInfo dosya in dosyalar)
            {
                string dosyaAdi = Path.GetFileNameWithoutExtension(dosya.Name);
                lb_personeller.Items.Add($"{index}. {dosyaAdi}");
                index++;
            }
        }
    }
}
