using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Atendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public Guiche()
        {
            Atendimentos = new Queue<Senha>();
            Id = 0;
        }

        public Guiche(int id)
        {
            Atendimentos = new Queue<Senha>();
            Id = id;
        }

        public bool Chamar(Queue<Senha> filaSenhas)
        {
            Senha chamado = filaSenhas.Dequeue();
            chamado.DataAtend = DateTime.Now;
            chamado.HoraAtend = DateTime.Now;
            Atendimentos.Enqueue(chamado);

            return Atendimentos.Contains(chamado);
        }
    }
}
