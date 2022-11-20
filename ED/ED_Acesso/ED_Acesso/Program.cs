using System;

namespace ED_Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            Cadastro cadastro = new Cadastro();

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
                    case 1:
                        Ambiente ambienteAdd = new Ambiente();
                        int idAmbienteAdd;
                        string nomeAmbienteAdd;

                        Console.WriteLine("Insira o ID do ambiente que deseja cadastrar: ");
                        idAmbienteAdd = int.Parse(Console.ReadLine());
                        ambienteAdd.Id = idAmbienteAdd;

                        Console.WriteLine("Insira o NOME do ambiente que deseja cadastrar: ");
                        nomeAmbienteAdd = Console.ReadLine();
                        ambienteAdd.Nome = nomeAmbienteAdd;

                        cadastro.adicionarAmbiente(ambienteAdd);
                        Console.WriteLine("Ambiente adicionado");

                        break;
                    case 2:
                        int idAmbienteConsulta;
                        Console.WriteLine("Insira o nome ID do ambiente que deseja pesquisar: ");
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
                        Console.WriteLine("Insira o ID do ambiente que deseja remover: ");
                        idAmbienteRemove = int.Parse(Console.ReadLine());

                        Ambiente excluirAmbiente = new Ambiente(idAmbienteRemove);

                        cadastro.removerAmbiente(excluirAmbiente);
                        break;
                    case 4:
                        Usuario usuarioAdd = new Usuario();
                        int idUsuarioAdd;
                        string nomeUsuarioAdd;

                        Console.WriteLine("Insira o ID do usuario que deseja cadastrar: ");
                        idUsuarioAdd = int.Parse(Console.ReadLine());
                        usuarioAdd.Id = idUsuarioAdd;

                        Console.WriteLine("Insira o NOME do usuario que deseja cadastrar: ");
                        nomeUsuarioAdd = Console.ReadLine();
                        usuarioAdd.Nome = nomeUsuarioAdd;

                        cadastro.adicionarUsuario(usuarioAdd);
                        Console.WriteLine("Usuario adicionado");
                        break;
                    case 5:
                        int idUsuarioConsulta;
                        Console.WriteLine("Insira o nome ID do usuario que deseja pesquisar: ");
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
                        Console.WriteLine("Insira o ID do usuario que deseja remover: ");
                        idUsuarioRemove = int.Parse(Console.ReadLine());

                        Usuario excluirUsuario = new Usuario(idUsuarioRemove);

                        cadastro.removerUsuario(excluirUsuario);
                        break;
                    case 7:
                        int idUsuarioAddPermissao, idAmbienteAddPermissao;
                        Console.WriteLine("Insira o ID do USUARIO que deseja conceder permissao de ambiente: ");
                        idUsuarioAddPermissao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o ID do AMBIENTE que deseja conceder permissao ao usuario: ");
                        idAmbienteAddPermissao = int.Parse(Console.ReadLine());

                        Usuario usuarioAddPermissao = new Usuario(idUsuarioAddPermissao);
                        usuarioAddPermissao = cadastro.pesquisarUsuario(usuarioAddPermissao);
                        Ambiente ambienteAddPermissao = new Ambiente(idAmbienteAddPermissao);
                        ambienteAddPermissao = cadastro.pesquisarAmbiente(ambienteAddPermissao);
                    
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
                        Console.WriteLine("Insira o ID do USUARIO que deseja revogar permissao de ambiente: ");
                        idUsuarioDelPermissao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o ID do AMBIENTE que deseja revogar permissao ao usuario: ");
                        idAmbienteDelPermissao = int.Parse(Console.ReadLine());

                        Usuario usuarioDelPermissao = new Usuario(idUsuarioDelPermissao);
                        usuarioDelPermissao = cadastro.pesquisarUsuario(usuarioDelPermissao);
                        Ambiente ambienteDelPermissao = new Ambiente(idAmbienteDelPermissao);
                        ambienteDelPermissao = cadastro.pesquisarAmbiente(ambienteDelPermissao);

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
                        break;
                    case 10:
                        break;
                }
            } while (key != 0);
        }
    
    }
}
