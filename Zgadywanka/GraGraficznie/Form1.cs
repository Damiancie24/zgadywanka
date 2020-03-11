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

            g = new Gra();
            // Wypisz komunikat zeby odgadyewac

            labelKomunikat1.Text = $"Wylosowano liczbę od {a} do {b}";
            groupBoxLosowanie.Enabled = false;

            groupBoxPropozycja.Visible = true;


        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPropozycja.Text);
           var odp =  g.Odpowiedz(propozycja);

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
                    groupBoxPropozycja.Enabled = false;
                    ButtonNowaGra.Enabled = true;
                    
                    break;
            }
        }

        private void textBoxZakresOd_TextChanged(object sender, EventArgs e)
        {
            int wynik = 0;
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
    }
}
