using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2_dummy
{
    public partial class Form1 : Form
    {
        //Creo a mi jugador
        //Jugador jugadorAct = new Jugador();

        //variables principales
        int plata, level, life = 0;
        Gerentes[] gerentes = new Gerentes[8];
        Seguros[] seguros = new Seguros[8];

        //creo punteros
        int i, j;

        //inicio los form auxiliares
        Revisiones FormRev = new Revisiones();
        Preguntas FormPreg = new Preguntas();

        //variable auxiliar
        //static int plata_aux { get; set; }

        public Form1()
        {
            InitializeComponent();

            // buscar en BDJugador
            Jugador.plata = 1000;
            plata = 1000;
            lblPlata.Text = "1000";
            Jugador.nivel = 1;
            Jugador.experiencia = 0;
            Jugador.enojos = 0;
            lblVida.Text = "0";
            lblLevel.Text = "0";

        }

        static public void refresh()
        {
        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(MessageBox.Show("Hacemos una prueba visual", "Prueba", MessageBoxButtons.OKCancel)) == "OK")
            {
                plata = +1000;
                lblPlata.Text = Convert.ToString(plata);
            }
            else {
                MessageBox.Show("Aca se gana enojos si erra?");
            }
            Random indexRandmon = new Random();
            MessageBox.Show("Elijo un un valor random "+Convert.ToString(indexRandmon.Next(1, 100)+" y veo si sale un hecho favorable y/o adverso"));

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (gerentes[1] != null)
            {
            }
            else
            {
                gerentes[1] = new Gerentes(lblGer2.Text);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Jugador.plata != plata)
            {
                plata = Jugador.plata;
                lblPlata.Text = Convert.ToString(Jugador.plata);
            }
        }

        private void BtnUpSeg1_Click(object sender, EventArgs e)
        {
            if (gerentes[0] != null) {
                gerentes[0].aumentarNivel();
            }
            else {
                gerentes[0] = new Gerentes(lblGer1.Text);

            }
        }



        private void BtnPregunta_Click(object sender, EventArgs e)
        {
            FormPreg.next();
            FormPreg.ShowDialog();
        }
    }
}
