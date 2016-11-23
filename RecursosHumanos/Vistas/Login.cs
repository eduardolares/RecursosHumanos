using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanos.Modelo;

namespace RecursosHumanos.Vistas
{
    public partial class Login : Form
    {

        _Login login = new _Login();
        string usu;
        string pas;
        bool flag;

        public Login()
        {
            InitializeComponent();
            _TextBoxPass.PasswordChar = '*';
            login.login();
        }

        private void _ButtonAcceser_Click(object sender, EventArgs e)
        {


            foreach (DataRow r in login.dt_login.Rows)
            {
                usu = r["Usuario"].ToString();
                pas = r["Password"].ToString();
                if (_TextBoxUsuario.Text == usu && _TextBoxPass.Text == pas)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }

            }

            if(flag == true)
            {
                MessageBox.Show("Bienvenido");
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                MessageBox.Show("Error: Usuario o Contrase;a incorrectos");
            }


        }

        private void _ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _TextBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                foreach (DataRow r in login.dt_login.Rows)
                {
                    usu = r["Usuario"].ToString();
                    pas = r["Password"].ToString();
                    if (_TextBoxUsuario.Text == usu && _TextBoxPass.Text == pas)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }

                }

                if (flag == true)
                {
                    MessageBox.Show("Bienvenido");
                    DialogResult = DialogResult.Yes;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error: Usuario o Contrase;a incorrectos");
                }
            }
        }
    }
}
