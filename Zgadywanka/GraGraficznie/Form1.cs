using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;


namespace GraGraficznie
{
    public partial class Form1 : Form
    {
        private Gra g;
        private Ruch r;

        public Form1()
        {
            InitializeComponent();
        }
        // Button Nowa gra
        private void button1_Click(object sender, EventArgs e)
        {

            groupBoxLosowanie.Visible = true;
            ButtonNowaGra.Enabled = false;
            buttonPrzerwij.Visible = true;
        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {

            int a = int.Parse(textBoxZakresOd.Text);
            int b = int.Parse(textBoxZakresDo.Text);

            g = new Gra(a, b);
            
            // Wypisz komunikat zeby odgadyewac

            labelKomunikat1.Text = $"Wylosowano liczbę od {a} do {b}";
            groupBoxLosowanie.Enabled = false;
            groupBoxPropozycja.Visible = true;
            buttonZatwierdz.Enabled = true;
            textBoxPropozycja.Enabled = true;


        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPropozycja.Text);
           var odp =  g.Odpowiedz(propozycja);
            //int wylosowana = (string)g.Wylosowana;
            //TimeSpan span = Ruch(int prop, Odp odp);


            switch ( odp )
            {
                case Odp.ZaMalo:
                    labelOdpowiedz.ForeColor = Color.Red;
                    labelOdpowiedz.Text = "Za Mało";
                    break;
                case Odp.ZaDuzo:
                    labelOdpowiedz.ForeColor = Color.Red;
                    labelOdpowiedz.Text = "Za Dało";
                    break;
                case Odp.Trafiono:
                    labelOdpowiedz.ForeColor = Color.Green;
                    labelOdpowiedz.Text = "Trafiono";
                    buttonZatwierdz.Enabled = false;
                    textBoxPropozycja.Enabled = false;
                    buttonGraOdNowa.Visible = true;
                    //labelWylosowana. = wylosowana;
                   // labelCzasGry.Text = $"{TimeSpan()}";
                    break;
            }
        }

        private void textBoxZakresOd_TextChanged(object sender, EventArgs e)
        {
            int wynik;
            if(int.TryParse(textBoxZakresOd.Text, out wynik))
            {
                textBoxZakresOd.BackColor = Color.LightGreen;
                buttonWylosuj.Enabled = true;
            }
            else
            {
                textBoxZakresOd.BackColor = Color.PaleVioletRed;
                buttonWylosuj.Enabled = false;
            }
               


        }

        private void textBoxZakresDo_TextChanged(object sender, EventArgs e)
        {
            int wynik;
            if(int.TryParse(textBoxZakresDo.Text, out wynik))
            {
                textBoxZakresDo.BackColor = Color.LightGreen;
                buttonWylosuj.Enabled = true;
            }
            else
            {
                textBoxZakresDo.BackColor = Color.PaleVioletRed;
                buttonWylosuj.Enabled = false;
            }

        }

        private void labelCzasGry_Click(object sender, EventArgs e)
        {

        }

        private void buttonGraOdNowa_Click(object sender, EventArgs e)
        {
            groupBoxPropozycja.Visible = false;
            ButtonNowaGra.Enabled = true;
            groupBoxLosowanie.Enabled = true;
        }

        private void buttonPrzerwij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {

        }
    }
}
