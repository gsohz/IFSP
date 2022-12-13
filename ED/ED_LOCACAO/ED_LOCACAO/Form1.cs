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
        TipoEquipamento t = new TipoEquipamento(1, 10, "xu");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEquipamento_Click(object sender, EventArgs e)
        {
            Equipamento eq = new Equipamento(int.Parse(txtInptIdEquipamento.Text), txtInptDescEquipamento.Text);
            
            t.cadastrarEquipamento(eq);
            t.cadastrarEquipamento(new Equipamento(2, "este 2"));
            t.cadastrarEquipamento(new Equipamento(3, "teste3"));


            txtBoxOutput.Text = t.liberarEquipamentosDisponiveis(2).Peek().Desc;
        }

        
    }
}
