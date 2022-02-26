using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi.Models
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen(){}
        public Dikdortgen(int x, int y, int genislik, int yukseklik, Color renk) : base(x,y,genislik,yukseklik,renk) {}
        public override string Tur => "Dikdörtgen";

        public override double Alan()
        {
            return Genislik * Yukseklik;
        }

        public override double Cevre()
        {
            return 2 * (Genislik + Yukseklik);
        }

        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillRectangle(firca, X, Y, Genislik, Yukseklik);
        }
    }
}
