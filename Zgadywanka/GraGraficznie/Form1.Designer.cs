namespace GraGraficznie
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
            this.ButtonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.groupBoxPropozycja = new System.Windows.Forms.GroupBox();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLiczbaRuchow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWylosowana = new System.Windows.Forms.Label();
            this.labelCzasGry = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxPropozycja.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNowaGra
            // 
            this.ButtonNowaGra.Location = new System.Drawing.Point(31, 43);
            this.ButtonNowaGra.Name = "ButtonNowaGra";
            this.ButtonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.ButtonNowaGra.TabIndex = 0;
            this.ButtonNowaGra.Text = "Nowa Gra";
            this.ButtonNowaGra.UseVisualStyleBackColor = true;
            this.ButtonNowaGra.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresOd);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(31, 107);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(259, 161);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(15, 30);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(58, 13);
            this.labelZakresOd.TabIndex = 0;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(98, 30);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresOd.TabIndex = 1;
            this.textBoxZakresOd.TextChanged += new System.EventHandler(this.textBoxZakresOd_TextChanged);
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(15, 71);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(58, 13);
            this.labelZakresDo.TabIndex = 2;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(98, 71);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresDo.TabIndex = 3;
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(123, 110);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Location = new System.Drawing.Point(215, 43);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzerwij.TabIndex = 2;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Visible = false;
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(31, 275);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(0, 13);
            this.labelKomunikat1.TabIndex = 3;
            // 
            // groupBoxPropozycja
            // 
            this.groupBoxPropozycja.Controls.Add(this.buttonZatwierdz);
            this.groupBoxPropozycja.Controls.Add(this.textBoxPropozycja);
            this.groupBoxPropozycja.Controls.Add(this.labelOdpowiedz);
            this.groupBoxPropozycja.Location = new System.Drawing.Point(31, 307);
            this.groupBoxPropozycja.Name = "groupBoxPropozycja";
            this.groupBoxPropozycja.Size = new System.Drawing.Size(259, 109);
            this.groupBoxPropozycja.TabIndex = 4;
            this.groupBoxPropozycja.TabStop = false;
            this.groupBoxPropozycja.Text = "Twoja Propozycja";
            this.groupBoxPropozycja.Visible = false;
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(28, 72);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(46, 13);
            this.labelOdpowiedz.TabIndex = 0;
            this.labelOdpowiedz.Text = "Trafiono";
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(31, 31);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropozycja.TabIndex = 1;
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Location = new System.Drawing.Point(162, 28);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(75, 23);
            this.buttonZatwierdz.TabIndex = 2;
            this.buttonZatwierdz.Text = "Zatwierdz";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // labelLiczbaRuchow
            // 
            this.labelLiczbaRuchow.AutoSize = true;
            this.labelLiczbaRuchow.Location = new System.Drawing.Point(31, 459);
            this.labelLiczbaRuchow.Name = "labelLiczbaRuchow";
            this.labelLiczbaRuchow.Size = new System.Drawing.Size(35, 13);
            this.labelLiczbaRuchow.TabIndex = 5;
            this.labelLiczbaRuchow.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label1";
            // 
            // labelWylosowana
            // 
            this.labelWylosowana.AutoSize = true;
            this.labelWylosowana.Location = new System.Drawing.Point(31, 488);
            this.labelWylosowana.Name = "labelWylosowana";
            this.labelWylosowana.Size = new System.Drawing.Size(35, 13);
            this.labelWylosowana.TabIndex = 5;
            this.labelWylosowana.Text = "label1";
            // 
            // labelCzasGry
            // 
            this.labelCzasGry.AutoSize = true;
            this.labelCzasGry.Location = new System.Drawing.Point(31, 433);
            this.labelCzasGry.Name = "labelCzasGry";
            this.labelCzasGry.Size = new System.Drawing.Size(35, 13);
            this.labelCzasGry.TabIndex = 5;
            this.labelCzasGry.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 545);
            this.Controls.Add(this.labelWylosowana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLiczbaRuchow);
            this.Controls.Add(this.labelCzasGry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPropozycja);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonPrzerwij);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.ButtonNowaGra);
            this.Name = "Form1";
            this.Text = "Zgadywanka";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxPropozycja.ResumeLayout(false);
            this.groupBoxPropozycja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.GroupBox groupBoxPropozycja;
        private System.Windows.Forms.Button buttonZatwierdz;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLiczbaRuchow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWylosowana;
        private System.Windows.Forms.Label labelCzasGry;
    }
}

