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
    public partial class Preguntas : Form
    {
        //Jugador jugadorAux = new Jugador();
        public Preguntas()
        {
            InitializeComponent();
        }

        public void next()
        {
            //pedir nueva pregunta de la BD
            
        }

        private void BtnOp1_Click(object sender, EventArgs e)
        {
            //evaluar si la respuesta es la correcta
            //si/no lo es dispara un evento positivo/negativo

            //suma/resta plata al Jugador
            Jugador.plata = Jugador.plata + 100;
            //Actualizar BDJugador
            
            //oculta form

            this.Hide();
        }
    }
}
