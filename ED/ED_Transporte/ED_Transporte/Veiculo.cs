using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ED_Transporte
{
    class Veiculo
    {
        private int placa;
        private int lotacao;
        private string nome_motorista;
        private List<Viagem> viagens;
        private Timer tempoEspera;

        public int Placa { get => placa; set => placa = value; }
        public int Lotacao { get => lotacao; set => lotacao = value; }
        public string Nome_motorista { get => nome_motorista; set => nome_motorista = value; }
        internal List<Viagem> Viagens { get => viagens; set => viagens = value; }
        public Timer TempoEspera { get => tempoEspera; set => tempoEspera = value; }

        public Veiculo()
        {
            Placa = -1;
        }

        public Veiculo(int placa)
        {
            Placa = placa;
        }

        public Veiculo(int placa, int lotacao, string nome_motorista)
        {
            Placa = placa;
            Lotacao = lotacao;
            Nome_motorista = nome_motorista;
            Viagens = new List<Viagem>();
        }

        public bool liberarSaida(int qtd)
        {
            bool podeSair = true;
            if(qtd < Lotacao)
            {
                podeSair = false;
                return podeSair;
            }

            return podeSair;
        }

        public double calculaJornada()
        {
            double totalGanho = 0;
            foreach(Viagem viagem in Viagens)
            {
                foreach(Visitante visitante in viagem.Visitantes)
                {
                    totalGanho += 5;
                }
            }
            return totalGanho;
        }

        public override bool Equals(object obj)
        {
            return Placa.Equals(((Veiculo)obj).Placa);
        }

    }
}
