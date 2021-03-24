using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    class Srce
    {
       private  Point tacka;
       private Pen olovka;
       private int duzina;
       public Srce(Point tacka, int duzina,Pen olovka)
       {
           this.tacka = tacka;
           this.olovka = olovka;
           this.duzina = duzina;
       }
       public void Crtaj(Graphics g)
       {
           Bitmap bmp = new Bitmap(Properties.Resources.Heart);


           int tolerance =100;
           for (Int32 y = 0; y < bmp.Height; y++)
               for (Int32 x = 0; x < bmp.Width; x++)
               {
                   Color PixelColor = bmp.GetPixel(x, y);
                   if (PixelColor.R > Color.Red.R - 50 && PixelColor.R < Color.Red.R + 50 && PixelColor.G > Color.Red.G - tolerance && PixelColor.G < Color.Red.G + tolerance && PixelColor.B > Color.Red.B - tolerance && PixelColor.B < Color.Red.B + tolerance)
                   {
                       int RColorDiff = Color.Red.R - PixelColor.R;
                       int GColorDiff = Color.Red.G - PixelColor.G;
                       int BColorDiff = Color.Red.B - PixelColor.B;
                       if (PixelColor.R > Color.Red.R) RColorDiff = olovka.Color.R + RColorDiff;
                       else RColorDiff = olovka.Color.R - RColorDiff;
                       if (RColorDiff > 255) RColorDiff = 255;
                       if (RColorDiff < 0) RColorDiff = 0;
                       if (PixelColor.G > olovka.Color.G) GColorDiff = olovka.Color.G + GColorDiff;
                       else GColorDiff = olovka.Color.G - GColorDiff;
                       if (GColorDiff > 255) GColorDiff = 255;
                       if (GColorDiff < 0) GColorDiff = 0;
                       if (PixelColor.B > olovka.Color.B) BColorDiff = olovka.Color.B + BColorDiff;
                       else BColorDiff = olovka.Color.B - BColorDiff;
                       if (BColorDiff > 255) BColorDiff = 255;
                       if (BColorDiff < 0) BColorDiff = 0;
                       bmp.SetPixel(x, y, Color.FromArgb(RColorDiff, GColorDiff, BColorDiff));
                   }
               }

           g.DrawImage(bmp, tacka.X - 2 * duzina, tacka.Y - 2 * duzina, 4 * duzina, 4 * duzina);
           
       }
    }
}
