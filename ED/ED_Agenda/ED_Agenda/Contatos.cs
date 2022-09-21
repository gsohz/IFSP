using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Agenda
{
    class Contatos
    {
        private List<Contato> agenda;

        internal List<Contato> Agenda { get => agenda; set => agenda = value; }

        public Contatos()
        {
            Agenda = new List<Contato>();
        }
        public bool Adicionar(Contato c)
        {
            bool add = false;
            Agenda.Add(c);

            foreach(Contato contato in Agenda)
            {
                if (contato.Equals(c))
                {
                    add = true;
                    return add;
                }
            }
            return add;
        }

        public Contato Pesquisar(Contato c)
        {
            Contato aux = new Contato();

            foreach (Contato contato in Agenda)
            {
                if (contato.Equals(c))
                {
                    
                    aux = contato;
                    return aux;
                }
            }
            return aux;
        }

        public bool Alterar(Contato c)
        {
            bool updt = false;
            foreach (Contato contato in Agenda)
            {
                if (contato.Equals(c))
                {
                    contato.Email = c.Email;
                    contato.Nome = c.Nome;
                    contato.DtNasc = c.DtNasc;
                    contato.Telefones = c.Telefones;
                    updt = true;
                    return updt;
                }
            }

            return updt;
        }

        public bool Remover(Contato c)
        {
            Agenda.Remove(c);
            bool remov = true;

            foreach (Contato contato in Agenda)
            {
                if (contato.Equals(c))
                {
                    remov = false;
                    return remov;
                }
            }
            return remov;
        }


    }
}
