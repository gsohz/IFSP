using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ED_Acervo
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public int Tombo { get => tombo; set => tombo = value; }
        internal List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }

        public Exemplar()
        {
            Tombo = -1;
            Emprestimos = new List<Emprestimo>();
        }
        public Exemplar(int tombo)
        {
            Tombo = tombo;
            Emprestimos = new List<Emprestimo>();
        }
        public bool disponivel()
        {
            bool disponivel = true;
            Emprestimo aux = Emprestimos.LastOrDefault();

            if(aux != null)
            {
                disponivel = (aux.DtDevolucao != new DateTime(1,1,1));
                return disponivel;
            }

            return disponivel;
        }

        public bool emprestrar()
        {
            if (disponivel())
            {
                Console.Write("Insira a data de hoje no formato aaaa-mm-dd: ");
                String dataHoje = Console.ReadLine();

                Emprestimo emprestimo = new Emprestimo(dataHoje);
                Emprestimos.Add(emprestimo);
            }
            else
            {
                Console.Write("Esse exemplar não está disponível para emprestimo.");
           }
            return disponivel();
        }

        public bool devolver(){
            if(disponivel() == false){
              Console.Write("Insira a data de hoje no formato aaaa-mmm-dd: ");
              String dataHoje = Console.ReadLine();
                Emprestimos.Last().DtDevolucao = (DateTime.Parse(dataHoje));
            }else {
                Console.Write("Esse exemplar ainda não foi emprestado.");
            }
            return disponivel();
        }
        public int qtdeEmprestimos()
        {
            int contador = 0;
            foreach (Emprestimo e in Emprestimos)
            {
                contador++;
            }
            return contador;
        }
    }
}
