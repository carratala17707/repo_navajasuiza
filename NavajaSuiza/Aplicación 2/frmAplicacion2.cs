using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_2
{
    public partial class frmAplicacion2 : Form
    {
        public frmAplicacion2()
        {
            InitializeComponent();
        }

        bool Validar(int numero)
        {
            bool valido;

            valido = false;

            if (numero >= 1 && numero <= 100)
            {
                valido = true;
            }
            return valido;
        }

        string SerieMultiplos(int numero)
        {
            string texto;
            int i;

            texto = "";
            i = 1;

            for (i = 1; i <= numero; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    texto = texto + i + ", ";
                }
            }
            return texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            string texto;
            bool valido;

            numero = int.Parse(textBox1.Text);
            valido = true;

            valido = Validar(numero);

            if (valido == false)
            {
                MessageBox.Show("Introduzca otro número.");
            }
            else
            {
                texto = SerieMultiplos(numero);
                MessageBox.Show(texto);
            }
        }
    }
}
