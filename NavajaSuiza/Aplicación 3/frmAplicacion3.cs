using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_3
{
    public partial class frmAplicacion3 : Form
    {
        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        public frmAplicacion3()
        {
            InitializeComponent();
        }

        const int kTAM = 10;
        int[] vector = new int[kTAM];

        void LeerVector(int[] vector)
        {
            for (int i = 0; i < kTAM; i++)
            {
                vector[i] = int.Parse(InputBox("Introduce el elemento: " + i));
            }
        }

        int VectorRepetido(int[] vector)
        {
            int contador = 0;

            for (int i = 0; i < kTAM; i++)
            {
                if (vector[i] != -1)
                {
                    for (int j = i + 1; j < vector.Length; j++)
                    {
                        if (vector[i] == vector[j])
                        {
                            vector[j] = -1;
                            contador++;
                        }
                    }
                }
            }
            return contador;
        }

        string MostrarVector(int[] vector)
        {
            string texto = "";

            for (int i = 0; i < kTAM; i++)
            {
                texto = texto + vector[i] + ", ";
            }
            return texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto;
            int contador;

            LeerVector(vector);
            contador = VectorRepetido(vector);
            texto = MostrarVector(vector);

            MessageBox.Show(texto + " el número de valores modificados es: " + contador);
        }
    }
}
