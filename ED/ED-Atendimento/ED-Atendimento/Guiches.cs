using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Atendimento
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }

        public Guiches()
        {
            ListaGuiches = new List<Guiche>();
        }

        public void Adicionar(Guiche guiche)
        {
            ListaGuiches.Add(guiche);
        }
    }
}
