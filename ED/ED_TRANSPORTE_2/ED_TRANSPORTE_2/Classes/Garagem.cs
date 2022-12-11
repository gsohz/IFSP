using System;
using System.Collections.Generic;
using System.Text;

namespace ED_TRANSPORTE_2
{
    class Garagem
    {
        private int id;
        private string desc;
        private Stack<Van> vans;

        public int Id { get => id; set => id = value; }
        public string Desc { get => desc; set => desc = value; }
        internal Stack<Van> Vans { get => vans; set => vans = value; }

        public Garagem()
        {
            id = -1;
            vans = new Stack<Van>();
        }

        public Garagem(int id)
        {
            Id = id;
            vans = new Stack<Van>();
        }

        public Garagem(int id, string desc)
        {
            Id = id;
            Desc = desc;
            vans = new Stack<Van>();
        }

        public void adicionarVanNaGaragem(Van van)
        {
            Vans.Push(van);
        }

        public Van removerVanDaGaragem()
        {
            return Vans.Pop();
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Garagem)obj).Id);
        }
    }
}
