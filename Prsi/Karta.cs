using System.Drawing;
using System.Windows.Forms;

namespace Prsi
{
    public class Karta : PictureBox
    {
        public string hodnota;
        public string barva;
        public string zmenenaBarva = null;
        public string hralKartu = null;
        public bool plati = true;
        public bool otocenoPredniStranou = false;
        private int sirkaKarty = 120;
        private int vyskaKarty = 189;
        private Hra hra;

        public Karta(string hodnota, string barva, Hra hra)
        {
            this.hodnota = hodnota;
            this.barva = barva;
            this.Name = barva + "_" + hodnota;
            this.Size = new Size(sirkaKarty, vyskaKarty);
            this.Image = ZmenitVelikostObrazku(hra.Obrazek("rub"), sirkaKarty, vyskaKarty);
            this.BackColor = Color.Transparent;
            this.Location = new Point(0, 0);
            this.hra = hra;
        }

        public void OtocitNaPredniStranu()
        {
            ZmenitVzhled(hra.vzhledKaret);
            otocenoPredniStranou = true;
        }

        public void OtocitNaZadniStranu()
        {
            this.Image = ZmenitVelikostObrazku(hra.Obrazek("rub"), Width, Height);
            otocenoPredniStranou = false;
        }

        public void ZmenitVzhled(byte novyVzhled)
        {
            string obrazekKarty = null;
            switch (novyVzhled)
            {
                case 1:
                    obrazekKarty = barva + "_" + hodnota;
                    this.Image = ZmenitVelikostObrazku(hra.Obrazek(obrazekKarty), Width, Height);
                    break;
                case 2:
                    if (barva == hra.barvy[0]) obrazekKarty = hra.barvy2[0] + "_" + hodnota;
                    else if (barva == hra.barvy[1]) obrazekKarty = hra.barvy2[1] + "_" + hodnota;
                    else if (barva == hra.barvy[2]) obrazekKarty = hra.barvy2[2] + "_" + hodnota;
                    else if (barva == hra.barvy[3]) obrazekKarty = hra.barvy2[3] + "_" + hodnota;
                    this.Image = ZmenitVelikostObrazku(hra.Obrazek(obrazekKarty), Width, Height);
                    break;
            }
        }

        public void PresunoutKartu(Control panelKam)
        {
            this.Parent = panelKam;
            this.Location = new Point(0, 0);
        }

        private Bitmap ZmenitVelikostObrazku(Bitmap obrazek, int sirka, int vyska)
        {
            Bitmap novyObrazek = new Bitmap(sirka, vyska);
            if (obrazek != null)
            {
                using (Graphics grafika = Graphics.FromImage(novyObrazek))
                {
                    grafika.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    grafika.DrawImage(obrazek, new Rectangle(0, 0, sirka, vyska));
                }
            }
            return novyObrazek;
        }
    }
}
