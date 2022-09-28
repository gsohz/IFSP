using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAgend
{
    public partial class Agenda : Form
    {
        private Contatos agenda = new Contatos();
        private List<Telefone> addTelefones = new List<Telefone>();
        public Agenda()
        {
            InitializeComponent();
        }

        private void buttonTelAdd_Click(object sender, EventArgs e)
        {
            string num, tipo;
            bool temPrincipal = false, principal;

            principal = checkBoxTelPrincipal.Checked;

            foreach(Telefone tel in addTelefones)
            {
                if (tel.Principal.Equals(true))
                {
                    temPrincipal = true;
                    break;
                }
            }

            if(temPrincipal && principal)
            {
                labelErrorTel.Text = "ERRO: Já existe um telefone principal";
            } else
            {
                num = textBoxTelNum.Text;
                tipo = comboBoxTelTipo.Text;

                Telefone addTelefone = new Telefone(tipo, num, principal);
                addTelefones.Add(addTelefone);
                textBoxReturnTel.AppendText("tel: " + num + ", tipo: " + tipo + ", principal: " + (principal ? "Sim" : "Não"));
                textBoxReturnTel.AppendText(Environment.NewLine);
                limpaCamposTel();
            }

            
        }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            string email, nome;
            int dia, mes, ano;
            List<Telefone> tels = new List<Telefone>(addTelefones);

            email = textBoxEmail.Text;
            nome = textBoxNome.Text;
            dia = Int32.Parse(textBoxDiaNasc.Text);
            mes = Int32.Parse(textBoxMesNasc.Text);
            ano = Int32.Parse(textBoxAnoNasc.Text);

            Data nasc = new Data(dia, mes, ano);
            Contato addContato = new Contato(email, nome, nasc, tels);
            textBoxReturnAgenda.Text = (agenda.Adicionar(addContato) ? "Contato adicionado com sucesso" : "Não foi possível adicionar o contato");
            textBoxReturnTel.Text = "";
            limpaCampos();
            addTelefones.Clear();
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            string email;

            email = textBoxEmail.Text;

            Contato pesquisaContato = new Contato(email);
            pesquisaContato = agenda.Pesquisar(pesquisaContato);


            if (pesquisaContato.Email != "-1")
            {
                addTelefones = new List<Telefone>(pesquisaContato.Telefones);
                textBoxEmail.Text = pesquisaContato.Email;
                textBoxNome.Text = pesquisaContato.Nome;
                textBoxDiaNasc.Text = (pesquisaContato.DtNasc.Dia).ToString();
                textBoxMesNasc.Text = (pesquisaContato.DtNasc.Mes).ToString();
                textBoxAnoNasc.Text = (pesquisaContato.DtNasc.Ano).ToString();

                textBoxReturnTel.Text = "";
                foreach (Telefone tel in pesquisaContato.Telefones)
                {
                    textBoxReturnTel.AppendText("tel: " + tel.Numero + ", tipo: " + tel.Tipo + ", principal: " + (tel.Principal ? "Sim" : "Não"));
                    textBoxReturnTel.AppendText(Environment.NewLine);
                }

                textBoxReturnAgenda.Text = pesquisaContato.ToString();
     
            }
            else
            {
                textBoxReturnAgenda.Text = ("Não foi possível localizar esse email: " + email);
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            string email;
            email = textBoxEmail.Text;

            Contato alteraContato = new Contato(email);
            alteraContato = agenda.Pesquisar(alteraContato);

            if (alteraContato.Email != "-1")
            {
                string nome;
                int dia, mes, ano;
                List<Telefone> tels = new List<Telefone>(addTelefones);

                nome = textBoxNome.Text;
                dia = Int32.Parse(textBoxDiaNasc.Text);
                mes = Int32.Parse(textBoxMesNasc.Text);
                ano = Int32.Parse(textBoxAnoNasc.Text);

                alteraContato.Email = email;
                alteraContato.Nome = nome;
                alteraContato.DtNasc.Dia = dia;
                alteraContato.DtNasc.Mes = mes;
                alteraContato.DtNasc.Ano = ano;
                alteraContato.Telefones = tels;

                textBoxReturnAgenda.AppendText(Environment.NewLine);
                textBoxReturnAgenda.AppendText("Atualizado com sucesso novos dados do contato:");
                textBoxReturnAgenda.AppendText(Environment.NewLine);
                textBoxReturnAgenda.AppendText(alteraContato.ToString());
                limpaCampos();
                addTelefones.Clear();
            } else
            {
                textBoxReturnAgenda.Text = ("Não foi possível localizar esse email: " + email);
            }
        }
        
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string email;
            email = textBoxEmail.Text;

            Contato removeContato = new Contato(email);
            removeContato = agenda.Pesquisar(removeContato);

            if (removeContato.Email != "-1")
            {
                textBoxReturnAgenda.Text = (agenda.Remover(removeContato) ? "Contato removido com sucesso" : "Não foi possível remover o contato");
            }
            else
            {
                textBoxReturnAgenda.Text = ("Não foi possível localizar esse email: " + email);
            }
            limpaCampos();
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            textBoxReturnAgenda.Text = "--------------------AGENDA------------------------";
            textBoxReturnAgenda.AppendText(Environment.NewLine);
            textBoxReturnAgenda.AppendText("Qtde de contatos na agenda: " + agenda.Agenda.Count);
            foreach (Contato contato in agenda.Agenda)
            {
                textBoxReturnAgenda.AppendText(Environment.NewLine);
                textBoxReturnAgenda.AppendText(contato.ToString());
            }
            textBoxReturnAgenda.AppendText(Environment.NewLine);
            textBoxReturnAgenda.AppendText("--------------------------------------------------");
        }

        private void limpaCampos()
        {
            textBoxEmail.Text = "";
            textBoxNome.Text = "";
            textBoxDiaNasc.Text = "";
            textBoxMesNasc.Text = "";
            textBoxAnoNasc.Text = "";
            textBoxTelNum.Text = "";
            checkBoxTelPrincipal.Checked = false;
            comboBoxTelTipo.Text = "";
        }

        private void limpaCamposTel()
        {
            textBoxTelNum.Text = "";
            checkBoxTelPrincipal.Checked = false;
            comboBoxTelTipo.Text = "";
        }
    }
}
