using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Paint
{

    public abstract class Oblik
    {
        protected Point tacka1;
        protected Point tacka2;
        protected Pen olovka;       
        
        public Oblik(Point tacka1, Point tacka2,Pen olovka)
        {
            this.olovka = olovka;
            this.tacka1 = tacka1;
            this.tacka2 = tacka2;
        }

        public abstract void Crtaj(Graphics g);
    }


}
