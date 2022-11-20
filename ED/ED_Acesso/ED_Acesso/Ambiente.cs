using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Acesso
{
    class Ambiente
    {
        private int id;
        private string nome;
        private Queue<Log> logs;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Queue<Log> Logs { get => logs; set => logs = value; }

        public Ambiente()
        {
            Logs = new Queue<Log>();
        }

        public Ambiente(int id)
        {
            Id = id;
        }

        public void registrarLog(Log log)
        {
            if (Logs.Count > 100)
            {
                Logs.Dequeue();
            }

            Logs.Enqueue(log);
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Ambiente)obj).Id);
        }
    }
}
