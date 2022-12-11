using System;

namespace ED_TRANSPORTE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            Terminal t = new Terminal();
            Garagem guarulhos = new Garagem(1, "Guarulhos");
            Garagem congonhas = new Garagem(2, "Congonhas");
            t.cadastrarGaragem(guarulhos);
            t.cadastrarGaragem(congonhas);

            Console.WriteLine("Garagem de Guarulhos ID 1 e Congonhas ID 2 já foram adicionadas");

            do
            {
                Console.WriteLine(
                 "\n---------------------------------------------------------------------------------------------------------------------" +
                 "\n|  0. Finalizar                                                                                                     |" +
                 "\n|  1. Cadastrar veículo                                                                                             |" +
                 "\n|  2. Cadastrar garagem                                                                                             |" +
                 "\n|  3. Iniciar jornada                                                                                               |" +
                 "\n|  4. Encerrar jornada                                                                                              |" +
                 "\n|  5. Liberar viagem de uma determinada origem para um determinado destino                                          |" +
                 "\n|  6. Listar veículos em determinada garagem(informando a quantidade de veículos e seu potencial de transporte)     |" +
                 "\n|  7. Informar quantidade de viagens efetuadas de uma determinada origem para um determinado destino                |" +
                 "\n|  8. Listar viagens efetuadas de uma determinada origem para um determinado destino                                |" +
                 "\n|  9. Informar quantidade de passageiros transportados de uma determinada origem para um determinado destino        |" +
                 "\n---------------------------------------------------------------------------------------------------------------------");

                Console.Write("\n\nEscolha uma opção: ");
                key = int.Parse(Console.ReadLine());
                Console.Write("\n\n");

                switch (key) 
                {
                    case 1:
                        if (t.SituacaoJornada)
                        {
                            Console.WriteLine("A jornada precisa ser encerrada para adicionar novo veículos");
                            break;
                        }

                        int placa, lotacao;
                        string motorista;
                        Console.Write("Insira a placa do veículo (numero inteiro para teste): ");
                        placa = int.Parse(Console.ReadLine());
                        Console.Write("Insira a lotação do veículo: ");
                        lotacao = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do motorista do veículo: ");
                        motorista = Console.ReadLine();

                        Van criaVan = new Van(placa, lotacao, motorista);
                        if (t.pesquisaVan(criaVan).Placa != -1)
                        {
                            Console.WriteLine("Já PLACA já está registrada");
                            break;
                        }
                        t.cadastrarVan(criaVan);
                        break;
                    case 2:
                        if (t.SituacaoJornada)
                        {
                            Console.WriteLine("A jornada precisa ser encerrada para adicionar nova garagem");
                            break;
                        }

                        int id;
                        string desc;
                        Console.Write("Insira o ID da garagem: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome da garagem: ");
                        desc = Console.ReadLine();
                                             
                        Garagem criaGaragem = new Garagem(id, desc);
                        if(t.pesquisaGaragem(criaGaragem).Id != -1)
                        {
                            Console.WriteLine("Já existe uma garagem com esse ID");
                            break;
                        }
                        t.cadastrarGaragem(criaGaragem);
                        break;
                    case 3:
                        t.iniciarJornada();
                        break;
                    case 4:
                        t.encerrarJornada();
                        break;
                    case 5:
                        int idLiberarOrigem, idLiberarDestino, qtdePassageiros;

                        Console.Write("Insira o ID da garagem de ORIGEM para liberar viagem: ");
                        idLiberarOrigem = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID da garagem de DESTINO para liberar viagem: ");
                        idLiberarDestino = int.Parse(Console.ReadLine());

                        Garagem liberarOrigem = new Garagem(idLiberarOrigem);
                        Garagem liberarDestino = new Garagem(idLiberarDestino);

                        liberarOrigem = t.pesquisaGaragem(liberarOrigem);
                        liberarDestino = t.pesquisaGaragem(liberarDestino);

                        if(liberarOrigem.Id == -1)
                        {
                            Console.WriteLine("Garagem de origem não encontrada");
                            break;
                        }

                        if (liberarDestino.Id == -1)
                        {
                            Console.WriteLine("Garagem de destino não encontrada");
                            break;
                        }

                        Van vanLiberadaViagem = liberarOrigem.Vans.Peek();
                        do
                        {
                            Console.Write("Insira a quantidade de passageiros na viagem: ");
                            qtdePassageiros = int.Parse(Console.ReadLine());
                            if(qtdePassageiros > vanLiberadaViagem.Lotacao)
                            {
                                Console.WriteLine($"Insira uma quantidade de passageiros que a van suporte: {vanLiberadaViagem.Lotacao}");
                            }
                        } while (qtdePassageiros > vanLiberadaViagem.Lotacao);

                        t.liberarViagem(liberarOrigem, liberarDestino, qtdePassageiros);
                        break;
                    case 6:
                        int idListaGaragem;

                        Console.Write("Insira o ID da garagem que deseja ver os veículos: ");
                        idListaGaragem = int.Parse(Console.ReadLine());

                        Garagem listaGaragem = new Garagem(idListaGaragem);

                        listaGaragem = t.pesquisaGaragem(listaGaragem);

                        if(listaGaragem.Id == -1)
                        {
                            Console.WriteLine("Garagem informada não foi encontrada");
                            break;
                        }

                        t.listarVansEmGaragem(listaGaragem);
                        break;
                    case 7:
                        int idQtdeViagensOrigem, idQtdeViagensDestino;

                        Console.Write("Insira o ID da garagem de ORIGEM para ver quantidade de viagens: ");
                        idQtdeViagensOrigem = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID da garagem de DESTINO para ver quantidade de viagens: ");
                        idQtdeViagensDestino = int.Parse(Console.ReadLine());

                        Garagem qtdeViagemGaragemOrigem = new Garagem(idQtdeViagensOrigem);
                        Garagem qtdeViagemGaragemDestino = new Garagem(idQtdeViagensDestino);

                        qtdeViagemGaragemOrigem = t.pesquisaGaragem(qtdeViagemGaragemOrigem);
                        qtdeViagemGaragemDestino = t.pesquisaGaragem(qtdeViagemGaragemDestino);

                        if(qtdeViagemGaragemOrigem.Id == -1)
                        {
                            Console.WriteLine("Garagem de origem informada não foi encontrada");
                            break;
                        }

                        if (qtdeViagemGaragemDestino.Id == -1)
                        {
                            Console.WriteLine("Garagem de destino informada não foi encontrada");
                            break;
                        }
                        int qtdeViagensTotal = t.qtdeViagemEntreDestinos(qtdeViagemGaragemOrigem, qtdeViagemGaragemDestino);
                        Console.WriteLine($"O total de viagens entre {qtdeViagemGaragemOrigem.Desc} e {qtdeViagemGaragemDestino.Desc} é: {qtdeViagensTotal}");
                        break;
                    case 8:
                        int idListaViagensOrigem, idListaViagensDestino;

                        Console.Write("Insira o ID da garagem de ORIGEM para listar viagens: ");
                        idListaViagensOrigem = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID da garagem de DESTINO para listar viagens: ");
                        idListaViagensDestino = int.Parse(Console.ReadLine());

                        Garagem listaViagensOrigem = new Garagem(idListaViagensOrigem);
                        Garagem listaViagensDestino = new Garagem(idListaViagensDestino);

                        listaViagensOrigem = t.pesquisaGaragem(listaViagensOrigem);
                        listaViagensDestino = t.pesquisaGaragem(listaViagensDestino);

                        if (listaViagensOrigem.Id == -1)
                        {
                            Console.WriteLine("Garagem de origem informada não foi encontrada");
                            break;
                        }

                        if (listaViagensDestino.Id == -1)
                        {
                            Console.WriteLine("Garagem de destino informada não foi encontrada");
                            break;
                        }

                        t.listarViagemEntreDestinos(listaViagensOrigem, listaViagensDestino);
                        break;
                    case 9:
                        int idQtdePassageirosOrigem, idQtdePassageirosDestino;

                        Console.Write("Insira o ID da garagem de ORIGEM para verificar quantidade de passageiros: ");
                        idQtdePassageirosOrigem = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID da garagem de DESTINO para verificar quantidade de passageiros: ");
                        idQtdePassageirosDestino = int.Parse(Console.ReadLine());

                        Garagem qtdePassageirosOrigem = new Garagem(idQtdePassageirosOrigem);
                        Garagem qtdePassageirosDestino = new Garagem(idQtdePassageirosDestino);

                        qtdePassageirosOrigem = t.pesquisaGaragem(qtdePassageirosOrigem);
                        qtdePassageirosDestino = t.pesquisaGaragem(qtdePassageirosDestino);

                        if (qtdePassageirosOrigem.Id == -1)
                        {
                            Console.WriteLine("Garagem de origem informada não foi encontrada");
                            break;
                        }

                        if (qtdePassageirosDestino.Id == -1)
                        {
                            Console.WriteLine("Garagem de destino informada não foi encontrada");
                            break;
                        }

                        int qtdePassageirosTotal = t.qtdePassageirosEntreDestinos(qtdePassageirosOrigem, qtdePassageirosDestino);

                        Console.WriteLine($"O total de passageiros transportados entre {qtdePassageirosOrigem.Desc} e {qtdePassageirosDestino.Desc} é: {qtdePassageirosTotal}");
                        break;
                }

            } while (key != 0);

        }
    }
}
