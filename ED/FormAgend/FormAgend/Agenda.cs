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
        private List<Telefone> telefones = new List<Telefone>();
        public Agenda()
        {
            InitializeComponent();
        }

        private void buttonTelAdd_Click(object sender, EventArgs e)
        {
            string num, tipo;
            bool temPrincipal = false, principal;

            principal = checkBoxTelPrincipal.Checked;

            foreach(Telefone tel in telefones)
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
                telefones.Add(addTelefone);
                textBoxReturnTel.AppendText("tel: " + num + ", tipo: " + tipo + ", principal: " + (principal ? "Sim" : "Não"));
                textBoxReturnTel.AppendText(Environment.NewLine);
            }

            
        }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            string email, nome;
            int dia, mes, ano;
            List<Telefone> tels = telefones;

            email = textBoxEmail.Text;
            nome = textBoxNome.Text;
            dia = Int32.Parse(textBoxDiaNasc.Text);
            mes = Int32.Parse(textBoxMesNasc.Text);
            ano = Int32.Parse(textBoxAnoNasc.Text);

            Data nasc = new Data(dia, mes, ano);
            Contato addContato = new Contato(email, nome, nasc, tels);
            textBoxReturnAgenda.Text = (agenda.Adicionar(addContato) ? "Contato adicionado com sucesso" : "Não foi possível adicionar o contato");
            telefones.Clear();
            textBoxReturnTel.Text = "";
        }


    }
}
