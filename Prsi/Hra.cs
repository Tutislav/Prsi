using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Prsi
{
    public partial class Hra : Form
    {
        public string[] hodnoty = { "eso", "kral", "svrsek", "spodek", "10", "9", "8", "7" };
        public string[] barvy = { "zaludy", "srdce", "listy", "kule" };
        public string[] barvy2 = { "krize", "srdce2", "piky", "kary" };
        public string praveHraje = "hrac";
        public int pocet7 = 0;
        public int pocetKaretVRuce1;
        private Point lokaceKliknuti = Point.Empty;
        public int pocetKaretkLiznuti;
        public byte obtiznost = Properties.Settings.Default.obtiznost;
        public byte vzhledKaret = Properties.Settings.Default.vzhledKaret;
        public bool oknoMaximalizovano = Properties.Settings.Default.oknoMaximalizovano;
        public bool zvukZapnuty = Properties.Settings.Default.zvukZapnuty;
        public bool konecHry = false;
        public int sazka = 0;
        Souper souper;
        private int sirkaOkna;
        private int sirkaOkna2;
        private int zmenenaBarvaY = 234;
        private int zmenenaBarvaY2 = 373;
        private FormWindowState posledniStavOkna;
        public SoundPlayer zvuk1, zvuk2, zvuk3;

        public Hra()
        {
            InitializeComponent();
            Icon = Properties.Resources.prsi_ikona;
        }

        private void Hra_Load(object sender, EventArgs e)
        {
            comboBoxObtiznost.SelectedIndex = obtiznost - 1;
            comboBoxVzhledKaret.SelectedIndex = vzhledKaret - 1;
            labelPenizeHrac.Text = Properties.Settings.Default.penizeHrac + " Kč";
            labelPenizeSouper.Text = Properties.Settings.Default.penizeSouper + " Kč";
            buttonZvuk.Checked = zvukZapnuty;
            if (zvukZapnuty) buttonZvuk.ToolTipText = "Zvuky jsou zapnuté";
            else buttonZvuk.ToolTipText = "Zvuky jsou vypnuté";
            zvuk1 = new SoundPlayer(Properties.Resources.karta1);
            zvuk2 = new SoundPlayer(Properties.Resources.karta2);
            zvuk3 = new SoundPlayer(Properties.Resources.karta3);
            sirkaOkna = Width;
            ZmenitVzhledButtonu();
            panelZmenaBarvy.Hide();
            pictureBoxZmenenaBarva.Hide();
            buttonPredatTah.Hide();
            labelInfo.Hide();
            buttonLeva.Hide();
            buttonPrava.Hide();
            buttonDalsiKolo.Hide();
            souper = new Souper(this);
            VytvoritBalicek();
            ZamichatBalicek();
            ZamichatBalicek();
            ZamichatBalicek();
            RozdatKarty();
            pocetKaretVRuce1 = hracovaRuka.Controls.OfType<Karta>().Count();
            posledniStavOkna = WindowState;
            if (oknoMaximalizovano) WindowState = FormWindowState.Maximized;
        }

        private void buttonNovaHra_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.penizeHrac = int.Parse(Properties.Settings.Default.Properties["penizeHrac"].DefaultValue.ToString());
            Properties.Settings.Default.penizeSouper = int.Parse(Properties.Settings.Default.Properties["penizeSouper"].DefaultValue.ToString());
            Properties.Settings.Default.Save();
            Hra novaHra = new Hra();
            novaHra.Show();
            this.Dispose();
        }

        private void buttonDalsiKolo_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.penizeHrac == 0 || Properties.Settings.Default.penizeSouper == 0)
            {
                Properties.Settings.Default.penizeHrac = int.Parse(Properties.Settings.Default.Properties["penizeHrac"].DefaultValue.ToString());
                Properties.Settings.Default.penizeSouper = int.Parse(Properties.Settings.Default.Properties["penizeSouper"].DefaultValue.ToString());
            }
            Properties.Settings.Default.Save();
            Hra novaHra = new Hra();
            novaHra.Show();
            this.Dispose();
        }

        private void buttonLeva_Click(object sender, EventArgs e)
        {
            Karta posledniKarta = KartaPodlePoradi(hracovaRuka.Controls.OfType<Karta>().Count() - 1, hracovaRuka);
            hracovaRuka.Controls.SetChildIndex(posledniKarta, 0);
            if (zvukZapnuty) zvuk2.Play();
        }

        private void buttonPrava_Click(object sender, EventArgs e)
        {
            Karta prvniKarta = KartaPodlePoradi(0, hracovaRuka);
            hracovaRuka.Controls.SetChildIndex(prvniKarta, hracovaRuka.Controls.OfType<Karta>().Count() - 1);
            if (zvukZapnuty) zvuk2.Play();
        }

        private void buttonZmenitNaSrdce_Click(object sender, EventArgs e)
        {
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            vrchniKarta.zmenenaBarva = "srdce";
            panelZmenaBarvy.Hide();
            PredatTah();
        }

        private void buttonZmenitNaListy_Click(object sender, EventArgs e)
        {
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            vrchniKarta.zmenenaBarva = "listy";
            panelZmenaBarvy.Hide();
            PredatTah();
        }

        private void buttonZmenitNaZaludy_Click(object sender, EventArgs e)
        {
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            vrchniKarta.zmenenaBarva = "zaludy";
            panelZmenaBarvy.Hide();
            PredatTah();
        }

        private void buttonZmenitNaKule_Click(object sender, EventArgs e)
        {
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            vrchniKarta.zmenenaBarva = "kule";
            panelZmenaBarvy.Hide();
            PredatTah();
        }

        private void buttonPredatTah_Click(object sender, EventArgs e)
        {
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            vrchniKarta.plati = false;
            buttonPredatTah.Hide();
            PredatTah();
        }

        private void comboBoxObtiznost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxObtiznost.SelectedIndex == 0)
            {
                obtiznost = 1;
                Properties.Settings.Default.obtiznost = 1;
            }
            else if (comboBoxObtiznost.SelectedIndex == 1)
            {
                obtiznost = 2;
                Properties.Settings.Default.obtiznost = 2;
            }
            Properties.Settings.Default.Save();
        }

        private void comboBoxVzhledKaret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVzhledKaret.SelectedIndex == 0)
            {
                vzhledKaret = 1;
                Properties.Settings.Default.vzhledKaret = 1;
            }
            else if (comboBoxVzhledKaret.SelectedIndex == 1)
            {
                vzhledKaret = 2;
                Properties.Settings.Default.vzhledKaret = 2;
            }
            Properties.Settings.Default.Save();
            if (balicekOdehranychKaret.Controls.Count != 0) ZmenitVzhledKaret();
        }

        private void buttonZvuk_Click(object sender, EventArgs e)
        {
            if (zvukZapnuty)
            {
                zvukZapnuty = false;
                buttonZvuk.ToolTipText = "Zvuky jsou vypnuté";
            }
            else
            {
                zvukZapnuty = true;
                buttonZvuk.ToolTipText = "Zvuky jsou zapnuté";
            }
            buttonZvuk.Checked = zvukZapnuty;
            Properties.Settings.Default.zvukZapnuty = zvukZapnuty;
        }

        private void buttonVsadit_Click(object sender, EventArgs e)
        {
            try
            {
                sazka = int.Parse(textBoxSazka.Text);
                if (Properties.Settings.Default.penizeHrac - sazka >= 0)
                {
                    Properties.Settings.Default.penizeHrac -= sazka;
                    Properties.Settings.Default.penizeSouper -= sazka;
                    labelPenizeHrac.Text = Properties.Settings.Default.penizeHrac + " Kč";
                    labelPenizeSouper.Text = Properties.Settings.Default.penizeSouper + " Kč";
                    buttonVsadit.Enabled = false;
                    buttonZvysitSazku.Enabled = false;
                    buttonSnizitSazku.Enabled = false;
                    textBoxSazka.Enabled = false;
                }
                else MessageBox.Show("Nemůžeš vsadit víc peněz než máš", "Prší");
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadej kolik korun si chceš vsadit (jenom číslo)", "Prší");
            }
        }

        private void buttonZvysitSazku_Click(object sender, EventArgs e)
        {
            try
            {
                int sazka2 = int.Parse(textBoxSazka.Text);
                if (sazka2 + 50 <= Properties.Settings.Default.penizeHrac) sazka2 += 50;
                textBoxSazka.Text = sazka2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadej kolik korun si chceš vsadit (jenom číslo)", "Prší");
            }
        }

        private void buttonSnizitSazku_Click(object sender, EventArgs e)
        {
            try
            {
                int sazka2 = int.Parse(textBoxSazka.Text);
                if (sazka2 >= 50) sazka2 -= 50;
                textBoxSazka.Text = sazka2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadej kolik korun si chceš vsadit (jenom číslo)", "Prší");
            }
        }

        private void buttonKonec_Click(object sender, EventArgs e)
        {
            if (konecHry) Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void VytvoritBalicek()
        {
            foreach (string barva in barvy)
            {
                foreach (string hodnota in hodnoty)
                {
                    Karta karta = new Karta(hodnota, barva, this);
                    balicekKaret.Controls.Add(karta);
                    karta.MouseDown += new MouseEventHandler(karta_MouseDown);
                    karta.MouseUp += new MouseEventHandler(karta_MouseUp);
                    karta.MouseMove += new MouseEventHandler(karta_MouseMove);
                }
            }
        }

        private void ZamichatBalicek()
        {
            Random rnd = new Random();
            int[] cisla = new int[32];
            List<int> indexy = new List<int>();
            for (int i = 0; i < 32; ++i) cisla[i] = i;
            while (indexy.Count != 32)
            {
                int nahodnyindex = rnd.Next(0, 32);
                if (!indexy.Contains(cisla[nahodnyindex])) indexy.Add(cisla[nahodnyindex]);
            }
            foreach (Karta karta in balicekKaret.Controls.OfType<Karta>())
            {
                balicekKaret.Controls.SetChildIndex(karta, indexy[0]);
                indexy.RemoveAt(0);
            }
        }

        private void OtocitBalicek()
        {
            for (int i = balicekOdehranychKaret.Controls.OfType<Karta>().Count() - 1; i > 0; --i)
            {
                Karta karta = KartaPodlePoradi(i, balicekOdehranychKaret);
                karta.PresunoutKartu(balicekKaret);
                karta.OtocitNaZadniStranu();
                karta.plati = true;
            }
        }

        private void RozdatKarty()
        {
            for (int i = 0; i < 8; ++i)
            {
                Karta karta = KartaPodlePoradi(i, balicekKaret);
                if (i % 2 == 0)
                {
                    karta.OtocitNaPredniStranu();
                    karta.PresunoutKartu(hracovaRuka);
                }
                else
                {
                    karta.PresunoutKartu(souperovaRuka);
                }
            }
            Karta vrchniKarta = KartaPodlePoradi(8, balicekKaret);
            vrchniKarta.OtocitNaPredniStranu();
            vrchniKarta.PresunoutKartu(balicekOdehranychKaret);
            if (vrchniKarta.hodnota == "eso" || vrchniKarta.hodnota == "7") vrchniKarta.plati = false;
        }

        public void ZkontrolovatPocetKaret()
        {
            if (balicekKaret.Controls.OfType<Karta>().Count() <= 8) OtocitBalicek();
            if (!konecHry)
            {
                if (hracovaRuka.Controls.OfType<Karta>().Count() == 0)
                {
                    konecHry = true;
                    labelInfo.Text = "Vyhrál jsi!";
                    labelInfo.Show();
                    buttonDalsiKolo.Show();
                    if (sazka != 0)
                    {
                        Properties.Settings.Default.penizeHrac += sazka * 2;
                        labelInfo.Text += "\n➕" + sazka + " Kč";
                        if (Properties.Settings.Default.penizeSouper == 0) buttonDalsiKolo.Text = "Nová hra";
                    }
                }
                else if (souperovaRuka.Controls.OfType<Karta>().Count() == 0)
                {
                    konecHry = true;
                    labelInfo.Text = "Prohrál jsi";
                    labelInfo.Show();
                    buttonDalsiKolo.Show();
                    if (sazka != 0)
                    {
                        Properties.Settings.Default.penizeSouper += sazka * 2;
                        labelInfo.Text += "\n➖" + sazka + " Kč";
                        if (Properties.Settings.Default.penizeHrac == 0)
                        {
                            buttonDalsiKolo.Text = "Nová hra";
                            labelInfo.Text += "\nProhrál jsi všechny své peníze";
                        }
                    }
                }
                if (hracovaRuka.Controls.OfType<Karta>().Count() >= 10)
                {
                    buttonLeva.Show();
                    buttonPrava.Show();
                }
                else
                {
                    buttonLeva.Hide();
                    buttonPrava.Hide();
                }
            }
            if (konecHry)
            {
                panelZmenaBarvy.Hide();
                buttonPredatTah.Hide();
            }
            if (konecHry && sazka != 0)
            {
                labelPenizeHrac.Text = Properties.Settings.Default.penizeHrac + " Kč";
                labelPenizeSouper.Text = Properties.Settings.Default.penizeSouper + " Kč";
            }
        }

        public void PredatTah()
        {
            ZkontrolovatPocetKaret();
            if (!konecHry)
            {
                Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
                if (vrchniKarta.hodnota == "svrsek")
                {
                    if (vrchniKarta.hralKartu == "hrac" && vrchniKarta.zmenenaBarva != null)
                    {
                        pictureBoxZmenenaBarva.Show();
                        ZmenitVzhledPictureBoxu();
                        pictureBoxZmenenaBarva.Location = new Point(pictureBoxZmenenaBarva.Location.X, zmenenaBarvaY);
                    }
                    else if (vrchniKarta.hralKartu == "souper" && vrchniKarta.zmenenaBarva != null)
                    {
                        pictureBoxZmenenaBarva.Show();
                        ZmenitVzhledPictureBoxu();
                        pictureBoxZmenenaBarva.Location = new Point(pictureBoxZmenenaBarva.Location.X, zmenenaBarvaY2);
                    }
                }
                else if (vrchniKarta.hodnota == "7" && vrchniKarta.plati)
                {
                    ++pocet7;
                    pocetKaretkLiznuti = pocet7 * 2;
                    if (vrchniKarta.hralKartu == "souper" && praveHraje == "souper")
                    {
                        labelInfo.Text = "Vezmi si " + pocetKaretkLiznuti;
                        labelInfo.Show();
                    }
                }
                else
                {
                    if (pictureBoxZmenenaBarva.Visible) pictureBoxZmenenaBarva.Hide();
                    pictureBoxZmenenaBarva.Image = null;
                    pocet7 = 0;
                }
                if (buttonVsadit.Enabled)
                {
                    buttonVsadit.Enabled = false;
                    buttonZvysitSazku.Enabled = false;
                    buttonSnizitSazku.Enabled = false;
                    textBoxSazka.Enabled = false;
                    if (sazka == 0)
                    {
                        labelPenizeHrac.Hide();
                        labelPenizeSouper.Hide();
                    }
                }
                if (praveHraje == "hrac" && !konecHry)
                {
                    if (vrchniKarta.hodnota == "eso") buttonPredatTah.Hide();
                    praveHraje = "souper";
                    souper.Hraj();
                }
                else if (!konecHry)
                {
                    praveHraje = "hrac";
                    if (vrchniKarta.hodnota == "eso" && vrchniKarta.hralKartu == "souper" && vrchniKarta.plati) buttonPredatTah.Show();
                    pocetKaretVRuce1 = hracovaRuka.Controls.OfType<Karta>().Count();
                }
            }
        }

        public bool LzeHratKartu(Karta karta)
        {
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            bool lzePresunout = false;
            if (vrchniKarta.hodnota == "eso")
            {
                if (karta.hodnota == "eso") lzePresunout = true;
                else if (vrchniKarta.hralKartu == "hrac" && praveHraje == "hrac" && karta.barva == vrchniKarta.barva) lzePresunout = true;
                else if (vrchniKarta.hralKartu == "souper" && praveHraje == "souper" && karta.barva == vrchniKarta.barva) lzePresunout = true;
                else if (!vrchniKarta.plati && karta.barva == vrchniKarta.barva) lzePresunout = true;
                else if (!vrchniKarta.plati && karta.hodnota == "svrsek") lzePresunout = true;
                else if (vrchniKarta.hralKartu == null && karta.barva == vrchniKarta.barva) lzePresunout = true;
                else if (vrchniKarta.hralKartu == null && karta.hodnota == "svrsek") lzePresunout = true;
            }
            else if (vrchniKarta.hodnota == "7")
            {
                if (karta.hodnota == "7") lzePresunout = true;
                else if (vrchniKarta.hralKartu == "hrac" && praveHraje == "hrac" && karta.barva == vrchniKarta.barva) lzePresunout = true;
                else if (vrchniKarta.hralKartu == "souper" && praveHraje == "souper" && karta.barva == vrchniKarta.barva) lzePresunout = true;
                else if (!vrchniKarta.plati && karta.barva == vrchniKarta.barva) lzePresunout = true;
                else if (!vrchniKarta.plati && karta.hodnota == "svrsek") lzePresunout = true;
                else if (vrchniKarta.hralKartu == null && karta.barva == vrchniKarta.barva) lzePresunout = true;
                else if (vrchniKarta.hralKartu == null && karta.hodnota == "svrsek") lzePresunout = true;
            }
            else if (karta.hodnota == "svrsek") lzePresunout = true;
            else if (vrchniKarta.zmenenaBarva == null && (karta.barva == vrchniKarta.barva || karta.hodnota == vrchniKarta.hodnota)) lzePresunout = true;
            else if (karta.barva == vrchniKarta.zmenenaBarva || karta.hodnota == vrchniKarta.hodnota) lzePresunout = true;
            return lzePresunout;
        }

        private void ZmenitVzhledKaret()
        {
            List<Karta> kartyKeZmeneni = new List<Karta>();
            for (int i = 0; i < hracovaRuka.Controls.Count; ++i)
            {
                if (hracovaRuka.Controls[i] is Karta) kartyKeZmeneni.Add((Karta)hracovaRuka.Controls[i]);
            }
            kartyKeZmeneni.Add(KartaPodlePoradi(0, balicekOdehranychKaret));
            for (int i = 0; i < kartyKeZmeneni.Count; ++i)
            {
                Karta karta = kartyKeZmeneni[i];
                karta.ZmenitVzhled(vzhledKaret);
            }
            ZmenitVzhledButtonu();
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            if (pictureBoxZmenenaBarva.Visible && vrchniKarta.zmenenaBarva != null) ZmenitVzhledPictureBoxu();
        }

        private void ZmenitVzhledButtonu()
        {
            if (vzhledKaret == 1)
            {
                buttonZmenitNaSrdce.BackgroundImage = Obrazek(barvy[1]);
                buttonZmenitNaListy.BackgroundImage = Obrazek(barvy[2]);
                buttonZmenitNaZaludy.BackgroundImage = Obrazek(barvy[0]);
                buttonZmenitNaKule.BackgroundImage = Obrazek(barvy[3]);
            }
            else if (vzhledKaret == 2)
            {
                buttonZmenitNaSrdce.BackgroundImage = Obrazek(barvy2[1]);
                buttonZmenitNaListy.BackgroundImage = Obrazek(barvy2[2]);
                buttonZmenitNaZaludy.BackgroundImage = Obrazek(barvy2[0]);
                buttonZmenitNaKule.BackgroundImage = Obrazek(barvy2[3]);
            }
        }

        private void ZmenitVzhledPictureBoxu()
        {
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            if (vzhledKaret == 1) pictureBoxZmenenaBarva.Image = Obrazek(vrchniKarta.zmenenaBarva);
            else if (vzhledKaret == 2)
            {
                if (vrchniKarta.zmenenaBarva == barvy[0]) pictureBoxZmenenaBarva.Image = Obrazek(barvy2[0]);
                else if (vrchniKarta.zmenenaBarva == barvy[1]) pictureBoxZmenenaBarva.Image = Obrazek(barvy2[1]);
                else if (vrchniKarta.zmenenaBarva == barvy[2]) pictureBoxZmenenaBarva.Image = Obrazek(barvy2[2]);
                else if (vrchniKarta.zmenenaBarva == barvy[3]) pictureBoxZmenenaBarva.Image = Obrazek(barvy2[3]);
            }
        }

        public Karta KartaPodlePoradi(int poradi, Control panel)
        {
            return (Karta)panel.Controls[poradi];
        }

        public Bitmap Obrazek(string nazev)
        {
            return (Bitmap)Properties.Resources.ResourceManager.GetObject(nazev);
        }

        private bool JeNadBOK(Karta karta)
        {
            bool jeNadBOKlokaceY = karta.Location.Y >= balicekOdehranychKaret.Location.Y - 50 && karta.Location.Y <= balicekOdehranychKaret.Location.Y + 50;
            bool jeNadBOKlokaceX = karta.Location.X >= balicekOdehranychKaret.Location.X - 50 && karta.Location.X <= balicekOdehranychKaret.Location.X + 50;
            bool jeNadBOK = jeNadBOKlokaceY && jeNadBOKlokaceX;
            return jeNadBOK;
        }

        private void karta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !konecHry && praveHraje != "souper")
            {
                lokaceKliknuti = e.Location;
                Karta karta = sender as Karta;
                Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
                if (karta.Parent != balicekOdehranychKaret && karta.Parent != souperovaRuka && !(karta.Parent == balicekKaret && vrchniKarta.hodnota == "eso" && vrchniKarta.plati))
                {
                    if (zvukZapnuty && karta.Parent == balicekKaret) zvuk3.Play();
                    else if (zvukZapnuty) zvuk2.Play();
                    karta.Parent = panel1;
                }
            }
        }

        private void karta_MouseUp(object sender, MouseEventArgs e)
        {
            Karta karta = sender as Karta;
            Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
            if (JeNadBOK(karta))
            {
                if (karta.otocenoPredniStranou)
                {
                    if (LzeHratKartu(karta))
                    {
                        karta.PresunoutKartu(balicekOdehranychKaret);
                        karta.BringToFront();
                        karta.hralKartu = "hrac";
                        if (zvukZapnuty) zvuk1.Play();
                        if (karta.hodnota == "7") labelInfo.Hide();
                        if (karta.hodnota == "svrsek") panelZmenaBarvy.Show();
                        else PredatTah();
                        ZkontrolovatPocetKaret();
                    }
                    else
                    {
                        karta.PresunoutKartu(hracovaRuka);
                    }
                }
                else
                {
                    karta.Parent = balicekKaret;
                }
            }
            else if (karta.Location.Y > hracovaRuka.Location.Y - 30)
            {
                karta.PresunoutKartu(hracovaRuka);
                int pocetKaretVRuce2 = hracovaRuka.Controls.OfType<Karta>().Count();
                if (pocetKaretVRuce2 != pocetKaretVRuce1)
                {
                    karta.OtocitNaPredniStranu();
                    if (vrchniKarta.hodnota == "7" && vrchniKarta.hralKartu == "souper" && vrchniKarta.plati)
                    {
                        --pocetKaretkLiznuti;
                        if (pocetKaretkLiznuti == 0)
                        {
                            labelInfo.Hide();
                            pocet7 = 0;
                            vrchniKarta.plati = false;
                            PredatTah();
                        }
                    }
                    else PredatTah();
                }
            }
        }

        private void karta_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !konecHry && praveHraje != "souper")
            {
                Karta karta = sender as Karta;
                Karta vrchniKarta = KartaPodlePoradi(0, balicekOdehranychKaret);
                if (karta.Parent != balicekOdehranychKaret && karta.Parent != souperovaRuka && !(karta.Parent == balicekKaret && vrchniKarta.hodnota == "eso" && vrchniKarta.plati))
                {
                    karta.Left = karta.Left + e.X - lokaceKliknuti.X;
                    karta.Top = karta.Top + e.Y - lokaceKliknuti.Y;
                    karta.BringToFront();
                }
            }
        }

        private void Hra_Resize(object sender, EventArgs e)
        {
            if (WindowState != posledniStavOkna && WindowState != FormWindowState.Minimized)
            {
                posledniStavOkna = WindowState;
                double pomer = 0;
                if (WindowState == FormWindowState.Maximized)
                {
                    pomer = Math.Round((double)Width / sirkaOkna, 2);
                    sirkaOkna2 = Width;
                    Properties.Settings.Default.oknoMaximalizovano = true;
                }
                else if (WindowState == FormWindowState.Normal)
                {
                    pomer = Math.Round((double)Width / sirkaOkna2, 2);
                    Properties.Settings.Default.oknoMaximalizovano = false;
                }
                if (pomer != 0)
                {
                    zmenenaBarvaY = (int)(zmenenaBarvaY * pomer);
                    zmenenaBarvaY2 = (int)(zmenenaBarvaY2 * pomer);
                    List<Control> prvkyKeZmeneni = new List<Control>();
                    prvkyKeZmeneni.Add(panel1);
                    foreach (Control prvek in panel1.Controls) prvkyKeZmeneni.Add(prvek);
                    foreach (Control prvek in balicekKaret.Controls) prvkyKeZmeneni.Add(prvek);
                    foreach (Control prvek in balicekOdehranychKaret.Controls) prvkyKeZmeneni.Add(prvek);
                    foreach (Control prvek in hracovaRuka.Controls) prvkyKeZmeneni.Add(prvek);
                    foreach (Control prvek in souperovaRuka.Controls) prvkyKeZmeneni.Add(prvek);
                    foreach (Control prvek in panelZmenaBarvy.Controls) prvkyKeZmeneni.Add(prvek);
                    for (int i = 0; i < prvkyKeZmeneni.Count; ++i)
                    {
                        Control prvek = prvkyKeZmeneni[i];
                        prvek.Width = (int)(prvek.Width * pomer);
                        prvek.Height = (int)(prvek.Height * pomer);
                        prvek.Location = new Point((int)(prvek.Location.X * pomer), (int)(prvek.Location.Y * pomer));
                        if (prvek is Karta)
                        {
                            Karta karta = (Karta)prvek;
                            if (karta.otocenoPredniStranou) karta.OtocitNaPredniStranu();
                            else karta.OtocitNaZadniStranu();
                        }
                        else if (prvek is Label || prvek is Button)
                        {
                            int velikostPisma = (int)(prvek.Font.Size * pomer);
                            if (velikostPisma > 0) prvek.Font = new Font(prvek.Font.FontFamily, velikostPisma, prvek.Font.Style);
                        }
                    }
                }
            }
        }

        private void Hra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (konecHry) Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}
