using System;
using System.Collections.Generic;
using System.Text;

namespace ED_LOCACAO.Classes
{
    class Equipamento
    {
        private int id;
        private bool estaAvariado;
        private bool estaLocado;
        private string desc;

        public int Id { get => id; set => id = value; }
        public bool EstaAvariado { get => estaAvariado; set => estaAvariado = value; }
        public bool EstaLocado { get => estaLocado; set => estaLocado = value; }
        public string Desc { get => desc; set => desc = value; }

        public Equipamento()
        {
            Id = -1;
        }
        public Equipamento(int id)
        {
            Id = id;
        }
        public Equipamento(int id, string desc)
        {
            Id = id;
            EstaAvariado = false;
            EstaLocado = false;
            Desc = desc;
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Equipamento)obj).Id);
        }
    }
}
