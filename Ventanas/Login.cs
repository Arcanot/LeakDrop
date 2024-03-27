using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor.Ventanas
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != "") && (txtContraseña.Text != ""))
            {
                if (txtUsuario.Text == "admin" && txtContraseña.Text == "123")
                {
                    Principal Prin = new Principal();
                    Prin.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
