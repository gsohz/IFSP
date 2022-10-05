using System;
using System.Linq;
using System.Collections.Generic;

namespace ED_Acervo
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = -1;
            Livros acervo = new Livros();

            do
            {
                Console.WriteLine(
                  "\n--------------------------------------" +
                  "\n| 0. Sair                            |" +
                  "\n| 1. Adicionar livro                 |" +
                  "\n| 2. Pesquisar livro (sintético)     |" +
                  "\n| 3. Pesquisar livro (analítico)     |" +
                  "\n| 4. Adicionar exemplar              |" +
                  "\n| 5. Registrar empréstimo            |" +
                  "\n| 6. Registrar devolução             |" +
                  "\n--------------------------------------");
                key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        string Value;

                        Livro addLivro = new Livro();

                        Console.Write("Insira o ISBN: ");
                        Value = Console.ReadLine();
                        addLivro.ISBN = (int.Parse(Value));

                        Console.Write("Insira o titulo: ");
                        Value = Console.ReadLine();
                        addLivro.Titulo = (Value);

                        Console.Write("Insira o autor: ");
                        Value = Console.ReadLine();
                        addLivro.Autor = (Value);

                        Console.Write("Insira o editora: ");
                        Value = Console.ReadLine();
                        addLivro.Editora = (Value);

                        acervo.adicionar(addLivro);

                        break;
                    case 2:
                        Console.Write("Insira o Titulo do Livro que deseja pesquisar (sintético): ");
                        string tituloSint = Console.ReadLine();
                        Livro pesqLivroSint = new Livro(tituloSint);
                        pesqLivroSint = acervo.pesquisar(pesqLivroSint);

                        Console.Write("\nISBN: " + pesqLivroSint.ISBN + "\nTitulo: " + pesqLivroSint.Titulo + 
                                      "\nAutor: " + pesqLivroSint.Autor + "\nEditora: " + pesqLivroSint.Editora + 
                                      "\nTotal de exemplares: " + pesqLivroSint.qtdeExemplares() + 
                                      "\nExemplares disponíveis: " + pesqLivroSint.qtdeDisponiveis() +
                                      "\nTotal de exemplares emprestados: " + pesqLivroSint.qtdeEmprestimos() +
                                      "\nPercentual de exemplares disponíveis: " + pesqLivroSint.percDisponibilidade() + "%");
                        
                        break;
                    case 3:
                        Console.Write("Insira o Titulo do Livro que deseja pesquisar (analítico): ");
                        string tituloAnal = Console.ReadLine();
                        Livro pesqLivroAnal = new Livro(tituloAnal);
                        pesqLivroAnal = acervo.pesquisar(pesqLivroAnal);

                        Console.Write("\nISBN: " + pesqLivroAnal.ISBN + "\nTitulo: " + pesqLivroAnal.Titulo + 
                                      "\nAutor: " + pesqLivroAnal.Autor + "\nEditora: " + pesqLivroAnal.Editora + 
                                      "\nTotal de exemplares: " + pesqLivroAnal.qtdeExemplares() + 
                                      "\nExemplares disponíveis: " + pesqLivroAnal.qtdeDisponiveis() + 
                                      "\nTotal de exemplares emprestados: " + pesqLivroAnal.qtdeEmprestimos() + 
                                      "\nPercentual de exemplares disponíveis: " + pesqLivroAnal.percDisponibilidade() + "%");
                        Console.Write("\n\nExemplares: ");
                        if (pesqLivroAnal.Exemplares.Count > 0)
                        {
                            DateTime dtNull = new DateTime(1, 1, 1);
                            foreach (Exemplar e in pesqLivroAnal.Exemplares)
                            {
                                DateTime dt = e.Emprestimos.LastOrDefault().DtEmprestimo;
                                Console.Write("\n\nTombo do exemplar: " + e.Tombo + ", qtd de emprestimos: " + e.qtdeEmprestimos() +
                                              ", disponivel atualmente: " + (e.disponivel() == true ? "Sim" : "Não"));

                                Console.Write("\nEmprestimos de " + e.Tombo);
                                
                                foreach (Emprestimo emp in e.Emprestimos)
                                {
                                    if(emp.DtEmprestimo != null)
                                    {
                                        Console.Write("\nData do Emprestimo: " + emp.DtEmprestimo + ", Data da Devolução: ");
                                        if(emp.DtDevolucao != dtNull)
                                        {
                                            Console.Write(emp.DtDevolucao);
                                        } else
                                        {
                                            Console.Write("Não foi devolvido");
                                        }
                                    }
                                }
                            }
                        } else
                        {
                            Console.Write("\nNão possui exemplares");
                        }
                        break;
                    case 4:
                        Console.Write("Insira o Titulo do Livro que deseja acrescentar um exemplar: ");
                        string tituloLivro = Console.ReadLine();
                        Livro addExemplarLivro = new Livro(tituloLivro);
                        addExemplarLivro = acervo.pesquisar(addExemplarLivro);

                        Console.Write("Informe o tombo do exemplar: ");
                        int tomboExemplar = int.Parse(Console.ReadLine());

                        Exemplar addExemplar = new Exemplar(tomboExemplar);

                        addExemplarLivro.adicionarExemplar(addExemplar);
                        break;
                    case 5:
                        Console.Write("Insira o Titulo do livro que deseja emprestar: ");
                        string tituloLivroEmpresta = Console.ReadLine();
                        Livro addEmprestimoExemplarLivro = new Livro(tituloLivroEmpresta);
                        addEmprestimoExemplarLivro = acervo.pesquisar(addEmprestimoExemplarLivro);

                        Console.Write("Insira o Tombo do exemplar que deseja emprestar: ");
                        int tomboExemplarAddEmprestimo = int.Parse(Console.ReadLine());

                        Exemplar exemplar = new Exemplar();

                        foreach(Exemplar e in addEmprestimoExemplarLivro.Exemplares)
                        {
                            if (e.Tombo.Equals(tomboExemplarAddEmprestimo))
                            {
                                exemplar = e;
                            }
                        }

                        exemplar.emprestrar();

                        break;
                    case 6:
                        Console.Write("Insira o Titulo do livro que deseja devolver: ");
                        string tituloLivroDevolve = Console.ReadLine();
                        Livro devolveExemplarLivro = new Livro(tituloLivroDevolve);
                        devolveExemplarLivro = acervo.pesquisar(devolveExemplarLivro);

                        Console.Write("Insira o Tombo do exemplar que deseja devolver: ");
                        int tomboExemplarDevolve = int.Parse(Console.ReadLine());

                        Exemplar exemplarDevolver = new Exemplar();

                        foreach (Exemplar e in devolveExemplarLivro.Exemplares)
                        {
                            if (e.Tombo.Equals(tomboExemplarDevolve))
                            {
                                exemplarDevolver = e;
                            }
                        }

                        exemplarDevolver.devolver();

                        break;
                }
            } while (key != 0);
        }
    }
}
