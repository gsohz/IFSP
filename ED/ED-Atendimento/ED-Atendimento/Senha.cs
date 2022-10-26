using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Atendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public Senha(int id)
        {
            Id = id;
            DataGerac = DateTime.Now;
            HoraGerac = DateTime.Now; //.ToLongTimeString()
        }

        public string DadosParciais()
        {
            return Id + " - " + DataGerac.ToShortDateString() + " - " + HoraGerac.ToLongTimeString();
        }

        public string DadosCompletos()
        {
            return DadosParciais() + " - " + DataAtend + " - " + HoraAtend.ToLongTimeString();
        }
    }
}
