using System;
using System.Collections.Generic;

namespace ED_Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Contatos agenda = new Contatos();
            int key;

            do
            {
                Console.WriteLine("\n-------------------------------------" +
                                    "\n| 0.Sair                            |" +
                                    "\n| 1.Adicionar contato               |" +
                                    "\n| 2.Pesquisar contato               |" +
                                    "\n| 3.Alterar contato                 |" +
                                    "\n| 4.Remover contato                 |" +
                                    "\n| 5.Listar contatos                 |" +
                                    "\n-------------------------------------");

                Console.Write("Opção: ");
                key = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (key)
                {
                    case 1:
                        Console.WriteLine("ADICIONAR CONTATO:");
                        Console.Write("\nInsira um email: ");
                        string email = Console.ReadLine();
                        Console.Write("Insira o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Insira a data de nascimento: ");
                        Console.Write("\nDia: ");
                        int dia = int.Parse(Console.ReadLine());
                        Console.Write("Mês: ");
                        int mes = int.Parse(Console.ReadLine());
                        Console.Write("Ano: ");
                        int ano = int.Parse(Console.ReadLine());

                        List<Telefone> telefones = new List<Telefone>();
                        bool addTel;

                        Console.Write("\nTelefones: ");
                        do
                        {
                            Console.Write("\nTipo do telefone: ");
                            string tipo = Console.ReadLine();
                            Console.Write("Número do telefone: ");
                            string numTel = Console.ReadLine();
                            Console.Write("É o telefone principal? (s/n): ");
                            bool principal = Console.ReadLine() == "s";
                            Console.Write("O contato possui outros telefones? (s/n): ");
                            addTel = Console.ReadLine() == "s";
           
                            Telefone addTelefone = new Telefone(tipo, numTel, principal);
                            telefones.Add(addTelefone);
                        } while (addTel == true);

                        Data nasc = new Data(dia, mes, ano);
                        Contato addContato = new Contato(email, nome, nasc, telefones);
                        Console.WriteLine(agenda.Adicionar(addContato)? "Contato adicionado com sucesso" : "Não foi possível adicionar o contato");
                        break;
                    case 2:
                        Console.WriteLine("PESQUISAR CONTATO:");
                        Console.Write("\nInsira o email do contato que deseja pesquisar: ");
                        string emailPesquisa = Console.ReadLine();

                        Contato pesquisaContato = new Contato(emailPesquisa);
                        pesquisaContato = agenda.Pesquisar(pesquisaContato);

                        if (pesquisaContato.Email != "-1")
                        {
                            Console.WriteLine(pesquisaContato.ToString());
                        } else
                        {
                            Console.WriteLine("Não foi possível localizar esse email: " + emailPesquisa);
                        }
                        break;
                    case 3:
                        Console.WriteLine("ALTERAR CONTATO:");
                        Console.Write("\nInsira o email do contato que deseja alterar: ");
                        string emailPesquisaAltera = Console.ReadLine();

                        Contato alteraContato = new Contato(emailPesquisaAltera);
                        alteraContato = agenda.Pesquisar(alteraContato);

                        alteraContato.ToString();

                        if (alteraContato.Email != "-1")
                        {
                            Console.Write("\nEscolha o que deseja alterar: ");
                            Console.Write("\n1. Email"              +
                                          "\n2. Nome"               +
                                          "\n3. Data de nascimento" +
                                          "\n4. Adicionar telefone" +
                                          "\n5. Resetar telefones"  +
                                          "\nOpção: ");
                            int keyAlteraContato = int.Parse(Console.ReadLine());

                            switch (keyAlteraContato)
                            {
                                case 1:
                                    Console.Write("\nInsira o novo email:");
                                    string emailAlterado = Console.ReadLine();

                                    alteraContato.Email = emailAlterado;
                                    break;
                                case 2:
                                    Console.Write("\nInsira o novo nome:");
                                    string nomeAlterado = Console.ReadLine();

                                    alteraContato.Nome = nomeAlterado;
                                    break;
                                case 3:
                                    Console.Write("\nInsira a nova data de nascimento:");
                                    Console.Write("\nDia: ");
                                    int diaAlterado = int.Parse(Console.ReadLine());
                                    Console.Write("Mês: ");
                                    int mesAlterado = int.Parse(Console.ReadLine());
                                    Console.Write("Ano: ");
                                    int anoAlterado = int.Parse(Console.ReadLine());

                                    Data nascAlterado = new Data(diaAlterado, mesAlterado, anoAlterado);
                                    alteraContato.DtNasc = nascAlterado;
                                    break;
                                case 4:
                                    Console.Write("\nInforme o telefone que deseja adicionar a este contato: ");
                                    Console.Write("\nTipo do telefone: ");
                                    string tipoAddAltera = Console.ReadLine();
                                    Console.Write("Número do telefone: ");
                                    string numTelAddAltera = Console.ReadLine();
                                    Console.Write("É o telefone principal? (s/n): ");
                                    bool principalAddAltera = Console.ReadLine() == "s";
                                    

                                    Telefone telAltera = new Telefone(tipoAddAltera, numTelAddAltera, principalAddAltera);
                                    alteraContato.AdicionarTelefone(telAltera);

                                    break;
                                case 5:
                                    Console.Write("Os telefones serão apagados. Insira os novos telefones do contato:");
                                    List<Telefone> telefonesAlterado = new List<Telefone>();
                                    bool addTelAlterado;

                                    Console.Write("\nTelefones: ");
                                    do
                                    {
                                        Console.Write("\nTipo do telefone: ");
                                        string tipo = Console.ReadLine();
                                        Console.Write("Número do telefone: ");
                                        string numTel = Console.ReadLine();
                                        Console.Write("É o telefone principal? (s/n): ");
                                        bool principal = Console.ReadLine() == "s";
                                        Console.Write("O contato possui outros telefones? (s/n): ");
                                        addTelAlterado = Console.ReadLine() == "s";

                                        Telefone addTelefone = new Telefone(tipo, numTel, principal);
                                        telefonesAlterado.Add(addTelefone);
                                    } while (addTelAlterado == true);

                                    alteraContato.Telefones = telefonesAlterado;
                                    break;
                            }
                        } else
                        {
                            Console.WriteLine("Não foi possível localizar esse email: " + emailPesquisaAltera);
                        }

                        break;
                    case 4:
                        Console.WriteLine("REMOVER CONTATO:");
                        Console.Write("\nInsira o email do contato que deseja remover: ");
                        string emailPesquisaRemove = Console.ReadLine();

                        Contato removeContato = new Contato(emailPesquisaRemove);
                        removeContato = agenda.Pesquisar(removeContato);

                        if(removeContato.Email != "-1")
                        {
                            Console.WriteLine(agenda.Remover(removeContato) ? "Contato removido com sucesso" : "Não foi possível remover o contato");
                        } else
                        {
                            Console.WriteLine("Não foi possível localizar esse email: " + emailPesquisaRemove);
                        }
                        break;
                    case 5:
                        Console.WriteLine("--------------------AGENDA------------------------\n");
                        Console.WriteLine("Qtde de contatos na agenda: {0}", agenda.Agenda.Count);
                        foreach (Contato contato in agenda.Agenda)
                        {
                            Console.Write(contato.ToString() + "\n");
                        }
                        Console.WriteLine("--------------------------------------------------\n\n");
                        break;
                }
            } while (key != 0);
        }
    }
}
