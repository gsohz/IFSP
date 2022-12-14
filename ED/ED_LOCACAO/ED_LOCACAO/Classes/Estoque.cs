using System;
using System.Collections.Generic;
using System.Text;

namespace ED_LOCACAO.Classes
{
    class Estoque
    {
        private List<TipoEquipamento> tiposEquipamentos;

        internal List<TipoEquipamento> TiposEquipamentos { get => tiposEquipamentos; set => tiposEquipamentos = value; }

        public Estoque()
        {
            TiposEquipamentos = new List<TipoEquipamento>();
        }
        public void cadastrarTipoEquipamento(TipoEquipamento tipo)
        {
            TiposEquipamentos.Add(tipo);
        }
        public string consultarTipoEquipamento(TipoEquipamento tipoEquipamento)
        {
            string resultadoConsulta = "";
            foreach(TipoEquipamento tipo in TiposEquipamentos)
            {
                if (tipo.Equals(tipoEquipamento))
                {
                    resultadoConsulta += $"Equipamento tipo {tipo.Desc} com locação R${tipo.Locacao}\nItens dentro deste tipo:\n";

                    if(tipo.Equipamentos.Count == 0)
                    {
                        resultadoConsulta += "Ainda não possui equipamentos registrados\n";
                    } else
                    {
                        foreach(Equipamento equipamento in tipo.Equipamentos)
                        {
                            resultadoConsulta += $"{equipamento.Id} - {equipamento.Desc} - Avariado: {equipamento.EstaAvariado} / Locado: {equipamento.EstaLocado}\n";
                        }
                    }

                }
            }

            return resultadoConsulta.Replace("\n", Environment.NewLine);
        }

        public TipoEquipamento pesquisaTipoEquipamento(TipoEquipamento tipo)
        {
            TipoEquipamento aux = new TipoEquipamento();
            foreach(TipoEquipamento e in TiposEquipamentos)
            {
                if (e.Equals(tipo))
                {
                    return aux = e;
                }
            }

            return aux;
        }

    }
}
