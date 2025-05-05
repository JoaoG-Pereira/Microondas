using Microondas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Microondas
{
    public class Microondas
    {
        private Alimento alimentoSelecionado;
        public bool estaLigado = false;
        public int tempo = 0;
        public int potencia = 10;
        public readonly Timer timerMicroondas = new Timer();

        
        public Microondas()
        {
            timerMicroondas.Tick += CronometrarTempo;
        }

        public void ConfigurarAquecimento(int segundos, int potencia)
        {
            segundos = segundos == 0 ? 30 : segundos;
            potencia = potencia == 0 ? 10 : potencia;
            ValidarParametros(segundos, potencia);

            this.tempo = segundos;
            this.potencia = potencia;
        }

        public void ConfigurarAquecimento(Alimento alimento)
        {
            alimentoSelecionado = alimento;
            ConfigurarAquecimento((int)alimento.tempo.TotalSeconds, alimento.potencia);
        }

        public void IniciarAquecimento()
        {
            if (estaLigado)
            {
                AdicionarTempo(30);
                return;
            }

            timerMicroondas.Start();
            estaLigado = true;
        }


        public void PararAquecimento()
        {
            if (estaLigado)
            {
                timerMicroondas.Stop();
                estaLigado = false;
            }
            else {
                tempo = 0;
                alimentoSelecionado = null;
            }
        }

        public void AdicionarTempo(int segundos)
        {
            if (alimentoSelecionado != null) return;
            tempo += segundos;
        }

        private void CronometrarTempo(object sender, EventArgs e)
        {
            if (tempo <= 0)
            {
                timerMicroondas.Stop();
                estaLigado = false;
                alimentoSelecionado = null;
            }
            else tempo--;
        }

        //Limite de tempo aumentado para 20 minutos ao invés de 2
        //Caso contrário, os programas definidos na etapa 2 gerariam erro
        private void ValidarParametros(int segundos, double potencia)
        {
            if (segundos <= 0) throw new ParametroInvalidoException("O tempo informado deve ser de pelo menos 1 segundo");
            if (segundos > 1200) throw new ParametroInvalidoException("O tempo informado deve ser de no máximo 2 minutos");
            if (potencia <= 0) throw new ParametroInvalidoException("A potência deve ser de no mínimo 1kW");
            if (potencia > 10) throw new ParametroInvalidoException("A potência deve ser de no máximo 10kW");
        }

    }
}
