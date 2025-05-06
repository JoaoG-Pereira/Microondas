using Microondas.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Microondas
{
    public partial class MicroondasForm : Form
    {
        private readonly Microondas objMicroondas = new Microondas();
        private List<Alimento> listaAlimentos;

        private bool potenciaSelecionada = false;

        public MicroondasForm()
        {
            InitializeComponent();
            //CarregarProgramasSalvos();

            objMicroondas.timerMicroondas.Interval = 1000;
            objMicroondas.timerMicroondas.Tick += AtualizarTextBoxes;

            /*Alimento alimento = new Alimento
            {
                id = -1,
                nome = "Leite",
                alimento = "Leite",
                tempo = TimeSpan.FromSeconds(45),
                potencia = 5,
                instrucoes = "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode\r\ncausar fervura imediata causando risco de queimaduras"
            };
            ProgramasBLL.CriarPrograma( alimento );*/
            
        }

        private async void CarregarProgramasSalvos()
        {
            try
            {
                listaAlimentos = (await ProgramasBLL.ListarProgramas()).ToList();

                foreach (Alimento alimento in listaAlimentos)
                {
                    UserControlPrograma userControlPrograma = new UserControlPrograma(alimento);
                    AdicionarPrograma(userControlPrograma);
                }
            }
            catch
            {
                MessageBox.Show("Erro a carregar programas de aquecimento");
            }
        }

        private void AdicionarPrograma(UserControlPrograma userControlPrograma)
        {
            FlowLayoutPanelProgramas.Controls.Add(userControlPrograma);
            userControlPrograma.FoiDeletado += RemoverPrograma;
            userControlPrograma.FoiSalvo += DesbloquearBotoes;
            userControlPrograma.FoiSelecionado += IniciarAquecimento;
        }

        private void RemoverPrograma(object sender, EventArgs e)
        {
            UserControlPrograma userControlPrograma = sender as UserControlPrograma;
            FlowLayoutPanelProgramas.Controls.Remove(userControlPrograma);
            userControlPrograma.FoiDeletado -= RemoverPrograma;
            userControlPrograma.FoiSalvo -= DesbloquearBotoes;
            userControlPrograma.FoiSelecionado -= IniciarAquecimento;
            AdicionarButton.Enabled = true;
        }

        private void DesbloquearBotoes(object sender, EventArgs e)
        {
            AdicionarButton.Enabled = true;
        }

        private void BotaoIniciar_Click(object sender, EventArgs e)
        {
            if (objMicroondas.estaLigado)
            {
                objMicroondas.AdicionarTempo(30);
            }
            else if (potenciaSelecionada)
            {

            }
            else
            {
                if (objMicroondas.tempo == 0) LerTextBoxes();
                objMicroondas.IniciarAquecimento();
            }
            AtualizarTextBoxes();
        }

        private void IniciarAquecimento(object sender, EventArgs e)
        {
            UserControlPrograma userControlPrograma = sender as UserControlPrograma;
            objMicroondas.ConfigurarAquecimento(userControlPrograma.alimento);
            AtualizarPotenciaTempo();
        }

        private void BotaoParar_Click(object sender, EventArgs e)
        {
            objMicroondas.PararAquecimento();
            AtualizarTextBoxes();
        }

        private void LerTextBoxes()
        {
            int tempo;
            try
            {
                tempo = (int)TimeSpan.ParseExact(TempoTextBox.Text, @"mm\:ss", CultureInfo.InvariantCulture).TotalSeconds;
            }
            catch
            {
                MessageBox.Show("Tempo inserido inválido");
                TempoTextBox.Clear();
                return;
            }
            int potencia = Convert.ToInt32(PotenciaTextBox.Text.Substring(0, 2));
            objMicroondas.ConfigurarAquecimento(tempo, potencia);
        }

        private void AtualizarTextBoxes(object sender, EventArgs e)
        {
            AtualizarTextBoxes();
        }

        private void AtualizarTextBoxes()
        {
            AtualizarPotenciaTempo();

            //String informativa
            if (!objMicroondas.estaLigado & objMicroondas.tempo == 0)
            {
                InfoTextBox.Clear();
            }
            if (objMicroondas.tempo > 0)
            {
                for (int i = 0; i < objMicroondas.potencia; i++)
                {
                    InfoTextBox.Text += ".";
                }
                InfoTextBox.Text += " ";
                PanelCentral.BackColor = Color.LightYellow;
            }
            else
            {
                InfoTextBox.Text += "Aquecimento concluído";
                PanelCentral.BackColor = Color.Gainsboro;
            }
        }

        private void AtualizarPotenciaTempo()
        {
            TempoTextBox.Text = TimeSpan.FromSeconds(objMicroondas.tempo).ToString(@"mm\:ss");
            PotenciaTextBox.Text = objMicroondas.potencia.ToString("00") + " kW";
            TempoTextBox.Enabled = !objMicroondas.estaLigado & !potenciaSelecionada;
            PotenciaTextBox.Enabled = !objMicroondas.estaLigado & potenciaSelecionada;
        }

        private void InserirNumero(int numero)
        {
            if (numero > 9) throw new Exception();
            if (potenciaSelecionada)
            {
                PotenciaTextBox.Text = PotenciaTextBox.Text.Remove(0, 1) + numero.ToString();
            }
            else
            {
                TempoTextBox.Text = TempoTextBox.Text.Remove(0, 1) + numero.ToString();
            }
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            InserirNumero(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InserirNumero(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InserirNumero(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            InserirNumero(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InserirNumero(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            InserirNumero(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InserirNumero(6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            InserirNumero(7);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            InserirNumero(8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            InserirNumero(9);
        }

        private void BotaoPotencia_Click(object sender, EventArgs e)
        {
            //Alterna o teclado digital entre o timer e a potência
            potenciaSelecionada = !potenciaSelecionada;
            PotenciaTextBox.Enabled = potenciaSelecionada;
            TempoTextBox.Enabled = !potenciaSelecionada;
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            UserControlPrograma userControlPrograma = new UserControlPrograma();
            AdicionarPrograma(userControlPrograma);
            AdicionarButton.Enabled = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            FazerLogin();
        }

        private void LoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FazerLogin();
        }

        private void FazerLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (Configuracoes.USUARIO_LOGADO == null) return;

            CarregarProgramasSalvos();
            AdicionarButton.Enabled = true;
            LoginButton.Enabled = false;
            LoginLabel.Enabled = false;
            LoginLabel.Visible = false;
            LoginButton.Text = Configuracoes.USUARIO_LOGADO.nome;
        }
    }
}
