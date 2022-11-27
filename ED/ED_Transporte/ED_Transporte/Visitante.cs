using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Transporte
{
    class Visitante
    {
        private int inscricao;

        public int Inscricao { get => inscricao; set => inscricao = value; }
    
        public Visitante()
        {
            Inscricao = -1;
        }

        public Visitante(int inscricao)
        {
            Inscricao = inscricao;
        }

        public override bool Equals(object obj)
        {
            return Inscricao.Equals(((Visitante)obj).Inscricao);
        }
    }
}
