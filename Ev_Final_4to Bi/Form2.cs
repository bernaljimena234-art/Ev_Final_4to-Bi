using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ev_Final_4to_Bi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(TextVar1.Text);
            int n2 = int.Parse(TextVar1.Text);
            int n3 = 1;
            int Producto = 1;

            while (n3 != n2)
            {
                Producto = Producto * n1;
                n3 = n3 + 1;
            }
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar1.Text);
            int suma = Num1 + Num2;

            MessageBox.Show("El Resultado de la Suma es" + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(TextVar1.Text);
            int n2 = int.Parse(TextVar1.Text);
            int n3 = 1;
            int Potencia = 1;

            while (n3 != n2)
            {
                Potencia = Potencia * n1;
                n3 = n3 + 1;
            }
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextVar1.Text);
            float Num2 = float.Parse(TextVar1.Text);

            if (Num2 > 0)

            {
                float division = Num1 / Num2;
                MessageBox.Show("La Division es idefinidad");
            }
        }
    }
}

