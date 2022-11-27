using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Transporte
{
    class Viagem
    {
        private Veiculo veiculo;
        private DateTime dt_hora_viagem;
        private List<Visitante> visitantes;

        public Veiculo Veiculo { get => veiculo; set => veiculo = value; }
        public DateTime Dt_hora_viagem { get => dt_hora_viagem; set => dt_hora_viagem = value; }
        internal List<Visitante> Visitantes { get => visitantes; set => visitantes = value; }
    
        public Viagem(Veiculo veiculo, List<Visitante> visitantes)
        {
            Veiculo = veiculo;
            Visitantes = visitantes;
            Dt_hora_viagem = DateTime.Now;
        }

    }
}
