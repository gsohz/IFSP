using System;
using System.Collections.Generic;
using System.Text;

namespace ED_LOCACAO.Classes
{
    class TipoEquipamento
    {
        private int id;
        private double locacao;
        private string desc;
        private List<Equipamento> equipamentos;
        private Queue<Equipamento> equipamentosDisponiveis;

        public int Id { get => id; set => id = value; }
        public double Locacao { get => locacao; set => locacao = value; }
        public string Desc { get => desc; set => desc = value; }
        internal List<Equipamento> Equipamentos { get => equipamentos; set => equipamentos = value; }
        internal Queue<Equipamento> EquipamentosDisponiveis { get => equipamentosDisponiveis; set => equipamentosDisponiveis = value; }

        public TipoEquipamento(int id, double locacao, string desc)
        {
            Id = id;
            Locacao = locacao;
            Desc = desc;
            Equipamentos = new List<Equipamento>();
            EquipamentosDisponiveis = new Queue<Equipamento>();
        }

        public void cadastrarEquipamento(Equipamento equipamento)
        {
            Equipamentos.Add(equipamento);
            EquipamentosDisponiveis.Enqueue(equipamento);
        }

        public Stack<Equipamento> liberarEquipamentosDisponiveis(int qtde)
        {
            Stack<Equipamento> equipamentosDisponiveis = new Stack<Equipamento>();
            List<Equipamento> aux = new List<Equipamento>();
            int k = 0;

            foreach(Equipamento e in EquipamentosDisponiveis)
            {
                if(k == qtde)
                {
                    break;
                }

                equipamentosDisponiveis.Push(e);
                e.EstaLocado = true;
                aux.Add(e);
                k++;
                
            }

            for(int i = 0; i < qtde; i++)
            {
                EquipamentosDisponiveis.Dequeue();
            }

            return equipamentosDisponiveis;
        }
       
        public void devolverEquipamento(Stack<Equipamento> equipamentos)
        {

            for(int i = 0; i < equipamentos.Count; i++)
            {
                Equipamento aux = equipamentos.Pop();
                aux.EstaLocado = false;
                EquipamentosDisponiveis.Enqueue(aux);
            }
        }
        

        public override bool Equals(object obj)
        {
            return Id.Equals(((TipoEquipamento)obj).Id);
        }
    }
}
