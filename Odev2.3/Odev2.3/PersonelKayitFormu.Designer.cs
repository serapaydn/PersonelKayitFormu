namespace Odev2._3
{
    partial class PersonelKayitFormu
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
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.mtb_kimlik = new System.Windows.Forms.MaskedTextBox();
            this.lbl_kimlik = new System.Windows.Forms.Label();
            this.lbl_telefonno = new System.Windows.Forms.Label();
            this.mtb_telefonno = new System.Windows.Forms.MaskedTextBox();
            this.gb_medenihal = new System.Windows.Forms.GroupBox();
            this.rb_bekar = new System.Windows.Forms.RadioButton();
            this.rb_evli = new System.Windows.Forms.RadioButton();
            this.gb_cinsiyet = new System.Windows.Forms.GroupBox();
            this.rb_kadin = new System.Windows.Forms.RadioButton();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.tb_babaadi = new System.Windows.Forms.TextBox();
            this.lbl_babaadi = new System.Windows.Forms.Label();
            this.lbl_memleket = new System.Windows.Forms.Label();
            this.cb_memleket = new System.Windows.Forms.ComboBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.lbl_cocuksayisi = new System.Windows.Forms.Label();
            this.cb_cocuksayisi = new System.Windows.Forms.ComboBox();
            this.lbl_uyruk = new System.Windows.Forms.Label();
            this.cb_uyruk = new System.Windows.Forms.ComboBox();
            this.cb_egitimseviyesi = new System.Windows.Forms.ComboBox();
            this.lbl_egitimseviyesi = new System.Windows.Forms.Label();
            this.lbl_departman = new System.Windows.Forms.Label();
            this.cb_departman = new System.Windows.Forms.ComboBox();
            this.lbl_dogumtarihi = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_isebaslama = new System.Windows.Forms.Label();
            this.mtb_isebaslamatarihi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_calismasekli = new System.Windows.Forms.Label();
            this.cb_calismasekli = new System.Windows.Forms.ComboBox();
            this.lbl_acildurumno = new System.Windows.Forms.Label();
            this.mtb_acildurumno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_sağlikdurumu = new System.Windows.Forms.Label();
            this.tb_hastalik = new System.Windows.Forms.TextBox();
            this.lbl_iban = new System.Windows.Forms.Label();
            this.mtb_iban = new System.Windows.Forms.MaskedTextBox();
            this.lbl_notlar = new System.Windows.Forms.Label();
            this.tb_notlar = new System.Windows.Forms.TextBox();
            this.chb_ingilizce = new System.Windows.Forms.CheckBox();
            this.chb_almanca = new System.Windows.Forms.CheckBox();
            this.chb_fransizca = new System.Windows.Forms.CheckBox();
            this.gb_yabancidil = new System.Windows.Forms.GroupBox();
            this.chb_rusca = new System.Windows.Forms.CheckBox();
            this.chb_cince = new System.Windows.Forms.CheckBox();
            this.chb_italyanca = new System.Windows.Forms.CheckBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.mc_dogumtarihi = new System.Windows.Forms.MonthCalendar();
            this.lb_personeller = new System.Windows.Forms.ListBox();
            this.btn_personellistele = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.lbl_personelbilgi = new System.Windows.Forms.Label();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.gb_medenihal.SuspendLayout();
            this.gb_cinsiyet.SuspendLayout();
            this.gb_yabancidil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_baslik.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_baslik.Location = new System.Drawing.Point(390, -2);
            this.lbl_baslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(264, 36);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "Personel Kayıt Formu";
            this.lbl_baslik.UseWaitCursor = true;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.Location = new System.Drawing.Point(13, 46);
            this.lbl_isim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(43, 21);
            this.lbl_isim.TabIndex = 1;
            this.lbl_isim.Text = "İsim:";
            this.lbl_isim.UseWaitCursor = true;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(17, 71);
            this.tb_isim.Margin = new System.Windows.Forms.Padding(4);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(182, 28);
            this.tb_isim.TabIndex = 1;
            this.tb_isim.UseWaitCursor = true;
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(221, 71);
            this.tb_soyisim.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(182, 28);
            this.tb_soyisim.TabIndex = 2;
            this.tb_soyisim.UseWaitCursor = true;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyisim.Location = new System.Drawing.Point(221, 46);
            this.lbl_soyisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(68, 21);
            this.lbl_soyisim.TabIndex = 3;
            this.lbl_soyisim.Text = "Soyisim:";
            this.lbl_soyisim.UseWaitCursor = true;
            // 
            // mtb_kimlik
            // 
            this.mtb_kimlik.Location = new System.Drawing.Point(426, 71);
            this.mtb_kimlik.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_kimlik.Mask = "00000000000";
            this.mtb_kimlik.Name = "mtb_kimlik";
            this.mtb_kimlik.Size = new System.Drawing.Size(182, 28);
            this.mtb_kimlik.TabIndex = 3;
            this.mtb_kimlik.UseWaitCursor = true;
            // 
            // lbl_kimlik
            // 
            this.lbl_kimlik.AutoSize = true;
            this.lbl_kimlik.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kimlik.Location = new System.Drawing.Point(422, 46);
            this.lbl_kimlik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kimlik.Name = "lbl_kimlik";
            this.lbl_kimlik.Size = new System.Drawing.Size(156, 21);
            this.lbl_kimlik.TabIndex = 6;
            this.lbl_kimlik.Text = "T.C. Kimlik Numarası:";
            this.lbl_kimlik.UseWaitCursor = true;
            // 
            // lbl_telefonno
            // 
            this.lbl_telefonno.AutoSize = true;
            this.lbl_telefonno.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefonno.Location = new System.Drawing.Point(13, 156);
            this.lbl_telefonno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefonno.Name = "lbl_telefonno";
            this.lbl_telefonno.Size = new System.Drawing.Size(137, 21);
            this.lbl_telefonno.TabIndex = 7;
            this.lbl_telefonno.Text = "Telefon Numarası:";
            this.lbl_telefonno.UseWaitCursor = true;
            // 
            // mtb_telefonno
            // 
            this.mtb_telefonno.Location = new System.Drawing.Point(17, 181);
            this.mtb_telefonno.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_telefonno.Mask = "(999) 000-0000";
            this.mtb_telefonno.Name = "mtb_telefonno";
            this.mtb_telefonno.Size = new System.Drawing.Size(182, 28);
            this.mtb_telefonno.TabIndex = 7;
            this.mtb_telefonno.UseWaitCursor = true;
            // 
            // gb_medenihal
            // 
            this.gb_medenihal.Controls.Add(this.rb_bekar);
            this.gb_medenihal.Controls.Add(this.rb_evli);
            this.gb_medenihal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_medenihal.Location = new System.Drawing.Point(221, 226);
            this.gb_medenihal.Name = "gb_medenihal";
            this.gb_medenihal.Size = new System.Drawing.Size(182, 63);
            this.gb_medenihal.TabIndex = 10;
            this.gb_medenihal.TabStop = false;
            this.gb_medenihal.Text = "Medeni Hal";
            this.gb_medenihal.UseWaitCursor = true;
            // 
            // rb_bekar
            // 
            this.rb_bekar.AutoSize = true;
            this.rb_bekar.Location = new System.Drawing.Point(93, 27);
            this.rb_bekar.Name = "rb_bekar";
            this.rb_bekar.Size = new System.Drawing.Size(70, 25);
            this.rb_bekar.TabIndex = 1;
            this.rb_bekar.TabStop = true;
            this.rb_bekar.Text = "Bekar";
            this.rb_bekar.UseVisualStyleBackColor = true;
            this.rb_bekar.UseWaitCursor = true;
            // 
            // rb_evli
            // 
            this.rb_evli.AutoSize = true;
            this.rb_evli.Location = new System.Drawing.Point(10, 27);
            this.rb_evli.Name = "rb_evli";
            this.rb_evli.Size = new System.Drawing.Size(55, 25);
            this.rb_evli.TabIndex = 0;
            this.rb_evli.TabStop = true;
            this.rb_evli.Text = "Evli";
            this.rb_evli.UseVisualStyleBackColor = true;
            this.rb_evli.UseWaitCursor = true;
            // 
            // gb_cinsiyet
            // 
            this.gb_cinsiyet.Controls.Add(this.rb_kadin);
            this.gb_cinsiyet.Controls.Add(this.rb_erkek);
            this.gb_cinsiyet.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_cinsiyet.Location = new System.Drawing.Point(17, 226);
            this.gb_cinsiyet.Name = "gb_cinsiyet";
            this.gb_cinsiyet.Size = new System.Drawing.Size(182, 63);
            this.gb_cinsiyet.TabIndex = 9;
            this.gb_cinsiyet.TabStop = false;
            this.gb_cinsiyet.Text = "Cinsiyet";
            this.gb_cinsiyet.UseWaitCursor = true;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.Location = new System.Drawing.Point(86, 27);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(71, 25);
            this.rb_kadin.TabIndex = 1;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın";
            this.rb_kadin.UseVisualStyleBackColor = true;
            this.rb_kadin.UseWaitCursor = true;
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Location = new System.Drawing.Point(10, 27);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(68, 25);
            this.rb_erkek.TabIndex = 0;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            this.rb_erkek.UseWaitCursor = true;
            // 
            // tb_babaadi
            // 
            this.tb_babaadi.Location = new System.Drawing.Point(17, 124);
            this.tb_babaadi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_babaadi.Name = "tb_babaadi";
            this.tb_babaadi.Size = new System.Drawing.Size(182, 28);
            this.tb_babaadi.TabIndex = 4;
            this.tb_babaadi.UseWaitCursor = true;
            // 
            // lbl_babaadi
            // 
            this.lbl_babaadi.AutoSize = true;
            this.lbl_babaadi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_babaadi.Location = new System.Drawing.Point(13, 103);
            this.lbl_babaadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_babaadi.Name = "lbl_babaadi";
            this.lbl_babaadi.Size = new System.Drawing.Size(78, 21);
            this.lbl_babaadi.TabIndex = 11;
            this.lbl_babaadi.Text = "Baba Adı:";
            this.lbl_babaadi.UseWaitCursor = true;
            // 
            // lbl_memleket
            // 
            this.lbl_memleket.AutoSize = true;
            this.lbl_memleket.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_memleket.Location = new System.Drawing.Point(221, 162);
            this.lbl_memleket.Name = "lbl_memleket";
            this.lbl_memleket.Size = new System.Drawing.Size(84, 21);
            this.lbl_memleket.TabIndex = 13;
            this.lbl_memleket.Text = "Memleket:";
            this.lbl_memleket.UseWaitCursor = true;
            // 
            // cb_memleket
            // 
            this.cb_memleket.FormattingEnabled = true;
            this.cb_memleket.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa ",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.cb_memleket.Location = new System.Drawing.Point(221, 180);
            this.cb_memleket.Name = "cb_memleket";
            this.cb_memleket.Size = new System.Drawing.Size(182, 29);
            this.cb_memleket.TabIndex = 8;
            this.cb_memleket.UseWaitCursor = true;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(13, 358);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(55, 21);
            this.lbl_adres.TabIndex = 15;
            this.lbl_adres.Text = "Adres:";
            this.lbl_adres.UseWaitCursor = true;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(17, 385);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_adres.Size = new System.Drawing.Size(182, 70);
            this.tb_adres.TabIndex = 13;
            this.tb_adres.UseWaitCursor = true;
            // 
            // lbl_cocuksayisi
            // 
            this.lbl_cocuksayisi.AutoSize = true;
            this.lbl_cocuksayisi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cocuksayisi.Location = new System.Drawing.Point(221, 301);
            this.lbl_cocuksayisi.Name = "lbl_cocuksayisi";
            this.lbl_cocuksayisi.Size = new System.Drawing.Size(101, 21);
            this.lbl_cocuksayisi.TabIndex = 17;
            this.lbl_cocuksayisi.Text = "Çocuk Sayısı:";
            this.lbl_cocuksayisi.UseWaitCursor = true;
            // 
            // cb_cocuksayisi
            // 
            this.cb_cocuksayisi.FormattingEnabled = true;
            this.cb_cocuksayisi.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cb_cocuksayisi.Location = new System.Drawing.Point(221, 326);
            this.cb_cocuksayisi.Name = "cb_cocuksayisi";
            this.cb_cocuksayisi.Size = new System.Drawing.Size(182, 29);
            this.cb_cocuksayisi.TabIndex = 12;
            this.cb_cocuksayisi.UseWaitCursor = true;
            // 
            // lbl_uyruk
            // 
            this.lbl_uyruk.AutoSize = true;
            this.lbl_uyruk.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyruk.Location = new System.Drawing.Point(13, 301);
            this.lbl_uyruk.Name = "lbl_uyruk";
            this.lbl_uyruk.Size = new System.Drawing.Size(67, 21);
            this.lbl_uyruk.TabIndex = 19;
            this.lbl_uyruk.Text = "Uyruğu:";
            this.lbl_uyruk.UseWaitCursor = true;
            // 
            // cb_uyruk
            // 
            this.cb_uyruk.FormattingEnabled = true;
            this.cb_uyruk.Items.AddRange(new object[] {
            "Türkiye- Türk",
            "ABD - Amerikalı",
            "Almanya - Alman",
            "Arjantin - Arjantinli",
            "Avustralya - Avustralyalı",
            "Brezilya - Brezilyalı",
            "Çin- Çinli",
            "Fransa - Fransız",
            "Hindistan - Hindistanlı",
            "İngiltere- İngiliz",
            "İtalya - İtalyan",
            "Japonya- Japon",
            "Kanada - Kanadalı",
            "Meksika - Meksikalı",
            "Rusya- Rus"});
            this.cb_uyruk.Location = new System.Drawing.Point(17, 326);
            this.cb_uyruk.Name = "cb_uyruk";
            this.cb_uyruk.Size = new System.Drawing.Size(182, 29);
            this.cb_uyruk.TabIndex = 11;
            this.cb_uyruk.UseWaitCursor = true;
            // 
            // cb_egitimseviyesi
            // 
            this.cb_egitimseviyesi.FormattingEnabled = true;
            this.cb_egitimseviyesi.Items.AddRange(new object[] {
            "Okuma Yazma Bilmiyor",
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Önlisans",
            "Lisans",
            "Yüksek Lisans",
            "Doktora"});
            this.cb_egitimseviyesi.Location = new System.Drawing.Point(17, 488);
            this.cb_egitimseviyesi.Name = "cb_egitimseviyesi";
            this.cb_egitimseviyesi.Size = new System.Drawing.Size(182, 29);
            this.cb_egitimseviyesi.TabIndex = 15;
            this.cb_egitimseviyesi.UseWaitCursor = true;
            // 
            // lbl_egitimseviyesi
            // 
            this.lbl_egitimseviyesi.AutoSize = true;
            this.lbl_egitimseviyesi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_egitimseviyesi.Location = new System.Drawing.Point(13, 464);
            this.lbl_egitimseviyesi.Name = "lbl_egitimseviyesi";
            this.lbl_egitimseviyesi.Size = new System.Drawing.Size(117, 21);
            this.lbl_egitimseviyesi.TabIndex = 23;
            this.lbl_egitimseviyesi.Text = "Eğitim Seviyesi:";
            this.lbl_egitimseviyesi.UseWaitCursor = true;
            // 
            // lbl_departman
            // 
            this.lbl_departman.AutoSize = true;
            this.lbl_departman.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_departman.Location = new System.Drawing.Point(221, 464);
            this.lbl_departman.Name = "lbl_departman";
            this.lbl_departman.Size = new System.Drawing.Size(94, 21);
            this.lbl_departman.TabIndex = 25;
            this.lbl_departman.Text = "Departman:";
            this.lbl_departman.UseWaitCursor = true;
            // 
            // cb_departman
            // 
            this.cb_departman.FormattingEnabled = true;
            this.cb_departman.Items.AddRange(new object[] {
            "İnsan Kaynakları (HR)",
            "Finans ve Muhasebe",
            "Pazarlama",
            "Satış",
            "Üretim",
            "Ar-Ge (Araştırma ve Geliştirme)",
            "Müşteri Hizmetleri",
            "Bilgi Teknolojileri (IT)",
            "Lojistik ve Depo",
            "Hukuk",
            "Strateji ve Planlama",
            "İletişim ve Halkla İlişkiler"});
            this.cb_departman.Location = new System.Drawing.Point(221, 488);
            this.cb_departman.Name = "cb_departman";
            this.cb_departman.Size = new System.Drawing.Size(182, 29);
            this.cb_departman.TabIndex = 16;
            this.cb_departman.UseWaitCursor = true;
            // 
            // lbl_dogumtarihi
            // 
            this.lbl_dogumtarihi.AutoSize = true;
            this.lbl_dogumtarihi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dogumtarihi.Location = new System.Drawing.Point(422, 103);
            this.lbl_dogumtarihi.Name = "lbl_dogumtarihi";
            this.lbl_dogumtarihi.Size = new System.Drawing.Size(108, 21);
            this.lbl_dogumtarihi.TabIndex = 27;
            this.lbl_dogumtarihi.Text = "Doğum Tarihi:";
            this.lbl_dogumtarihi.UseWaitCursor = true;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(221, 103);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 21);
            this.lbl_email.TabIndex = 29;
            this.lbl_email.Text = "E-mail:";
            this.lbl_email.UseWaitCursor = true;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(221, 131);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(182, 28);
            this.tb_email.TabIndex = 5;
            this.tb_email.UseWaitCursor = true;
            // 
            // lbl_isebaslama
            // 
            this.lbl_isebaslama.AutoSize = true;
            this.lbl_isebaslama.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isebaslama.Location = new System.Drawing.Point(13, 529);
            this.lbl_isebaslama.Name = "lbl_isebaslama";
            this.lbl_isebaslama.Size = new System.Drawing.Size(141, 21);
            this.lbl_isebaslama.TabIndex = 31;
            this.lbl_isebaslama.Text = "İşe Başlama Tarihi:";
            this.lbl_isebaslama.UseWaitCursor = true;
            // 
            // mtb_isebaslamatarihi
            // 
            this.mtb_isebaslamatarihi.Location = new System.Drawing.Point(17, 558);
            this.mtb_isebaslamatarihi.Mask = "00/00/0000";
            this.mtb_isebaslamatarihi.Name = "mtb_isebaslamatarihi";
            this.mtb_isebaslamatarihi.Size = new System.Drawing.Size(182, 28);
            this.mtb_isebaslamatarihi.TabIndex = 17;
            this.mtb_isebaslamatarihi.UseWaitCursor = true;
            this.mtb_isebaslamatarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_calismasekli
            // 
            this.lbl_calismasekli.AutoSize = true;
            this.lbl_calismasekli.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_calismasekli.Location = new System.Drawing.Point(221, 534);
            this.lbl_calismasekli.Name = "lbl_calismasekli";
            this.lbl_calismasekli.Size = new System.Drawing.Size(106, 21);
            this.lbl_calismasekli.TabIndex = 33;
            this.lbl_calismasekli.Text = "Çalışma Şekli:";
            this.lbl_calismasekli.UseWaitCursor = true;
            // 
            // cb_calismasekli
            // 
            this.cb_calismasekli.FormattingEnabled = true;
            this.cb_calismasekli.Items.AddRange(new object[] {
            "Tam Zamanlı",
            "Yarı Zamanlı",
            "Geçici",
            "PartTime"});
            this.cb_calismasekli.Location = new System.Drawing.Point(221, 558);
            this.cb_calismasekli.Name = "cb_calismasekli";
            this.cb_calismasekli.Size = new System.Drawing.Size(182, 29);
            this.cb_calismasekli.TabIndex = 18;
            this.cb_calismasekli.UseWaitCursor = true;
            // 
            // lbl_acildurumno
            // 
            this.lbl_acildurumno.AutoSize = true;
            this.lbl_acildurumno.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_acildurumno.Location = new System.Drawing.Point(13, 602);
            this.lbl_acildurumno.Name = "lbl_acildurumno";
            this.lbl_acildurumno.Size = new System.Drawing.Size(169, 21);
            this.lbl_acildurumno.TabIndex = 35;
            this.lbl_acildurumno.Text = "Acil Durum Telefon No:";
            this.lbl_acildurumno.UseWaitCursor = true;
            // 
            // mtb_acildurumno
            // 
            this.mtb_acildurumno.Location = new System.Drawing.Point(17, 627);
            this.mtb_acildurumno.Mask = "(999) 000-0000";
            this.mtb_acildurumno.Name = "mtb_acildurumno";
            this.mtb_acildurumno.Size = new System.Drawing.Size(182, 28);
            this.mtb_acildurumno.TabIndex = 21;
            this.mtb_acildurumno.UseWaitCursor = true;
            // 
            // lbl_sağlikdurumu
            // 
            this.lbl_sağlikdurumu.AutoSize = true;
            this.lbl_sağlikdurumu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sağlikdurumu.Location = new System.Drawing.Point(221, 602);
            this.lbl_sağlikdurumu.Name = "lbl_sağlikdurumu";
            this.lbl_sağlikdurumu.Size = new System.Drawing.Size(122, 21);
            this.lbl_sağlikdurumu.TabIndex = 37;
            this.lbl_sağlikdurumu.Text = "Hastalık(varsa):";
            this.lbl_sağlikdurumu.UseWaitCursor = true;
            // 
            // tb_hastalik
            // 
            this.tb_hastalik.Location = new System.Drawing.Point(221, 626);
            this.tb_hastalik.Name = "tb_hastalik";
            this.tb_hastalik.Size = new System.Drawing.Size(182, 28);
            this.tb_hastalik.TabIndex = 22;
            this.tb_hastalik.UseWaitCursor = true;
            // 
            // lbl_iban
            // 
            this.lbl_iban.AutoSize = true;
            this.lbl_iban.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_iban.Location = new System.Drawing.Point(13, 662);
            this.lbl_iban.Name = "lbl_iban";
            this.lbl_iban.Size = new System.Drawing.Size(49, 21);
            this.lbl_iban.TabIndex = 39;
            this.lbl_iban.Text = "IBAN:";
            this.lbl_iban.UseWaitCursor = true;
            // 
            // mtb_iban
            // 
            this.mtb_iban.Location = new System.Drawing.Point(17, 687);
            this.mtb_iban.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_iban.Mask = "TR00-0000-0000-0000-0000-00";
            this.mtb_iban.Name = "mtb_iban";
            this.mtb_iban.Size = new System.Drawing.Size(182, 28);
            this.mtb_iban.TabIndex = 23;
            this.mtb_iban.UseWaitCursor = true;
            // 
            // lbl_notlar
            // 
            this.lbl_notlar.AutoSize = true;
            this.lbl_notlar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_notlar.Location = new System.Drawing.Point(221, 662);
            this.lbl_notlar.Name = "lbl_notlar";
            this.lbl_notlar.Size = new System.Drawing.Size(195, 21);
            this.lbl_notlar.TabIndex = 42;
            this.lbl_notlar.Text = "Personel Hakkında Notlar:";
            this.lbl_notlar.UseWaitCursor = true;
            // 
            // tb_notlar
            // 
            this.tb_notlar.Location = new System.Drawing.Point(221, 687);
            this.tb_notlar.Multiline = true;
            this.tb_notlar.Name = "tb_notlar";
            this.tb_notlar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_notlar.Size = new System.Drawing.Size(182, 28);
            this.tb_notlar.TabIndex = 24;
            this.tb_notlar.UseWaitCursor = true;
            // 
            // chb_ingilizce
            // 
            this.chb_ingilizce.AutoSize = true;
            this.chb_ingilizce.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_ingilizce.Location = new System.Drawing.Point(8, 27);
            this.chb_ingilizce.Name = "chb_ingilizce";
            this.chb_ingilizce.Size = new System.Drawing.Size(81, 22);
            this.chb_ingilizce.TabIndex = 43;
            this.chb_ingilizce.Text = "İngilizce";
            this.chb_ingilizce.UseVisualStyleBackColor = true;
            this.chb_ingilizce.UseWaitCursor = true;
            // 
            // chb_almanca
            // 
            this.chb_almanca.AutoSize = true;
            this.chb_almanca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_almanca.Location = new System.Drawing.Point(8, 55);
            this.chb_almanca.Name = "chb_almanca";
            this.chb_almanca.Size = new System.Drawing.Size(83, 22);
            this.chb_almanca.TabIndex = 44;
            this.chb_almanca.Text = "Almanca";
            this.chb_almanca.UseVisualStyleBackColor = true;
            this.chb_almanca.UseWaitCursor = true;
            // 
            // chb_fransizca
            // 
            this.chb_fransizca.AutoSize = true;
            this.chb_fransizca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_fransizca.Location = new System.Drawing.Point(93, 27);
            this.chb_fransizca.Name = "chb_fransizca";
            this.chb_fransizca.Size = new System.Drawing.Size(91, 22);
            this.chb_fransizca.TabIndex = 45;
            this.chb_fransizca.Text = "Franzsızca";
            this.chb_fransizca.UseVisualStyleBackColor = true;
            this.chb_fransizca.UseWaitCursor = true;
            // 
            // gb_yabancidil
            // 
            this.gb_yabancidil.Controls.Add(this.chb_rusca);
            this.gb_yabancidil.Controls.Add(this.chb_cince);
            this.gb_yabancidil.Controls.Add(this.chb_italyanca);
            this.gb_yabancidil.Controls.Add(this.chb_ingilizce);
            this.gb_yabancidil.Controls.Add(this.chb_fransizca);
            this.gb_yabancidil.Controls.Add(this.chb_almanca);
            this.gb_yabancidil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_yabancidil.Location = new System.Drawing.Point(221, 371);
            this.gb_yabancidil.Name = "gb_yabancidil";
            this.gb_yabancidil.Size = new System.Drawing.Size(276, 90);
            this.gb_yabancidil.TabIndex = 46;
            this.gb_yabancidil.TabStop = false;
            this.gb_yabancidil.Text = "Yabancı Dil:";
            this.gb_yabancidil.UseWaitCursor = true;
            // 
            // chb_rusca
            // 
            this.chb_rusca.AutoSize = true;
            this.chb_rusca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_rusca.Location = new System.Drawing.Point(93, 55);
            this.chb_rusca.Name = "chb_rusca";
            this.chb_rusca.Size = new System.Drawing.Size(65, 22);
            this.chb_rusca.TabIndex = 48;
            this.chb_rusca.Text = "Rusça";
            this.chb_rusca.UseVisualStyleBackColor = true;
            this.chb_rusca.UseWaitCursor = true;
            // 
            // chb_cince
            // 
            this.chb_cince.AutoSize = true;
            this.chb_cince.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_cince.Location = new System.Drawing.Point(190, 55);
            this.chb_cince.Name = "chb_cince";
            this.chb_cince.Size = new System.Drawing.Size(64, 22);
            this.chb_cince.TabIndex = 47;
            this.chb_cince.Text = "Çince";
            this.chb_cince.UseVisualStyleBackColor = true;
            this.chb_cince.UseWaitCursor = true;
            // 
            // chb_italyanca
            // 
            this.chb_italyanca.AutoSize = true;
            this.chb_italyanca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_italyanca.Location = new System.Drawing.Point(190, 27);
            this.chb_italyanca.Name = "chb_italyanca";
            this.chb_italyanca.Size = new System.Drawing.Size(85, 22);
            this.chb_italyanca.TabIndex = 46;
            this.chb_italyanca.Text = "İtalyanca";
            this.chb_italyanca.UseVisualStyleBackColor = true;
            this.chb_italyanca.UseWaitCursor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_kaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_kaydet.Location = new System.Drawing.Point(422, 682);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(129, 33);
            this.btn_kaydet.TabIndex = 48;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.UseWaitCursor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // mc_dogumtarihi
            // 
            this.mc_dogumtarihi.Location = new System.Drawing.Point(426, 124);
            this.mc_dogumtarihi.Name = "mc_dogumtarihi";
            this.mc_dogumtarihi.TabIndex = 6;
            this.mc_dogumtarihi.UseWaitCursor = true;
            // 
            // lb_personeller
            // 
            this.lb_personeller.FormattingEnabled = true;
            this.lb_personeller.ItemHeight = 21;
            this.lb_personeller.Location = new System.Drawing.Point(700, 57);
            this.lb_personeller.Name = "lb_personeller";
            this.lb_personeller.Size = new System.Drawing.Size(199, 613);
            this.lb_personeller.TabIndex = 50;
            this.lb_personeller.UseWaitCursor = true;
            // 
            // btn_personellistele
            // 
            this.btn_personellistele.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_personellistele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personellistele.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_personellistele.Location = new System.Drawing.Point(700, 682);
            this.btn_personellistele.Name = "btn_personellistele";
            this.btn_personellistele.Size = new System.Drawing.Size(199, 33);
            this.btn_personellistele.TabIndex = 51;
            this.btn_personellistele.Text = "Personel Listele";
            this.btn_personellistele.UseVisualStyleBackColor = false;
            this.btn_personellistele.UseWaitCursor = true;
            this.btn_personellistele.Click += new System.EventHandler(this.btn_personellistele_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(915, 103);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(0, 21);
            this.lbl_sonuc.TabIndex = 49;
            this.lbl_sonuc.UseWaitCursor = true;
            // 
            // lbl_personelbilgi
            // 
            this.lbl_personelbilgi.AutoSize = true;
            this.lbl_personelbilgi.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personelbilgi.Location = new System.Drawing.Point(958, 57);
            this.lbl_personelbilgi.Name = "lbl_personelbilgi";
            this.lbl_personelbilgi.Size = new System.Drawing.Size(161, 27);
            this.lbl_personelbilgi.TabIndex = 47;
            this.lbl_personelbilgi.Text = "Personel Bilgileri";
            this.lbl_personelbilgi.UseWaitCursor = true;
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Location = new System.Drawing.Point(742, 33);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(88, 21);
            this.lbl_personel.TabIndex = 52;
            this.lbl_personel.Text = "Personeller";
            // 
            // PersonelKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1209, 729);
            this.Controls.Add(this.lbl_personel);
            this.Controls.Add(this.btn_personellistele);
            this.Controls.Add(this.lb_personeller);
            this.Controls.Add(this.mc_dogumtarihi);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.lbl_personelbilgi);
            this.Controls.Add(this.gb_yabancidil);
            this.Controls.Add(this.tb_notlar);
            this.Controls.Add(this.lbl_notlar);
            this.Controls.Add(this.mtb_iban);
            this.Controls.Add(this.lbl_iban);
            this.Controls.Add(this.tb_hastalik);
            this.Controls.Add(this.lbl_sağlikdurumu);
            this.Controls.Add(this.mtb_acildurumno);
            this.Controls.Add(this.lbl_acildurumno);
            this.Controls.Add(this.cb_calismasekli);
            this.Controls.Add(this.lbl_calismasekli);
            this.Controls.Add(this.mtb_isebaslamatarihi);
            this.Controls.Add(this.lbl_isebaslama);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_dogumtarihi);
            this.Controls.Add(this.cb_departman);
            this.Controls.Add(this.lbl_departman);
            this.Controls.Add(this.lbl_egitimseviyesi);
            this.Controls.Add(this.cb_egitimseviyesi);
            this.Controls.Add(this.cb_uyruk);
            this.Controls.Add(this.lbl_uyruk);
            this.Controls.Add(this.cb_cocuksayisi);
            this.Controls.Add(this.lbl_cocuksayisi);
            this.Controls.Add(this.tb_adres);
            this.Controls.Add(this.lbl_adres);
            this.Controls.Add(this.cb_memleket);
            this.Controls.Add(this.lbl_memleket);
            this.Controls.Add(this.tb_babaadi);
            this.Controls.Add(this.lbl_babaadi);
            this.Controls.Add(this.gb_cinsiyet);
            this.Controls.Add(this.gb_medenihal);
            this.Controls.Add(this.mtb_telefonno);
            this.Controls.Add(this.lbl_telefonno);
            this.Controls.Add(this.lbl_kimlik);
            this.Controls.Add(this.mtb_kimlik);
            this.Controls.Add(this.tb_soyisim);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.tb_isim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.lbl_baslik);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelKayitFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelKayitFormu";
            this.UseWaitCursor = true;
            this.gb_medenihal.ResumeLayout(false);
            this.gb_medenihal.PerformLayout();
            this.gb_cinsiyet.ResumeLayout(false);
            this.gb_cinsiyet.PerformLayout();
            this.gb_yabancidil.ResumeLayout(false);
            this.gb_yabancidil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.MaskedTextBox mtb_kimlik;
        private System.Windows.Forms.Label lbl_kimlik;
        private System.Windows.Forms.Label lbl_telefonno;
        private System.Windows.Forms.MaskedTextBox mtb_telefonno;
        private System.Windows.Forms.GroupBox gb_medenihal;
        private System.Windows.Forms.RadioButton rb_bekar;
        private System.Windows.Forms.RadioButton rb_evli;
        private System.Windows.Forms.GroupBox gb_cinsiyet;
        private System.Windows.Forms.RadioButton rb_kadin;
        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.TextBox tb_babaadi;
        private System.Windows.Forms.Label lbl_babaadi;
        private System.Windows.Forms.Label lbl_memleket;
        private System.Windows.Forms.ComboBox cb_memleket;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.Label lbl_cocuksayisi;
        private System.Windows.Forms.ComboBox cb_cocuksayisi;
        private System.Windows.Forms.Label lbl_uyruk;
        private System.Windows.Forms.ComboBox cb_uyruk;
        private System.Windows.Forms.ComboBox cb_egitimseviyesi;
        private System.Windows.Forms.Label lbl_egitimseviyesi;
        private System.Windows.Forms.Label lbl_departman;
        private System.Windows.Forms.ComboBox cb_departman;
        private System.Windows.Forms.Label lbl_dogumtarihi;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_isebaslama;
        private System.Windows.Forms.MaskedTextBox mtb_isebaslamatarihi;
        private System.Windows.Forms.Label lbl_calismasekli;
        private System.Windows.Forms.ComboBox cb_calismasekli;
        private System.Windows.Forms.Label lbl_acildurumno;
        private System.Windows.Forms.MaskedTextBox mtb_acildurumno;
        private System.Windows.Forms.Label lbl_sağlikdurumu;
        private System.Windows.Forms.TextBox tb_hastalik;
        private System.Windows.Forms.Label lbl_iban;
        private System.Windows.Forms.MaskedTextBox mtb_iban;
        private System.Windows.Forms.Label lbl_notlar;
        private System.Windows.Forms.TextBox tb_notlar;
        private System.Windows.Forms.CheckBox chb_ingilizce;
        private System.Windows.Forms.CheckBox chb_almanca;
        private System.Windows.Forms.CheckBox chb_fransizca;
        private System.Windows.Forms.GroupBox gb_yabancidil;
        private System.Windows.Forms.CheckBox chb_rusca;
        private System.Windows.Forms.CheckBox chb_cince;
        private System.Windows.Forms.CheckBox chb_italyanca;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.MonthCalendar mc_dogumtarihi;
        private System.Windows.Forms.ListBox lb_personeller;
        private System.Windows.Forms.Button btn_personellistele;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label lbl_personelbilgi;
        private System.Windows.Forms.Label lbl_personel;
    }
}