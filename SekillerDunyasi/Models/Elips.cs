using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasi.Models
{
    public class Elips : Sekil
    {
        public Elips() { }
        public Elips(int x, int y, int genislik, int yukseklik, Color renk) : base(x, y, genislik, yukseklik, renk) { }
        public double R1 => Genislik / 2d;
        public double R2 => Yukseklik / 2d;
        public override string Tur => "Elips";

        public override double Alan()
        {
            return R1 * R2 * Math.PI;
        }

        public override double Cevre()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(R1,2) + Math.Pow(R2,2)) / 2);
        }

        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillEllipse(firca, X, Y, Genislik, Yukseklik);
        }
    }
}
