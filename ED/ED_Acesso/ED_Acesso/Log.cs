using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Acesso
{
    class Log
    {
        private DateTime dtAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public DateTime DtAcesso { get => dtAcesso; set => dtAcesso = value; }
        public bool TipoAcesso { get => tipoAcesso; set => tipoAcesso = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public Log(Usuario usuario, bool tipoAcesso)
        {
            dtAcesso = DateTime.Now;
            Usuario = usuario;
            TipoAcesso = tipoAcesso;
        }
    }
}
