using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Acesso
{
    class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public Usuario()
        {
            Ambientes = new List<Ambiente>();
        }

        public Usuario(int id)
        {
            Id = id;
        }

        public bool concederPermissao(Ambiente ambiente)
        {
            bool addPermissao = true;
            foreach (Ambiente a in Ambientes)
            {
                if (a.Equals(ambiente))
                {
                    addPermissao = false;
                    return addPermissao;
                }
            }

            Ambientes.Add(ambiente);
            return addPermissao;
        }

        public bool revogarPermissao(Ambiente ambiente)
        {
            Ambientes.Remove(ambiente);
            bool remov = true;

            foreach (Ambiente a in Ambientes)
            {
                if (a.Equals(ambiente))
                {
                    remov = false;
                    return remov;
                }
            }

            return remov;
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Usuario)obj).Id);
        }
    }
}
