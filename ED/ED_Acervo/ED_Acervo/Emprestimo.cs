using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Acervo
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }

        public Emprestimo(string dataHoje)
        {
            DtEmprestimo = DateTime.Parse(dataHoje);
            DtDevolucao = new DateTime(1,1,1);
        }
    }
}
