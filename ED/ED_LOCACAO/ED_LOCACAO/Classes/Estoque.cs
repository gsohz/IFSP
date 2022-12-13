using System;
using System.Collections.Generic;
using System.Text;

namespace ED_LOCACAO.Classes
{
    class Estoque
    {
        private List<TipoEquipamento> tipoEquipamentos;

        internal List<TipoEquipamento> TipoEquipamentos { get => tipoEquipamentos; set => tipoEquipamentos = value; }

        public string consultarTipoEquipamento(TipoEquipamento tipoEquipamento)
        {
            string resultadoConsulta = "";
            foreach(TipoEquipamento tipo in TipoEquipamentos)
            {
                if (tipo.Equals(tipoEquipamento))
                {
                    resultadoConsulta += $"Equipamento tipo {tipo.Desc} com locação R${tipo.Locacao}\nItens dentro deste tipo:\n";
                    foreach(Equipamento equipamento in tipo.Equipamentos)
                    {
                        resultadoConsulta += $"{equipamento.Id} - {equipamento.Desc} - Avariado: {equipamento.EstaAvariado} Locado: {equipamento.EstaLocado}\n";
                    }
                }
            }

            return resultadoConsulta.Replace("\n", Environment.NewLine);
        }

    }
}
