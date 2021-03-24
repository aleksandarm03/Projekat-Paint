namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Smajli2 = new System.Windows.Forms.RadioButton();
            this.Smajli1 = new System.Windows.Forms.RadioButton();
            this.Smajli3 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Boja = new System.Windows.Forms.Button();
            this.ObrisiSve = new System.Windows.Forms.Button();
            this.Gumica = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pravougaonik = new System.Windows.Forms.RadioButton();
            this.Elipsa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BojaPozadine = new System.Windows.Forms.Button();
            this.Zvezda = new System.Windows.Forms.RadioButton();
            this.Srce = new System.Windows.Forms.RadioButton();
            this.Smajli = new System.Windows.Forms.RadioButton();
            this.Vatromet = new System.Windows.Forms.RadioButton();
            this.PravaLinija = new System.Windows.Forms.RadioButton();
            this.Popunjenost = new System.Windows.Forms.CheckBox();
            this.RbOlovka = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.SlikaSaRacunara = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 627);
            this.panel1.TabIndex = 0;            
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(432, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Smajli2);
            this.groupBox2.Controls.Add(this.Smajli1);
            this.groupBox2.Controls.Add(this.Smajli3);
            this.groupBox2.Location = new System.Drawing.Point(416, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 64);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // Smajli2
            // 
            this.Smajli2.AutoSize = true;
            this.Smajli2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Smajli2.Location = new System.Drawing.Point(76, 24);
            this.Smajli2.Name = "Smajli2";
            this.Smajli2.Size = new System.Drawing.Size(51, 27);
            this.Smajli2.TabIndex = 13;
            this.Smajli2.TabStop = true;
            this.Smajli2.Text = "😥";
            this.Smajli2.UseVisualStyleBackColor = true;
            // 
            // Smajli1
            // 
            this.Smajli1.AutoSize = true;
            this.Smajli1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Smajli1.Location = new System.Drawing.Point(6, 23);
            this.Smajli1.Name = "Smajli1";
            this.Smajli1.Size = new System.Drawing.Size(51, 27);
            this.Smajli1.TabIndex = 12;
            this.Smajli1.TabStop = true;
            this.Smajli1.Text = "😀";
            this.Smajli1.UseVisualStyleBackColor = true;
            // 
            // Smajli3
            // 
            this.Smajli3.AutoSize = true;
            this.Smajli3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Smajli3.Location = new System.Drawing.Point(148, 23);
            this.Smajli3.Name = "Smajli3";
            this.Smajli3.Size = new System.Drawing.Size(51, 27);
            this.Smajli3.TabIndex = 14;
            this.Smajli3.TabStop = true;
            this.Smajli3.Text = "😎";
            this.Smajli3.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            this.colorDialog1.FullOpen = true;
            // 
            // Boja
            // 
            this.Boja.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Boja.Location = new System.Drawing.Point(416, 11);
            this.Boja.Name = "Boja";
            this.Boja.Size = new System.Drawing.Size(86, 28);
            this.Boja.TabIndex = 1;
            this.Boja.Text = "Boja";
            this.Boja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boja.UseVisualStyleBackColor = true;
            this.Boja.Click += new System.EventHandler(this.button1_Click);
            // 
            // ObrisiSve
            // 
            this.ObrisiSve.BackColor = System.Drawing.Color.Red;
            this.ObrisiSve.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObrisiSve.Location = new System.Drawing.Point(674, 53);
            this.ObrisiSve.Name = "ObrisiSve";
            this.ObrisiSve.Size = new System.Drawing.Size(111, 63);
            this.ObrisiSve.TabIndex = 0;
            this.ObrisiSve.Text = "Obrisi Sve";
            this.ObrisiSve.UseVisualStyleBackColor = false;
            this.ObrisiSve.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gumica
            // 
            this.Gumica.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumica.Location = new System.Drawing.Point(674, 9);
            this.Gumica.Name = "Gumica";
            this.Gumica.Size = new System.Drawing.Size(111, 35);
            this.Gumica.TabIndex = 3;
            this.Gumica.Text = "Gumica";
            this.Gumica.UseVisualStyleBackColor = true;
            this.Gumica.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(895, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Pravougaonik
            // 
            this.Pravougaonik.AutoSize = true;
            this.Pravougaonik.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pravougaonik.Location = new System.Drawing.Point(12, 12);
            this.Pravougaonik.Name = "Pravougaonik";
            this.Pravougaonik.Size = new System.Drawing.Size(117, 27);
            this.Pravougaonik.TabIndex = 8;
            this.Pravougaonik.TabStop = true;
            this.Pravougaonik.Text = "Pravougaonik";
            this.Pravougaonik.UseVisualStyleBackColor = true;
            this.Pravougaonik.CheckedChanged += new System.EventHandler(this.RBpravougaonik_CheckedChanged);
            // 
            // Elipsa
            // 
            this.Elipsa.AutoSize = true;
            this.Elipsa.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Elipsa.Location = new System.Drawing.Point(12, 43);
            this.Elipsa.Name = "Elipsa";
            this.Elipsa.Size = new System.Drawing.Size(66, 27);
            this.Elipsa.TabIndex = 9;
            this.Elipsa.TabStop = true;
            this.Elipsa.Text = "Elipsa";
            this.Elipsa.UseVisualStyleBackColor = true;
            this.Elipsa.CheckedChanged += new System.EventHandler(this.RBelipsa_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.BojaPozadine);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Boja);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Zvezda);
            this.groupBox1.Controls.Add(this.Srce);
            this.groupBox1.Controls.Add(this.Smajli);
            this.groupBox1.Controls.Add(this.Vatromet);
            this.groupBox1.Controls.Add(this.PravaLinija);
            this.groupBox1.Controls.Add(this.Popunjenost);
            this.groupBox1.Controls.Add(this.RbOlovka);
            this.groupBox1.Controls.Add(this.Pravougaonik);
            this.groupBox1.Controls.Add(this.Elipsa);
            this.groupBox1.Location = new System.Drawing.Point(0, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 107);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\\";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(600, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 20);
            this.textBox2.TabIndex = 18;
            // 
            // BojaPozadine
            // 
            this.BojaPozadine.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BojaPozadine.Location = new System.Drawing.Point(497, 11);
            this.BojaPozadine.Name = "BojaPozadine";
            this.BojaPozadine.Size = new System.Drawing.Size(148, 28);
            this.BojaPozadine.TabIndex = 17;
            this.BojaPozadine.Text = "Boja pozadine";
            this.BojaPozadine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BojaPozadine.UseVisualStyleBackColor = true;
            this.BojaPozadine.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Zvezda
            // 
            this.Zvezda.AutoSize = true;
            this.Zvezda.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zvezda.Location = new System.Drawing.Point(304, 76);
            this.Zvezda.Name = "Zvezda";
            this.Zvezda.Size = new System.Drawing.Size(76, 27);
            this.Zvezda.TabIndex = 16;
            this.Zvezda.TabStop = true;
            this.Zvezda.Text = "Zvezda";
            this.Zvezda.UseVisualStyleBackColor = true;
            // 
            // Srce
            // 
            this.Srce.AutoSize = true;
            this.Srce.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Srce.Location = new System.Drawing.Point(304, 43);
            this.Srce.Name = "Srce";
            this.Srce.Size = new System.Drawing.Size(57, 27);
            this.Srce.TabIndex = 15;
            this.Srce.TabStop = true;
            this.Srce.Text = "Srce";
            this.Srce.UseVisualStyleBackColor = true;
            // 
            // Smajli
            // 
            this.Smajli.AutoSize = true;
            this.Smajli.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Smajli.Location = new System.Drawing.Point(304, 12);
            this.Smajli.Name = "Smajli";
            this.Smajli.Size = new System.Drawing.Size(69, 27);
            this.Smajli.TabIndex = 12;
            this.Smajli.TabStop = true;
            this.Smajli.Text = "Smajli";
            this.Smajli.UseVisualStyleBackColor = true;
            this.Smajli.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // Vatromet
            // 
            this.Vatromet.AutoSize = true;
            this.Vatromet.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Vatromet.Location = new System.Drawing.Point(172, 76);
            this.Vatromet.Name = "Vatromet";
            this.Vatromet.Size = new System.Drawing.Size(91, 27);
            this.Vatromet.TabIndex = 12;
            this.Vatromet.TabStop = true;
            this.Vatromet.Text = "Vatromet";
            this.Vatromet.UseVisualStyleBackColor = true;
            this.Vatromet.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // PravaLinija
            // 
            this.PravaLinija.AutoSize = true;
            this.PravaLinija.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PravaLinija.Location = new System.Drawing.Point(172, 43);
            this.PravaLinija.Name = "PravaLinija";
            this.PravaLinija.Size = new System.Drawing.Size(105, 27);
            this.PravaLinija.TabIndex = 12;
            this.PravaLinija.TabStop = true;
            this.PravaLinija.Text = "Prava linija";
            this.PravaLinija.UseVisualStyleBackColor = true;
            this.PravaLinija.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Popunjenost
            // 
            this.Popunjenost.AutoSize = true;
            this.Popunjenost.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Popunjenost.Location = new System.Drawing.Point(12, 76);
            this.Popunjenost.Name = "Popunjenost";
            this.Popunjenost.Size = new System.Drawing.Size(108, 27);
            this.Popunjenost.TabIndex = 11;
            this.Popunjenost.Text = "Popunjenost";
            this.Popunjenost.UseVisualStyleBackColor = true;
            // 
            // RbOlovka
            // 
            this.RbOlovka.AutoSize = true;
            this.RbOlovka.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RbOlovka.Location = new System.Drawing.Point(172, 12);
            this.RbOlovka.Name = "RbOlovka";
            this.RbOlovka.Size = new System.Drawing.Size(72, 27);
            this.RbOlovka.TabIndex = 10;
            this.RbOlovka.TabStop = true;
            this.RbOlovka.Text = "Olovka";
            this.RbOlovka.UseVisualStyleBackColor = true;
            this.RbOlovka.CheckedChanged += new System.EventHandler(this.RBolovka_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(814, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Velicina";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(814, 40);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(158, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Value = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // SlikaSaRacunara
            // 
            this.SlikaSaRacunara.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SlikaSaRacunara.Location = new System.Drawing.Point(814, 81);
            this.SlikaSaRacunara.Name = "SlikaSaRacunara";
            this.SlikaSaRacunara.Size = new System.Drawing.Size(158, 35);
            this.SlikaSaRacunara.TabIndex = 17;
            this.SlikaSaRacunara.Text = "Slika sa racunara";
            this.SlikaSaRacunara.UseVisualStyleBackColor = true;
            this.SlikaSaRacunara.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.SlikaSaRacunara);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Gumica);
            this.Controls.Add(this.ObrisiSve);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Bojanka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Boja;
        private System.Windows.Forms.Button ObrisiSve;
        private System.Windows.Forms.Button Gumica;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Pravougaonik;
        private System.Windows.Forms.RadioButton Elipsa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Popunjenost;
        private System.Windows.Forms.RadioButton RbOlovka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PravaLinija;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton Vatromet;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.RadioButton Smajli;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton Smajli1;
        private System.Windows.Forms.RadioButton Smajli2;
        private System.Windows.Forms.RadioButton Smajli3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Srce;
        private System.Windows.Forms.RadioButton Zvezda;
        private System.Windows.Forms.Button SlikaSaRacunara;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BojaPozadine;
    }
}

