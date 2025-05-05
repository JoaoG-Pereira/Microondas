using Microondas.Modelos;
using Microondas.Regras_de_negócio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas.Interfaces
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void EntrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(UsuarioTextBox.Text, SenhaTextBox.Text);
                await UsuariosBLL.FazerLogin(usuario);
                MessageBox.Show("Login realizado com sucesso!");
                Close();
            }
            catch
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }
    }
}
