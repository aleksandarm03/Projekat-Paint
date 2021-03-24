using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Paint
{
    class Elipsa:Oblik
    {
        private bool unutrasnjost;
        public Elipsa(Point tacka1, Point tacka2, Pen olovka, bool unutrasnjost)
            : base(tacka1, tacka2, olovka)
        {
            this.unutrasnjost = unutrasnjost;
        }

        public override void Crtaj(Graphics g)
        {

            int najmanjaKoordinataX = 0;
            int najvecaKoordinataX = 0;
            int najmanjaKoordinataY = 0;
            int najvecaKoordinataY = 0;

            if (tacka1.X < tacka2.X)

                najmanjaKoordinataX = tacka1.X;
            else najmanjaKoordinataX = tacka2.X;

            if (tacka1.X > tacka2.X)
                najvecaKoordinataX = tacka1.X;
            else najvecaKoordinataX = tacka2.X;


            if (tacka1.Y < tacka2.Y)
                najmanjaKoordinataY = tacka1.Y;
            else najmanjaKoordinataY = tacka2.Y;

            if (tacka1.Y > tacka2.Y)
                najvecaKoordinataY = tacka1.Y;
            else najvecaKoordinataY = tacka2.Y;
            if (unutrasnjost == false)
            {
                g.DrawEllipse(olovka, najmanjaKoordinataX, najmanjaKoordinataY, Math.Abs(najvecaKoordinataX - najmanjaKoordinataX), Math.Abs(najvecaKoordinataY - najmanjaKoordinataY));
            }
            else
            {
                SolidBrush b = new SolidBrush(olovka.Color);
                g.FillEllipse(b, najmanjaKoordinataX, najmanjaKoordinataY, Math.Abs(najvecaKoordinataX - najmanjaKoordinataX), Math.Abs(najvecaKoordinataY - najmanjaKoordinataY));
            }
        }
    }
}
