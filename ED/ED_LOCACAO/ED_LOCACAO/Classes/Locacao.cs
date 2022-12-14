using System;
using System.Collections.Generic;
using System.Text;

namespace ED_LOCACAO.Classes
{
    class Locacao
    {
        private int id;
        private DateTime dt_saida;
        private DateTime dt_retorno;
        private TipoEquipamento tipoNecessario;
        private int qtdeNecessaria;
        private bool estaEmVigencia;
        private Stack<Equipamento> equipamentos;

        public int Id { get => id; set => id = value; }
        public DateTime Dt_saida { get => dt_saida; set => dt_saida = value; }
        public DateTime Dt_retorno { get => dt_retorno; set => dt_retorno = value; }
        internal Stack<Equipamento> Equipamentos { get => equipamentos; set => equipamentos = value; }
        internal TipoEquipamento TipoNecessario { get => tipoNecessario; set => tipoNecessario = value; }
        public int QtdeNecessaria { get => qtdeNecessaria; set => qtdeNecessaria = value; }
        public bool EstaEmVigencia { get => estaEmVigencia; set => estaEmVigencia = value; }

        public Locacao()
        {
            Id = -1;
        }
        public Locacao(int id)
        {
            Id = id;
        }        
        public Locacao(DateTime dt_saida, DateTime dt_retorno, TipoEquipamento tipoNecessario, int qtdeNecessaria)
        {
            Id = 0;
            Dt_saida = dt_saida;
            Dt_retorno = dt_retorno;
            TipoNecessario = tipoNecessario;
            QtdeNecessaria = qtdeNecessaria;
            EstaEmVigencia = false;
            Equipamentos = new Stack<Equipamento>();
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(((Locacao)obj).Id);
        }
    }
}
