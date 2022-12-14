using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ED_LOCACAO.Classes;
using System.Windows.Forms;

namespace ED_LOCACAO
{
    public partial class Form1 : Form
    {
        Estoque estoque = new Estoque();
        Contratos contratos = new Contratos();
        List<Equipamento> idsEquipamentosQuebrados = new List<Equipamento>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTipoEquipamento_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtInptIdTipoEquipamento.Text);
            double locacao = double.Parse(txtInptPrecoLocacaoTipoEquipamento.Text);
            string desc = txtInptDescTipoEquipamento.Text;

            TipoEquipamento tipo = new TipoEquipamento(id, locacao, desc);

            TipoEquipamento verificaExistencia = new TipoEquipamento(id);
            verificaExistencia = estoque.pesquisaTipoEquipamento(verificaExistencia);

            if (verificaExistencia.Id != -1)
            {
                txtBoxOutput.Text = "Já existe um tipo com este ID";
                return;
            }

            estoque.cadastrarTipoEquipamento(tipo);

            txtBoxOutput.Text = "Tipo cadastrado com sucesso";
        }

        private void btnPesquisaIdTipoEquipamento_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtInptIdTipoEquipamento.Text);

            TipoEquipamento tipo = new TipoEquipamento(id);

            tipo = estoque.pesquisaTipoEquipamento(tipo);

            if(tipo.Id == -1)
            {
                txtBoxOutput.Text = "Tipo informado não encontrado";
                return;
            }

            txtBoxOutput.Text = estoque.consultarTipoEquipamento(tipo);
        }

        private void btnAddEquipamento_Click(object sender, EventArgs e)
        {
            int idTipo = int.Parse(txtInptIdTipoEquipamentoEquipamento.Text);

            TipoEquipamento tipo = new TipoEquipamento(idTipo);

            tipo = estoque.pesquisaTipoEquipamento(tipo);

            if (tipo.Id == -1)
            {
                txtBoxOutput.Text = "Tipo informado não encontrado";
                return;
            }

            int id = int.Parse(txtInptIdEquipamento.Text);
            string desc = txtInptDescEquipamento.Text;

            Equipamento equipamento = new Equipamento(id, desc);

            Equipamento verificaExistencia = new Equipamento(id);
            verificaExistencia = tipo.pesquisaEquipamento(verificaExistencia);

            if (verificaExistencia.Id != -1)
            {
                txtBoxOutput.Text = "Já existe um equipamento com este ID";
                return;
            }

            tipo.cadastrarEquipamento(equipamento);

            txtBoxOutput.Text = "Equipamento cadastrado";
        }

        private void btnAddContrato_Click(object sender, EventArgs e)
        {
            int idTipoNecessario = int.Parse(txtInptIdTipoNecessContrato.Text);

            TipoEquipamento tipo = new TipoEquipamento(idTipoNecessario);

            tipo = estoque.pesquisaTipoEquipamento(tipo);

            if (tipo.Id == -1)
            {
                txtBoxOutput.Text = "Tipo informado não encontrado";
                return;
            }

            int diaSaida, mesSaida, anoSaida, diaRetorno, mesRetorno, anoRetorno;

            diaSaida = int.Parse(txtInptDiaPrevSaidaContrato.Text);
            mesSaida = int.Parse(txtInptMesPrevSaidaContrato.Text);
            anoSaida = int.Parse(txtInptAnoPrevSaidaContrato.Text);

            diaRetorno = int.Parse(txtInptDiaPrevRetornoContrato.Text);
            mesRetorno = int.Parse(txtInptMesPrevRetornoContrato.Text);
            anoRetorno = int.Parse(txtInptAnoPrevRetornoContrato.Text);

            DateTime dt_saida = new DateTime(anoSaida, mesSaida, diaSaida);
            DateTime dt_retorno = new DateTime(anoRetorno, mesRetorno, diaRetorno);

            int qtdeNecessaria = int.Parse(txtInptQtdeNecessContrato.Text);

            Locacao locacao = new Locacao(dt_saida, dt_retorno, tipo, qtdeNecessaria);

            contratos.cadastrarContrato(locacao);

            txtBoxOutput.Text = "Contrato cadastrado";
        }

        private void btnLiberaContrato_Click(object sender, EventArgs e)
        {
            int idContrato = int.Parse(txtInptIdLiberarContrato.Text);

            Locacao contrato = new Locacao(idContrato);

            contrato = contratos.pesquisaContrato(contrato);

            if (contrato.Id == -1)
            {
                txtBoxOutput.Text = "Contrato informado não encontrado";
                return;
            }

            if (contrato.EstaEmVigencia)
            {
                txtBoxOutput.Text = "O contrato informado já está em vigência";
                return;
            }

            contratos.liberarContrato(contrato);

            if (!contrato.EstaEmVigencia)
            {
                txtBoxOutput.Text = "Não foi possível liberar contrato, possivelmente não existe equipamentos disponíveis";
                return;
            }

            txtBoxOutput.Text = "Contrato liberado";
        }

        private void btnPesquisaTodosContratos_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = contratos.consultarContratos();
        }

        private void btnPesquisaLiberadosContratos_Click(object sender, EventArgs e)
        {
            txtBoxOutput.Text = contratos.consultarContratosLiberados();
        }

        private void btnAdicionaEquipamentoQuebrado_Click(object sender, EventArgs e)
        {
            int idEquipamento = int.Parse(txtInptIdEquipamentoQuebrado.Text);

            Equipamento equipamentoQuebrado = new Equipamento(idEquipamento);

            idsEquipamentosQuebrados.Add(equipamentoQuebrado);
        }

        private void btnDevolverEquipamentos_Click(object sender, EventArgs e)
        {
            int idContrato = int.Parse(txtInptIdLiberarContrato.Text);

            Locacao contrato = new Locacao(idContrato);

            contrato = contratos.pesquisaContrato(contrato);

            if (contrato.Id == -1)
            {
                txtBoxOutput.Text = "Contrato informado não encontrado";
                return;
            }

            if(idsEquipamentosQuebrados.Count > 0)
            {
                foreach(Equipamento equipamentoQuebrado in idsEquipamentosQuebrados)
                {
                    foreach (Equipamento equipamento in contrato.Equipamentos)
                    {
                        if (equipamento.Equals(equipamentoQuebrado))
                        {
                            equipamento.EstaAvariado = true;
                        }
                    }
                }
            }

            contratos.devolverEquipamentosContrato(contrato);
            idsEquipamentosQuebrados = new List<Equipamento>();
            txtBoxOutput.Text = "Devolução concluída";
        }
    }
}
