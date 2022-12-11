using System;
using System.Collections.Generic;
using System.Text;

namespace ED_TRANSPORTE_2
{
    class Viagem
    {
        private Van veiculo;
        private Garagem origem;
        private Garagem destino;
        private DateTime dt_viagem;
        private int visitantes;

        public Van Veiculo { get => veiculo; set => veiculo = value; }
        public Garagem Origem { get => origem; set => origem = value; }
        public Garagem Destino { get => destino; set => destino = value; }
        public DateTime Dt_viagem { get => dt_viagem; set => dt_viagem = value; }
        public int Visitantes { get => visitantes; set => visitantes = value; }

        public Viagem(Van van, Garagem origem, Garagem destino, int visitantes)
        {
            Veiculo = van;
            Origem = origem;
            Destino = destino;
            Visitantes = visitantes;
            Dt_viagem = DateTime.Now;
        }

        public override string ToString()
        {
            return $"DATA: {Dt_viagem} - PLACA: {Veiculo.Placa} - MOTORISTA: {Veiculo.NomeMotorista}";
        }
    }
}
