using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Atendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();
        public Form1()
        {
            InitializeComponent();
        }

        private void ListarSenhasGeradas()
        {
            txtBSenhas.Clear();
            foreach (Senha senha in senhas.FilaSenhas)
            {
                txtBSenhas.AppendText(senha.DadosParciais());
                txtBSenhas.AppendText(Environment.NewLine);
            }
        }

        private void ListarSenhasAtendimentos()
        {
            txtBAtendimentos.Clear();
            foreach (Guiche guiche in guiches.ListaGuiches)
            {
                foreach (Senha senha in guiche.Atendimentos)
                {
                    txtBAtendimentos.AppendText(senha.DadosCompletos() + " - Guichê: " + (guiche.Id + 1));
                    txtBAtendimentos.AppendText(Environment.NewLine);
                }
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.Gerar();
            ListarSenhasGeradas();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = guiches.ListaGuiches.Count();
            Guiche guiche = new Guiche(id);
            guiches.Adicionar(guiche);
            lblNumGuiches.Text = guiches.ListaGuiches.Count().ToString();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            if(senhas.FilaSenhas.Count == 0)
            {
                txtBAtendimentos.Text = "Não existem senhas na fila";
                return;
            }

            if(guiches.ListaGuiches.Count == 0)
            {
                txtBAtendimentos.Text = "Não existem guichês ativos";
                return;
            }

            if (txtIGuiche.Text == "")
            {
                txtBAtendimentos.Text = "Especifique um guichê maior ou igual a 1";
                return;
            }

            int guicheId = Int32.Parse(txtIGuiche.Text) - 1;

            if(guiches.ListaGuiches.Any(g => g.Id == guicheId))
            {
                txtBAtendimentos.Text = "true";
                Guiche guiche = guiches.ListaGuiches[guicheId];
                if (guiche.Chamar(senhas.FilaSenhas))
                {
                    ListarSenhasAtendimentos();
                }
            } else
            {
                txtBAtendimentos.Text = "Este guichê não foi adicionado";
            }
            ListarSenhasGeradas();
        }

        private void btnListSenha_Click(object sender, EventArgs e)
        {
            ListarSenhasGeradas();
        }

        private void btnListAtendimentos_Click(object sender, EventArgs e)
        {
            ListarSenhasAtendimentos();
        }
    }
}
