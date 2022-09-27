using System;
using System.Collections.Generic;
using System.Text;

namespace FormAgend
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }

        public Data(int dia, int mes, int ano)
        {
            SetData(dia, mes, ano);
        }
        public void SetData(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        public override string ToString()
        {

            string data = Dia.ToString().PadLeft(2, '0') + '/' + Mes.ToString().PadLeft(2, '0') + '/' + Ano.ToString().PadLeft(2, '0');

            return data;
        }
    }
}
