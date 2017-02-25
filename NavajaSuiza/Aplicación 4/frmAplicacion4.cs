using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_4
{
    public partial class frmAplicacion4 : Form
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

        public frmAplicacion4()
        {
            InitializeComponent();
        }

        const int kTAM = 10;
        int[] vectorLeido = new int[kTAM];
        int[] vectorAlReves = new int[kTAM];

        void LeerVector(int[] vector)
        {
            for (int i = 0; i < kTAM; i++)
            {
                vector[i] = int.Parse(InputBox("Introduzca el elemento: " + i));
            }
        }

        void VectorReves(int[] vectorLeido)
        {
            int j = vectorLeido.Length - 1;

            for (int i = 0; i < vectorLeido.Length; i++)
            {
                vectorAlReves[j] = vectorLeido[i];
                j--;
            }
        }
        
        string MostrarVectorReves(int[] vectorAlReves)
        {
            string texto = "";

            for (int i = 0; i < kTAM; i++)
            {
                texto = texto + vectorAlReves[i] + ", ";
            }
            return texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto;

            LeerVector(vectorLeido);
            VectorReves(vectorLeido);
            texto = MostrarVectorReves(vectorAlReves);

            MessageBox.Show(texto);
        }
    }
}
