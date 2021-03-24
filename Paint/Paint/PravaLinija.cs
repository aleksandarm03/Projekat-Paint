using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    class PravaLinija:Oblik
    {
        public PravaLinija(Point tacka1,Point tacka2,Pen olovka):base(tacka1,tacka2,olovka)
        {}

        public override void Crtaj(Graphics g)
        {
            g.DrawLine(olovka, tacka1.X, tacka1.Y, tacka2.X, tacka2.Y);
        }
    }
}
