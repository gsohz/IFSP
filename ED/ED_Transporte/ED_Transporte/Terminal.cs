using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ED_Transporte
{
    class Terminal
    {
        private Queue<Veiculo> veiculos;
        private Queue<Visitante> visitantes;

        internal Queue<Veiculo> Veiculos { get => veiculos; set => veiculos = value; }
        internal Queue<Visitante> Visitantes { get => visitantes; set => visitantes = value; }
    

        public Terminal()
        {
            Veiculos = new Queue<Veiculo>();
            Visitantes = new Queue<Visitante>();
        }

        public bool adicionarVeiculo(Veiculo veiculo)
        {
            foreach (Veiculo v in Veiculos)
            {
                if (v.Equals(veiculo))
                {
                    return false;
                }
            }

            Veiculos.Enqueue(veiculo);
            int segundos = 30 * 1000;
            veiculo.TempoEspera = new Timer(segundos);
            veiculo.TempoEspera.Elapsed += registraSaidaPorTempo;
            veiculo.TempoEspera.Enabled = true;
            veiculo.TempoEspera.AutoReset = true;
            veiculo.TempoEspera.Start();

            return true;
        }


        public bool adicionarVisitante(Visitante visitante)
        {
            foreach(Visitante v in Visitantes)
            {
                if (v.Equals(visitante))
                {
                    return false;
                }
            }


            Visitantes.Enqueue(visitante);
            Veiculo aux = Veiculos.Peek();
            
            if (aux.liberarSaida(Visitantes.Count)){
                List<Visitante> visitantesViagem = new List<Visitante>();
                for (int i = 0; i < aux.Lotacao; i++)
                {
                    visitantesViagem.Add(Visitantes.Dequeue());
                }
                Viagem viagem = new Viagem(aux, visitantesViagem);
                aux.Viagens.Add(viagem);
                Veiculos.Dequeue();
                Veiculos.Enqueue(aux);
                aux.TempoEspera.Stop();
                aux.TempoEspera.Start();
            }

            return true;
        }

        private void registraSaidaPorTempo(object sender, ElapsedEventArgs e)
        {
            Veiculo aux = Veiculos.Peek();
            
            List<Visitante> visitantesViagem = new List<Visitante>();
            if(Visitantes.Count != 0)
            {
                for (int i = 0; i <= Visitantes.Count; i++)
                {
                    visitantesViagem.Add(Visitantes.Dequeue());
                }
            }
            Viagem viagem = new Viagem(aux, visitantesViagem);
            aux.Viagens.Add(viagem);
            Veiculos.Dequeue();
            Veiculos.Enqueue(aux);
            
        }

        public string listaVeiculos()
        {
            string listaVeiculos = "";
            foreach (Veiculo v in Veiculos)
            {
                listaVeiculos += ($"Placa: {v.Placa} - Condutor: {v.Nome_motorista} - Lt: {v.Lotacao}\n");
            }
            return listaVeiculos;
        }

        public string listaVisitantes()
        {
            string listaVisitantes = "";
            foreach (Visitante v in Visitantes)
            {
                listaVisitantes += ($"Inscrição: {v.Inscricao}\n");
            }
            return listaVisitantes;
        }

        public string listaViagensVeiculos(int placa)
        {
            Veiculo v = new Veiculo(placa);
            Veiculo aux = new Veiculo(-1);
            foreach(Veiculo veiculo in Veiculos)
            {
                if (veiculo.Equals(v))
                {
                    aux = veiculo;
                    break;
                }
            }

            if (aux.Placa == -1)
            {
                return "O veículo não existe";
            }


            string listaViagens = "";

            if(aux.Viagens.Count == 0)
            {
                listaViagens = "O veículo ainda não fez viagens";
                return listaViagens;
            }

            foreach(Viagem viagem in aux.Viagens)
            {
                int qtdVisitantes = 0;
                foreach(Visitante visitante in viagem.Visitantes)
                {
                    qtdVisitantes += 1;
                }

                listaViagens += $"{viagem.Dt_hora_viagem} - Placa veículo: {viagem.Veiculo.Placa} - Qtd passageiros: {qtdVisitantes}\n";
            }

            return listaViagens;
        } 

        public string finalizarJornada()
        {
            string finalizacao = "Jornada finalizada! Ganhos dos veículos:\n";
            foreach(Veiculo v in Veiculos)
            {
                finalizacao += $"Veículo {v.Placa} - {v.Nome_motorista}:    R$ {v.calculaJornada()}\n";
            }
            return finalizacao;
        }
    }
}
