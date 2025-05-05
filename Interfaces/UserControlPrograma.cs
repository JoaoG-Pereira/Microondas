using System.Globalization;
using System;
using System.Windows.Forms;

namespace Microondas
{
    public partial class UserControlPrograma : UserControl
    {
        public readonly Alimento alimento;
        public event EventHandler FoiDeletado;
        public event EventHandler FoiSalvo;
        public event EventHandler FoiSelecionado;

        public UserControlPrograma()
        {
            InitializeComponent();
            DesbloquearCampos();
            alimento = new Alimento { id = -1 };
        }

        public UserControlPrograma(Alimento alimento)
        {
            InitializeComponent();
            BloquearCampos();
            this.alimento = alimento;
            NomeTextBox.Text = alimento.nome;
            AlimentoTextBox.Text = alimento.alimento;
            TempoMaskedTextBox.Text = alimento.tempo.ToString(@"mm\:ss");
            PotenciaMaskedTextBox.Text = alimento.potencia.ToString("00") + " kW";
            InstrucoesTextBox.Text = alimento.instrucoes;
        }

        private void UserControlPrograma_Load(object sender, EventArgs e)
        {
            if (alimento.id == -1) NomeTextBox.Focus();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            DesbloquearCampos();
            NomeTextBox.Focus();
        }

        private async void SalvarButton_Click(object sender, EventArgs e)
        {
            try {
                LerCampos();

                if (alimento.id == -1)
                    alimento.id = (await ProgramasBLL.CriarPrograma(alimento)).id;
                else
                    await ProgramasBLL.EditarPrograma(alimento);

                BloquearCampos();
                FoiSalvo.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o programa " + alimento.nome + " : " + ex.Message);
            }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (alimento.id != -1) ProgramasBLL.DeletarPrograma(alimento.id);
                FoiDeletado.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o programa " + alimento.nome + " : " + ex.Message);
            }
        }

        private void BloquearCampos()
        {
            NomeTextBox.Enabled = false;
            AlimentoTextBox.Enabled = false;
            TempoMaskedTextBox.Enabled = false;
            PotenciaMaskedTextBox.Enabled = false;
            InstrucoesTextBox.Enabled = false;

            SalvarButton.Enabled = false;
            ExcluirButton.Enabled = false;
            EditarButton.Enabled = true;
        }

        private void DesbloquearCampos()
        {
            NomeTextBox.Enabled = true;
            AlimentoTextBox.Enabled = true;
            TempoMaskedTextBox.Enabled = true;
            PotenciaMaskedTextBox.Enabled = true;
            InstrucoesTextBox.Enabled = true;

            SalvarButton.Enabled = true;
            ExcluirButton.Enabled = true;
            EditarButton.Enabled = false;
        }

        private void LerCampos()
        {
            try
            {
                alimento.nome = NomeTextBox.Text;
                alimento.alimento = AlimentoTextBox.Text;
                alimento.tempo = TimeSpan.ParseExact(TempoMaskedTextBox.Text, @"mm\:ss", CultureInfo.InvariantCulture);
                alimento.potencia = Convert.ToInt32(PotenciaMaskedTextBox.Text.Substring(0, 2).Trim());
                alimento.instrucoes = InstrucoesTextBox.Text;
            }
            catch (Exception ex) {
                throw new Exception("Erro ao gravar os campos: " +ex.Message);
            }
         }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            FoiSelecionado.Invoke(this, EventArgs.Empty);
        }
    }
}
