using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    abstract class Smajli
    {
        protected Point tacka;
        protected Pen olovka;
        protected int a;
        public Smajli(Point tacka, Pen olovka)
        {
            this.tacka = tacka;            
            this.olovka = olovka;
            a = 200;
        }

        public virtual void Crtaj(Graphics g)
        {
            
        }
    }
}
