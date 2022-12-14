using System;
using System.Collections.Generic;
using System.Text;

namespace ED_LOCACAO.Classes
{
    class Contratos
    {
        private List<Locacao> locacoes;

        internal List<Locacao> Locacoes { get => locacoes; set => locacoes = value; }

        public Contratos()
        {
            Locacoes = new List<Locacao>();
        }

        public void cadastrarContrato(Locacao locacao)
        {
            locacao.Id = Locacoes.Count + 1;
            Locacoes.Add(locacao);
        }

        public string consultarContratos()
        {
            string resultadoConsultaContratos = "";

            if (Locacoes.Count == 0)
            {
                resultadoConsultaContratos += "Não existem contratos\n";
                return resultadoConsultaContratos.Replace("\n", Environment.NewLine);
            }

            foreach(Locacao locacao in Locacoes)
            {
                resultadoConsultaContratos += $"ID: {locacao.Id} / PREVISÃO: {locacao.Dt_saida} - {locacao.Dt_retorno} / TIPO: {locacao.TipoNecessario.Desc} / Qtde: {locacao.QtdeNecessaria} / EM VIGENCIA: {locacao.EstaEmVigencia}\n";
                if(locacao.Equipamentos.Count > 0)
                {
                    resultadoConsultaContratos += $"Itens contratados em ID: {locacao.Id}:\n";
                    foreach(Equipamento equipamento in locacao.Equipamentos)
                    {
                        resultadoConsultaContratos += $"{equipamento.Id} - {equipamento.Desc}\n";
                    }
                }
                resultadoConsultaContratos += "\n";
            }

            return resultadoConsultaContratos.Replace("\n", Environment.NewLine);
        }

        public string consultarContratosLiberados()
        {
            string resultadoConsultaContratosLiberados = "";

            int k = 0;

            foreach (Locacao locacao in Locacoes)
            {
                if (locacao.EstaEmVigencia)
                {
                    k++;
                    resultadoConsultaContratosLiberados += $"ID: {locacao.Id} / PREVISÃO: {locacao.Dt_saida} - {locacao.Dt_retorno} / TIPO: {locacao.TipoNecessario.Desc} / Qtde: {locacao.QtdeNecessaria} / EM VIGENCIA: {locacao.EstaEmVigencia}\n";

                    resultadoConsultaContratosLiberados += $"Itens contratados em ID: {locacao.Id}:\n";
                    foreach (Equipamento equipamento in locacao.Equipamentos)
                    {
                        resultadoConsultaContratosLiberados += $"{equipamento.Id} - {equipamento.Desc}\n";
                    }
                    resultadoConsultaContratosLiberados += "\n\n";
                    
                }
            }

            if(k == 0)
            {
                resultadoConsultaContratosLiberados += "Não existem contratos liberados\n";
                return resultadoConsultaContratosLiberados.Replace("\n", Environment.NewLine);
            }

            return resultadoConsultaContratosLiberados.Replace("\n", Environment.NewLine);
        }

        public Locacao pesquisaContrato(Locacao locacao)
        {
            Locacao aux = new Locacao();
            foreach(Locacao l in Locacoes)
            {
                if (l.Equals(locacao))
                {
                    return aux = l;
                }
            }

            return aux;
        }

        public void liberarContrato(Locacao locacao)
        {
            locacao.Equipamentos = locacao.TipoNecessario.liberarEquipamentosDisponiveis(locacao.QtdeNecessaria);
            if(locacao.Equipamentos.Count == 0)
            {
                return;
            }
            locacao.EstaEmVigencia = true;
        }

        public void devolverEquipamentosContrato(Locacao locacao)
        {
            locacao.TipoNecessario.devolverEquipamento(locacao.Equipamentos);
            locacao.EstaEmVigencia = false;
            Locacoes.Remove(locacao);
        }
    }
}
