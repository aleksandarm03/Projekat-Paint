using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace Paint
{
    public class Pravougaonik : Oblik
    {
        private bool unutrasnjost;

        public Pravougaonik(Point tacka, Point tacka2,Pen olovka, bool unutrasnjost)
            : base(tacka, tacka2,olovka)
        {
            
            this.unutrasnjost = unutrasnjost;
        }

        public override void Crtaj(Graphics g)
        {
            if (unutrasnjost == false)
            {
                g.DrawLine(olovka, tacka1.X, tacka1.Y, tacka1.X, tacka2.Y);
                g.DrawLine(olovka, tacka1.X, tacka2.Y, tacka2.X, tacka2.Y);
                g.DrawLine(olovka, tacka2.X, tacka2.Y, tacka2.X, tacka1.Y);
                g.DrawLine(olovka, tacka2.X, tacka1.Y, tacka1.X, tacka1.Y);
            }
            else
            {
                int najmanjaKoordinataX=0;
                int najvecaKoordinataX=0;
                int najmanjaKoordinataY=0;
                int najvecaKoordinataY=0;

                if (tacka1.X < tacka2.X)

                    najmanjaKoordinataX = tacka1.X;
                else najmanjaKoordinataX = tacka2.X;
                
                if (tacka1.X> tacka2.X)
                    najvecaKoordinataX = tacka1.X;
                else najvecaKoordinataX = tacka2.X;


                if (tacka1.Y < tacka2.Y)
                    najmanjaKoordinataY = tacka1.Y;
                else najmanjaKoordinataY = tacka2.Y;

                if (tacka1.Y > tacka2.Y)
                    najvecaKoordinataY = tacka1.Y;
                else najvecaKoordinataY = tacka2.Y;                
                SolidBrush b = new SolidBrush(olovka.Color);
               g.FillRectangle(b, najmanjaKoordinataX, najmanjaKoordinataY,Math.Abs( najvecaKoordinataX - najmanjaKoordinataX),Math.Abs( najvecaKoordinataY - najmanjaKoordinataY));
            }
        }
    }

}
    
   



        
  
