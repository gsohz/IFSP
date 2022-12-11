using System;
using System.Collections.Generic;
using System.Text;

namespace ED_TRANSPORTE_2
{
    class Terminal
    {
        private List<Van> vans;
        private List<Garagem> garagens;
        private bool situacaoJornada;

        public bool SituacaoJornada { get => situacaoJornada; set => situacaoJornada = value; }
        internal List<Van> Vans { get => vans; set => vans = value; }
        internal List<Garagem> Garagens { get => garagens; set => garagens = value; }

        public Terminal()
        {
            Vans = new List<Van>();
            Garagens = new List<Garagem>();
            situacaoJornada = false;
        }

        public void cadastrarVan(Van van)
        {
            if (SituacaoJornada)
            {
                Console.WriteLine("A jornada precisa ser encerrada para adicionar novo veículos");
                return;
            }

            Vans.Add(van);
            Console.WriteLine("Van adicionada com sucesso");
        }

        public void cadastrarGaragem(Garagem garagem)
        {
            if (SituacaoJornada)
            {
                Console.WriteLine("A jornada precisa ser encerrada para adicionar nova garagem");
                return;
            }

            Garagens.Add(garagem);
            Console.WriteLine("Garagem adicionada com sucesso");
        }

        public void iniciarJornada()
        {
            if (SituacaoJornada)
            {
                Console.WriteLine("Jornada já está iniciada");
                return;
            }

            int qtdVanParaAdicionar = Vans.Count;
            int indexTotalVan = Vans.Count - 1;
            int indexAtualVan = 0;
            for(int i = 0; i <= qtdVanParaAdicionar; i++)
            {
                foreach(Garagem garagem in Garagens)
                {
                    if(indexAtualVan > indexTotalVan)
                    {
                        break;
                    }
                    garagem.adicionarVanNaGaragem(Vans[indexAtualVan]);
                    indexAtualVan++;
                }
                if (indexAtualVan > indexTotalVan)
                {
                    break;
                }
                qtdVanParaAdicionar -= Garagens.Count;
            }

            SituacaoJornada = true;

            Console.WriteLine("Jornada iniciada");
        }

        public void encerrarJornada()
        {
            if (!SituacaoJornada)
            {
                Console.WriteLine("Jornada já está encerrada");
                return;
            }

            foreach(Van van in Vans)
            {
                int totalPassageiros = 0;
                foreach(Viagem viagem in van.Viagens)
                {
                    totalPassageiros += viagem.Visitantes;
                }
                van.limparViagens();
                Console.WriteLine($"PLACA: {van.Placa} - MOTORISTA: {van.NomeMotorista} - TOTAL TRANSPORTADO: {totalPassageiros}");
            }

            foreach(Garagem garagem in Garagens)
            {
                for (int i = 0; i <= garagem.Vans.Count; i++)
                {
                    garagem.Vans.Pop();
                }
            }

            SituacaoJornada = false;
            Console.WriteLine("Jornada encerrada");
        }

        public void liberarViagem(Garagem origem, Garagem destino, int qtdePassageiros)
        {
            if (!SituacaoJornada)
            {
                Console.WriteLine("A viagem não pôde ser liberada porque a jornada não foi iniciada");
                return;
            }

            if(origem.Vans.Count == 0)
            {
                Console.WriteLine($"A garagem de origem '{origem.Desc}' não possui vans");
                return;
            }
                        
            Van aux = origem.removerVanDaGaragem();
            destino.adicionarVanNaGaragem(aux);
            Viagem viagem = new Viagem(aux, origem, destino, qtdePassageiros);
            aux.adicionaViagem(viagem);
            Console.WriteLine($"Viagem realizada de {origem.Desc} para {destino.Desc}");
        }

        public void listarVansEmGaragem(Garagem garagem)
        {
            string vansNaGaragem = "";
            int capacidadeTransporte = 0;

            foreach (Van van in garagem.Vans)
            {
                capacidadeTransporte += van.Lotacao;
                vansNaGaragem += "Placa " + van.Placa + " - Lotação " + van.Lotacao + " - Motorista " + van.NomeMotorista + "\n";
            }

            Console.WriteLine($"Há {garagem.Vans.Count} vans na garagem '{garagem.Desc}' com capacidade de transporte de {capacidadeTransporte}");
            Console.WriteLine(vansNaGaragem);
        }

        public int qtdeViagemEntreDestinos(Garagem origem, Garagem destino)
        {
            int qtdeViagem = 0;

            foreach(Van van in Vans)
            {
                foreach(Viagem viagem in van.Viagens)
                {
                    if (origem.Equals(viagem.Origem) && destino.Equals(viagem.Destino))
                    {
                        qtdeViagem++;
                    }
                }
            }

            return qtdeViagem;
        }

        public void listarViagemEntreDestinos(Garagem origem, Garagem destino)
        {
            string viagensRealizadas = "";

            foreach (Van van in Vans)
            {
                foreach (Viagem viagem in van.Viagens)
                {
                    if (origem.Equals(viagem.Origem) && destino.Equals(viagem.Destino))
                    {
                        viagensRealizadas += viagem.ToString() + "\n";
                    }
                }
            }

            Console.WriteLine($"Lista de viagens de {origem.Desc} para {destino.Desc}");
            Console.WriteLine(viagensRealizadas);
        }

        public int qtdePassageirosEntreDestinos(Garagem origem, Garagem destino)
        {
            int qtdePassageiros = 0;

            foreach (Van van in Vans)
            {
                foreach (Viagem viagem in van.Viagens)
                {
                    if (origem.Equals(viagem.Origem) && destino.Equals(viagem.Destino))
                    {
                        qtdePassageiros += viagem.Visitantes;
                    }
                }
            }

            return qtdePassageiros;
        }

        public Garagem pesquisaGaragem(Garagem garagemPesquisa)
        {
            Garagem aux = new Garagem();
            foreach (Garagem garagem in Garagens)
            {
                if (garagem.Equals(garagemPesquisa))
                {
                    aux = garagem;
                }
            }
            return aux;
        }

        public Van pesquisaVan(Van vanPesquisa)
        {
            Van aux = new Van();
            foreach(Van van in Vans)
            {
                if (van.Equals(vanPesquisa))
                {
                    aux = van;
                }
            }
            return aux;
        }
    }
}
