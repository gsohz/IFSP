using System;
using System.Collections.Generic;
using System.Text;

namespace ED_TRANSPORTE_2
{
    class Van
    {
        private int placa;
        private int lotacao;
        private string nomeMotorista;
        private List<Viagem> viagens;

        public int Placa { get => placa; set => placa = value; }
        public int Lotacao { get => lotacao; set => lotacao = value; }
        public string NomeMotorista { get => nomeMotorista; set => nomeMotorista = value; }
        internal List<Viagem> Viagens { get => viagens; set => viagens = value; }

        public Van()
        {
            Placa = -1;
            Viagens = new List<Viagem>();
        }

        public Van(int placa, int lotacao, string nomeMotorista)
        {
            Placa = placa;
            Lotacao = lotacao;
            NomeMotorista = nomeMotorista;
            Viagens = new List<Viagem>();
        }

        public void adicionaViagem(Viagem viagem)
        {
            Viagens.Add(viagem);
        }

        public void limparViagens()
        {
            int viagens = Viagens.Count;

            Viagens.RemoveRange(0, viagens);
        }

        public override bool Equals(object obj)
        {
            return Placa.Equals(((Van)obj).Placa);
        }

    }
}
