using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4to_Bi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "dominga" && textUsuario.Text == "40")
            {
                this.Hide();
                Form1 app = new Form1();
                app.Show();
            }
            else
            {
                MessageBox.Show("sus datos son Invalidos porfavor intente de nuevo");
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
