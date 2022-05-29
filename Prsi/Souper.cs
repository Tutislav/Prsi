using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prsi
{
    class Souper
    {
        private int pocetZaludy = 0;
        private int pocetSrdce = 0;
        private int pocetListy = 0;
        private int pocetKule = 0;
        private List<Karta> specialniKarty = new List<Karta>();
        private Hra hra;
        private Control panel1, souperovaRuka, balicekKaret, balicekOdehranychKaret;

        public Souper(Hra hra)
        {
            this.hra = hra;
            panel1 = hra.Controls["panel1"];
            souperovaRuka = panel1.Controls["souperovaRuka"];
            balicekOdehranychKaret = panel1.Controls["balicekOdehranychKaret"];
            balicekKaret = panel1.Controls["balicekKaret"];
        }

        public async void Hraj()
        {
            bool souperHral = false;
            if (hra.obtiznost == 2) SpocitatKarty();
            await Task.Delay(500);
            Karta karta = null;
            for (int i = 0; i < souperovaRuka.Controls.OfType<Karta>().Count() && !souperHral; ++i)
            {
                karta = hra.KartaPodlePoradi(i, souperovaRuka);
                if (hra.obtiznost == 2)
                {
                    for (int j = 0; j < specialniKarty.Count; ++j)
                    {
                        if (specialniKarty[j].Name == karta.Name)
                        {
                            karta.OtocitNaPredniStranu();
                            karta.PresunoutKartu(balicekOdehranychKaret);
                            karta.BringToFront();
                            if (hra.zvukZapnuty) hra.zvuk1.Play();
                            souperHral = true;
                        }
                    }
                }
                if (hra.LzeHratKartu(karta) && !souperHral && specialniKarty.Count == 0)
                {
                    karta.OtocitNaPredniStranu();
                    karta.PresunoutKartu(balicekOdehranychKaret);
                    karta.BringToFront();
                    if (hra.zvukZapnuty) hra.zvuk1.Play();
                    souperHral = true;
                }
            }
            if (souperHral)
            {
                karta.hralKartu = "souper";
                if (karta.hodnota == "svrsek")
                {
                    hra.ZkontrolovatPocetKaret();
                    switch (hra.obtiznost)
                    {
                        case 1:
                            Random rnd = new Random();
                            karta.zmenenaBarva = hra.barvy[rnd.Next(0, 4)];
                            break;
                        case 2:
                            int[] poctyKaret = { pocetZaludy, pocetSrdce, pocetListy, pocetKule };
                            int iNejcasBarvy = 0;
                            for (int j = 0; j < poctyKaret.Length; ++j) if (poctyKaret[j] > poctyKaret[iNejcasBarvy]) iNejcasBarvy = j;
                            karta.zmenenaBarva = hra.barvy[iNejcasBarvy];
                            break;
                    }
                }
            }
            else if (!souperHral)
            {
                hra.ZkontrolovatPocetKaret();
                Karta vrchniKarta = hra.KartaPodlePoradi(0, balicekOdehranychKaret);
                if (vrchniKarta.hodnota == "eso" && vrchniKarta.hralKartu != null && vrchniKarta.plati)
                {
                    vrchniKarta.plati = false;
                }
                else if (vrchniKarta.hodnota == "7" && vrchniKarta.hralKartu == "hrac" && vrchniKarta.plati)
                {
                    while (hra.pocetKaretkLiznuti > 0)
                    {
                        Karta kartaZBalicku = hra.KartaPodlePoradi(0, balicekKaret);
                        kartaZBalicku.PresunoutKartu(souperovaRuka);
                        if (hra.zvukZapnuty) hra.zvuk3.Play();
                        --hra.pocetKaretkLiznuti;
                        hra.ZkontrolovatPocetKaret();
                        await Task.Delay(500);
                    }
                    hra.pocet7 = 0;
                    vrchniKarta.plati = false;
                }
                else
                {
                    Karta kartaZBalicku = hra.KartaPodlePoradi(0, balicekKaret);
                    kartaZBalicku.PresunoutKartu(souperovaRuka);
                    if (hra.zvukZapnuty) hra.zvuk3.Play();
                }
            }
            hra.PredatTah();
        }

        private void SpocitatKarty()
        {
            pocetZaludy = 0; pocetSrdce = 0; pocetListy = 0; pocetKule = 0; specialniKarty.Clear();
            for (int i = 0; i < souperovaRuka.Controls.OfType<Karta>().Count(); ++i)
            {
                Karta karta = hra.KartaPodlePoradi(i, souperovaRuka);
                switch (karta.barva)
                {
                    case "zaludy":
                        ++pocetZaludy;
                        break;
                    case "srdce":
                        ++pocetSrdce;
                        break;
                    case "listy":
                        ++pocetListy;
                        break;
                    case "kule":
                        ++pocetKule;
                        break;
                }
                switch (karta.hodnota)
                {
                    case "eso":
                        if (hra.LzeHratKartu(karta)) specialniKarty.Add(karta);
                        break;
                    case "7":
                        if (hra.LzeHratKartu(karta)) specialniKarty.Add(karta);
                        break;
                    case "svrsek":
                        if (hra.LzeHratKartu(karta)) specialniKarty.Add(karta);
                        break;
                }
            }
        }
    }
}
