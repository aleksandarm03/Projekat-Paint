using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using WMPLib;
namespace Paint
{

    public partial class Form1 : Form
    {

         WMPLib.WindowsMediaPlayer player = new WindowsMediaPlayer();
         Random r = new Random();
         bool unutarOblika = false;
         Graphics g;
         Pen olovka = new Pen(Color.Black, 5);
         Point trenutna_tacka = new Point();
         Point prethodna_tacka = new Point();
        public Form1()
        {
            InitializeComponent();          
                         
            groupBox2.Visible = false;
            RbOlovka.Checked = true;
            textBox1.Enabled = false;
            textBox1.BackColor = Color.Black;
            g = panel1.CreateGraphics();
            olovka.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            CenterToParent();
            ColorDialog cd = new ColorDialog();
            MessageBox.Show("Odaberite boju pozadine.","Dobrodosli!");
            textBox2.Enabled = false;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                textBox2.BackColor = cd.Color;
                panel1.BackColor = cd.Color;
            }
            else panel1.BackColor = Color.White;
           
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Pravougaonik.Checked == true||Elipsa.Checked==true ||PravaLinija.Checked==true)
            {
                trenutna_tacka=e.Location;
                RbOlovka.Checked = false;
            }
            else if(RbOlovka.Checked==true)
            prethodna_tacka = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && RbOlovka.Checked == true && Pravougaonik.Checked == false && Elipsa.Checked == false && PravaLinija.Checked == false )
            {
                trenutna_tacka = e.Location;
                g.DrawLine(olovka,prethodna_tacka,trenutna_tacka);
                prethodna_tacka = trenutna_tacka;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            { 
                olovka.Color = cd.Color;
                textBox1.BackColor = cd.Color;
            }
            
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string p = "Da li zaista zelite da obrisete sve sa ekrana";
            DialogResult opcija=MessageBox.Show(p,"Upozorenje",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (opcija == DialogResult.Yes)
            {
                panel1.Refresh();
                panel1.BackgroundImage = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            player.controls.play();
            player.settings.setMode("loop",true);
            Popunjenost.Visible = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            olovka.SetLineCap(System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.DashCap.Flat);
            RbOlovka.Checked = true;
            olovka.Color = panel1.BackColor;
            olovka.Width = 25;
        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            olovka.Width = trackBar1.Value;
            numericUpDown1.Value = trackBar1.Value;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Pravougaonik.Checked == true)
            {
               
                    if (Popunjenost.Checked == true) unutarOblika = true;
                    else unutarOblika = false;
                    Point p = new Point(e.X, e.Y);
                    Oblik o = (Oblik)(new Pravougaonik(trenutna_tacka, p, olovka, unutarOblika));
                    o.Crtaj(g);
                }
                
            
             if (Elipsa.Checked == true)
            {
                if (Popunjenost.Checked == true) unutarOblika = true;
                else unutarOblika = false;
                Point p = new Point(e.X, e.Y);
                Oblik o = (Oblik)(new Elipsa(trenutna_tacka, p, olovka, unutarOblika));
                o.Crtaj(g);

            }
            if (PravaLinija.Checked == true)
             {                 
                 Point p = new Point(e.X, e.Y);
                 Oblik o = (Oblik)(new PravaLinija(trenutna_tacka, p, olovka));
                 o.Crtaj(g);

             }
           
            
        }

        private void RBolovka_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Pravougaonik.Checked == true || Elipsa.Checked==true) Popunjenost.Visible = true;
            else Popunjenost.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Vatromet.Checked == true)
            {
                Pen pen =new Pen(Color.FromArgb(r.Next(255),r.Next(255),r.Next(255),trackBar1.Value),trackBar1.Value);
                Point p = new Point(trenutna_tacka.X + r.Next(-100, 100), trenutna_tacka.Y + r.Next(-100, 100));
                Oblik o = (Oblik)(new PravaLinija(trenutna_tacka, p,pen ));
                o.Crtaj(g);
            }
            else timer1.Stop();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

      

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
        }

        private void RBpravougaonik_CheckedChanged(object sender, EventArgs e)
        {
            if (Pravougaonik.Checked == true)
            {
                textBox1.BackColor = olovka.Color;
                Popunjenost.Visible = true;
            }
            else if(Elipsa.Checked == true)
            {
                Popunjenost.Visible = true;
            }
            else Popunjenost.Visible = false;
        
        }

        private void RBelipsa_CheckedChanged(object sender, EventArgs e)
        {
            if (Elipsa.Checked == true)
            {
                textBox1.BackColor = olovka.Color;
                Popunjenost.Visible = true;
            }
            else if (Pravougaonik.Checked == true)
            {
                Popunjenost.Visible = true;
            }
            else Popunjenost.Visible = false;
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = olovka.Color;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Zvezda.Checked == true)
            {
                trenutna_tacka = e.Location;
                Zvezda s = new Zvezda(trenutna_tacka, trackBar1.Value,olovka);
                s.Crtaj(g);
            }
            else if (Srce.Checked == true)
            {
                trenutna_tacka = e.Location;
                Srce s = new Srce(trenutna_tacka, trackBar1.Value,olovka);
                s.Crtaj(g);
            }
            else if (Vatromet.Checked == true)
            {
                trenutna_tacka = e.Location;
                timer1.Start();

            }
            else if (Smajli.Checked == true)
            {

                trenutna_tacka = e.Location;
                Smajli1.Visible = true;
                Smajli2.Visible = true;
                Smajli3.Visible = true;
                if (Smajli1.Checked == true)
                {
                    Smajli s = (Smajli)(new Smajli1(trenutna_tacka, olovka,trackBar1.Value));
                    s.Crtaj(g);
                }
                else if (Smajli2.Checked == true)
                {
                    Smajli s = (Smajli)(new Smajli2(trenutna_tacka, olovka, trackBar1.Value));
                    s.Crtaj(g);
                }
                else
                {
                    Smajli s = (Smajli)(new Smajli3(trenutna_tacka, olovka,trackBar1.Value));
                    s.Crtaj(g);
                }
            }
          
            
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            Smajli1.Checked = true;
            if (Smajli.Checked == true)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 122, 984, 505);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g1 = Graphics.FromImage(bmp);
            g1.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            g1.Save();
        
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }

                Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                Rectangle bounds = new Rectangle(0,122,984,627);
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);                
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                   
                        g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                    
                    bmp.Save(sfd.FileName, format);
                }
                
            }



          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            olovka.Color.GetBrightness();
           
            string filename;

           openFileDialog1.ShowDialog();
           openFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";

           filename = openFileDialog1.FileName;
           Image img = Image.FromFile(filename);
            
           panel1.BackgroundImage = img;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
            ColorDialog cd1 = new ColorDialog();
            if (cd1.ShowDialog() == DialogResult.OK)
            {
                string p = "Ako promenite boju pozadine prethodni rad nece biti sacuvan.Zelite li da nastavite?";
                DialogResult opcija = MessageBox.Show(p, "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcija == DialogResult.Yes)
                {
                    panel1.BackgroundImage = null;
                    panel1.BackColor = cd1.Color;
                    textBox2.BackColor = cd1.Color;
                }
                
            }
        }

     

     
    

       
      

       

        
    }
}
