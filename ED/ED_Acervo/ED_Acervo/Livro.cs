using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Acervo
{
    class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public int ISBN { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }

        public Livro()
        {
            ISBN = -1;
            Titulo = null;
            Autor = null;
            Editora = null;
            Exemplares = new List<Exemplar>();
        }
        public Livro(string titulo)
        {
            Titulo = titulo;
            Exemplares = new List<Exemplar>();
        }
        public Livro(int isbn, string titulo, string autor)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Exemplares = new List<Exemplar>();
        }

        public void adicionarExemplar(Exemplar exemplar)
        {
            Exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return Exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int k = 0;
            foreach(Exemplar e in Exemplares)
            {
                if(e.disponivel() == true)
                {
                    k++;
                }
            }
            return k;
        }

        public int qtdeEmprestimos()
        {
            int total = 0;
            foreach(Exemplar e in Exemplares)
            {
                total += e.qtdeEmprestimos();
            }
            return total;
        }

        public double percDisponibilidade()
        {
            int disp = qtdeDisponiveis();
            int total = Exemplares.Count;
            double perc = Convert.ToDouble(disp) / Convert.ToDouble(total);
            perc *= 100;
            return (perc > 0 ? perc : 0);
        }

        public override bool Equals(object obj)
        {
            return Titulo.Equals(((Livro)obj).Titulo);
        }

    }
}
