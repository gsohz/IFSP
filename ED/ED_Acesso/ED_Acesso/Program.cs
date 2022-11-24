using System;


namespace ED_Acesso
{
    class Program
    {
        static void Main(string[] args)
        {

            int key;
            Cadastro cadastro = new Cadastro();
            cadastro.download();

            do
            {
                Console.WriteLine(
                  "\n--------------------------------------------------------------------" +
                  "\n|  0. Sair                                                         |" +
                  "\n|  1. Cadastrar ambiente                                           |" +
                  "\n|  2. Consultar ambiente                                           |" +
                  "\n|  3. Excluir ambiente                                             |" +
                  "\n|  4. Cadastrar usuario                                            |" +
                  "\n|  5. Consultar usuario                                            |" +
                  "\n|  6. Excluir usuario                                              |" +
                  "\n|  7. Conceder permissão de acesso ao usuario                      |" +
                  "\n|  8. Revogar permissão de acesso ao usuario                       |" +
                  "\n|  9. Registrar acesso                                             |" +
                  "\n| 10. Consultar logs de acesso                                     |" +
                  "\n--------------------------------------------------------------------");

                Console.Write("\n\nEscolha uma opção: ");
                key = int.Parse(Console.ReadLine());
                Console.Write("\n\n");

                switch (key)
                {
                    case 0:
                        Console.WriteLine("Finalizando programa... Salvando dados...");
                        cadastro.upload();
                        break;
                    case 1:
                        Ambiente ambienteAdd = new Ambiente();
                        int idAmbienteAdd;
                        string nomeAmbienteAdd;

                        Console.Write("Insira o ID do ambiente que deseja cadastrar: ");
                        idAmbienteAdd = int.Parse(Console.ReadLine());
                        ambienteAdd.Id = idAmbienteAdd;

                        Console.Write("Insira o NOME do ambiente que deseja cadastrar: ");
                        nomeAmbienteAdd = Console.ReadLine();
                        ambienteAdd.Nome = nomeAmbienteAdd;

                        cadastro.adicionarAmbiente(ambienteAdd);
                        Console.WriteLine("Ambiente adicionado");
                        
                        break;
                    case 2:
                        int idAmbienteConsulta;
                        Console.Write("Insira o nome ID do ambiente que deseja pesquisar: ");
                        idAmbienteConsulta = int.Parse(Console.ReadLine());

                        Ambiente consultarAmbiente = new Ambiente(idAmbienteConsulta);
                        consultarAmbiente = cadastro.pesquisarAmbiente(consultarAmbiente);

                        if(consultarAmbiente.Id != -1)
                        {
                            Console.WriteLine("Id do ambiente: " + consultarAmbiente.Id + ", Nome: " + consultarAmbiente.Nome);
                        } else
                        {
                            Console.WriteLine("Ambiente não encontrado");
                        }
                        break;
                    case 3:
                        int idAmbienteRemove;
                        Console.Write("Insira o ID do ambiente que deseja remover: ");
                        idAmbienteRemove = int.Parse(Console.ReadLine());

                        Ambiente excluirAmbiente = new Ambiente(idAmbienteRemove);

                        if (cadastro.removerAmbiente(excluirAmbiente))
                        {
                            Console.WriteLine("Ambiente removido");
                        } else
                        {
                            Console.WriteLine("Não foi possível remover o ambiente solicitado");
                        }
                        break;
                    case 4:
                        Usuario usuarioAdd = new Usuario();
                        int idUsuarioAdd;
                        string nomeUsuarioAdd;

                        Console.Write("Insira o ID do usuario que deseja cadastrar: ");
                        idUsuarioAdd = int.Parse(Console.ReadLine());
                        usuarioAdd.Id = idUsuarioAdd;

                        Console.Write("Insira o NOME do usuario que deseja cadastrar: ");
                        nomeUsuarioAdd = Console.ReadLine();
                        usuarioAdd.Nome = nomeUsuarioAdd;

                        cadastro.adicionarUsuario(usuarioAdd);
                        Console.WriteLine("Usuario adicionado");
                        break;
                    case 5:
                        int idUsuarioConsulta;
                        Console.Write("Insira o nome ID do usuario que deseja pesquisar: ");
                        idUsuarioConsulta = int.Parse(Console.ReadLine());

                        Usuario consultarUsuario = new Usuario(idUsuarioConsulta);
                        consultarUsuario = cadastro.pesquisarUsuario(consultarUsuario);

                        if (consultarUsuario.Id != -1)
                        {
                            Console.WriteLine("Id do usuario: " + consultarUsuario.Id + ", Nome: " + consultarUsuario.Nome);
                        }
                        else
                        {
                            Console.WriteLine("Usuario não encontrado");
                        }
                        break;
                    case 6:
                        int idUsuarioRemove;
                        Console.Write("Insira o ID do usuario que deseja remover: ");
                        idUsuarioRemove = int.Parse(Console.ReadLine());

                        Usuario excluirUsuario = new Usuario(idUsuarioRemove);

                        if(cadastro.removerUsuario(excluirUsuario))
                        {
                            Console.WriteLine("Usuário removido");
                        } else
                        {
                            Console.WriteLine("Não foi possível remover o usuário solicitado");
                        }
                        break;
                    case 7:
                        int idUsuarioAddPermissao, idAmbienteAddPermissao;
                        Console.Write("Insira o ID do USUARIO que deseja conceder permissao de ambiente: ");
                        idUsuarioAddPermissao = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID do AMBIENTE que deseja conceder permissao ao usuario: ");
                        idAmbienteAddPermissao = int.Parse(Console.ReadLine());

                        Usuario usuarioAddPermissao = new Usuario(idUsuarioAddPermissao);
                        usuarioAddPermissao = cadastro.pesquisarUsuario(usuarioAddPermissao);
                        Ambiente ambienteAddPermissao = new Ambiente(idAmbienteAddPermissao);
                        ambienteAddPermissao = cadastro.pesquisarAmbiente(ambienteAddPermissao);


                        if (usuarioAddPermissao.Id == -1)
                        {
                            Console.WriteLine("Este usuário não existe");
                            break;
                        }

                        if (ambienteAddPermissao.Id == -1)
                        {
                            Console.WriteLine("Este ambiente não existe");
                            break;
                        }


                        bool podeConceder = usuarioAddPermissao.concederPermissao(ambienteAddPermissao);

                        if (podeConceder)
                        {
                            Console.WriteLine("Permissão concedida com sucesso.");
                        } else
                        {
                            Console.WriteLine("O usuario já tem permissão para acessar esse ambiente.");
                        }
                        break;
                    case 8:
                        int idUsuarioDelPermissao, idAmbienteDelPermissao;
                        Console.Write("Insira o ID do USUARIO que deseja revogar permissao de ambiente: ");
                        idUsuarioDelPermissao = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID do AMBIENTE que deseja revogar permissao ao usuario: ");
                        idAmbienteDelPermissao = int.Parse(Console.ReadLine());

                        Usuario usuarioDelPermissao = new Usuario(idUsuarioDelPermissao);
                        usuarioDelPermissao = cadastro.pesquisarUsuario(usuarioDelPermissao);
                        Ambiente ambienteDelPermissao = new Ambiente(idAmbienteDelPermissao);
                        ambienteDelPermissao = cadastro.pesquisarAmbiente(ambienteDelPermissao);

                        if (usuarioDelPermissao.Id == -1)
                        {
                            Console.WriteLine("Este usuário não existe");
                            break;
                        }

                        if(ambienteDelPermissao.Id == -1)
                        {
                            Console.WriteLine("Este ambiente não existe");
                            break;
                        }

                        bool podeRevogar = usuarioDelPermissao.revogarPermissao(ambienteDelPermissao);
                        
                        if (podeRevogar)
                        {
                            Console.WriteLine("Permissão revogada com sucesso.");
                        } else
                        {
                            Console.WriteLine("O usuario não possui essa permissão.");
                        }

                        break;
                    case 9:
                        int idUsuarioAcesso, idAmbienteAcesso;
                        Console.Write("Insira o ID do USUARIO que deseja acessar o ambiente: ");
                        idUsuarioAcesso = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ID do AMBIENTE que deseja acessar: ");
                        idAmbienteAcesso = int.Parse(Console.ReadLine());

                        Usuario usuarioAcesso = new Usuario(idUsuarioAcesso);
                        usuarioAcesso = cadastro.pesquisarUsuario(usuarioAcesso);
                        Ambiente ambienteAcesso = new Ambiente(idAmbienteAcesso);
                        ambienteAcesso = cadastro.pesquisarAmbiente(ambienteAcesso);

                        if (usuarioAcesso.Id == -1)
                        {
                            Console.WriteLine("Este usuário não existe");
                            break;
                        }

                        if (ambienteAcesso.Id == -1)
                        {
                            Console.WriteLine("Este ambiente não existe");
                            break;
                        }

                        bool tipoAcesso = false;

                        foreach(Ambiente a in usuarioAcesso.Ambientes)
                        {
                            if (a.Equals(ambienteAcesso))
                            {
                                tipoAcesso = true;
                            }
                        }

                        Log novoAcesso = new Log(usuarioAcesso, tipoAcesso);
                        ambienteAcesso.Logs.Enqueue(novoAcesso);

                        if (tipoAcesso)
                        {
                            Console.WriteLine("Usuário " + usuarioAcesso.Id + " " + usuarioAcesso.Nome + " acessou o ambiente " + ambienteAcesso.Id + " " + ambienteAcesso.Nome);
                        }
                        else
                        {
                            Console.WriteLine("O usuário não pode acessar este ambiente");
                        }
                        break;
                    case 10:
                        int idAmbienteLogs;
                        Console.Write("Insira o ID do AMBIENTE que deseja consultar os logs: ");
                        idAmbienteLogs = int.Parse(Console.ReadLine());

                        Ambiente ambienteLogs = new Ambiente(idAmbienteLogs);
                        ambienteLogs = cadastro.pesquisarAmbiente(ambienteLogs);

                        if (ambienteLogs.Id == -1)
                        {
                            Console.WriteLine("Este ambiente não existe");
                            break;
                        }

                        Console.WriteLine("\nTODOS OS LOGS DE " + ambienteLogs.Id + " - " + ambienteLogs.Nome);
                        foreach(Log log in ambienteLogs.Logs)
                        {
                            Console.WriteLine(log.Usuario.Id + " - " + log.TipoAcesso + " - " + log.DtAcesso);
                        }

                        Console.WriteLine("\nAcessos PERMITIDOS de " + ambienteLogs.Id + " - " + ambienteLogs.Nome);
                        foreach (Log log in ambienteLogs.Logs)
                        {
                            if(log.TipoAcesso == true)
                            {
                                Console.WriteLine(log.Usuario.Id + " - " + log.TipoAcesso + " - " + log.DtAcesso);
                            }
                        }

                        Console.WriteLine("\nAcessos NEGADOS de " + ambienteLogs.Id + " - " + ambienteLogs.Nome);
                        foreach (Log log in ambienteLogs.Logs)
                        {
                            if (log.TipoAcesso == false)
                            {
                                Console.WriteLine(log.Usuario.Id + " - " + log.TipoAcesso + " - " + log.DtAcesso);
                            }
                        }

                        break;
                }
            } while (key != 0);
        }
    
    }
}
