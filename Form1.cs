using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Heroe1=new Heroe();

            Heroe1.Nombre = "Superman";
            Heroe1.Poder = "Volar";

            var Heroe2 = new Heroe();

            Heroe2.Nombre = "Flash";
            Heroe2.Poder = "Super Velocidad";

            var Heroe3 = new Heroe();

            Heroe3.Nombre = "Hulk";
            Heroe3.Poder = "Super Fuerza";



        }

        private void button2_Click(object sender, EventArgs e)
        {

            var Villano1 = new Villano();

            Villano1.Nombre = "Guason";
            Villano1.Poder = "Astucia";

            var Villano2 = new Villano();

            Villano2.Nombre = "Lex Luthor";
            Villano2.Poder = "Dinero y inteligencia";

            var Villano3 = new Villano();

            Villano3.Nombre = "Zoom";
            Villano3.Poder = "Velocidad";


        }
    }
}
