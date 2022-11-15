using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Medicamento
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        internal Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        public Medicamento()
        {
            Id = -1;
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            Id = id;
            Nome = nome;
            Laboratorio = laboratorio;
            Lotes = new Queue<Lote>();
        }

        public int qtdeDisponivel()
        {
            int total = 0;
            //DateTime hoje = DateTime.Now;
            foreach(Lote l in Lotes)
            {
                total += l.Qtde;
                /*
                if(l.Venc.Year > hoje.Year)
                {
                    total += l.Qtde;
                } else if (l.Venc.Year == hoje.Year && l.Venc.Month >= hoje.Month && l.Venc.Day > hoje.Day)
                {
                    total += l.Qtde;
                }
                */
            }
            return total;
        }

        public void comprar(Lote lote)
        {
            Lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {
            int qtdDisponivel = qtdeDisponivel();
            if (qtdDisponivel == 0 || qtdDisponivel < qtde)
            {
                return false;
            }

            int aux = qtde;
            int totalLote;

            foreach (Lote l in Lotes)
            {
                while(aux != 0)
                {
                    aux -= l.Qtde;
                    totalLote = l.Qtde - qtde;
                    if(totalLote <= 0)
                    {
                        Lotes.Dequeue();
                    }
                }
            }

            bool medicamentosVendidos = (qtdDisponivel - qtde == 0);
            return medicamentosVendidos;
        }

        public string toString()
        {
            return Id + "-" + Nome + "-" + Laboratorio + "-" + qtdeDisponivel();
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Medicamento)obj).Id);
        }
    }
}
