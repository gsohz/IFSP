using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ED_Transporte
{
    public partial class Transporte : Form
    {
        private Terminal terminal = new Terminal();
        private static System.Timers.Timer attTimer = new System.Timers.Timer(3*1000);
        public Transporte()
        {
            InitializeComponent();
            attTimer.Elapsed += attLogs;
            attTimer.Enabled = true;
            attTimer.AutoReset = true;
            attTimer.Start();
        }


        delegate void attLogsCallback(object sender, ElapsedEventArgs e);
        void attLogs(object sender, ElapsedEventArgs e)
        {
            if (InvokeRequired)
            {
                attLogsCallback callback = attLogs;
                Invoke(callback, sender, e);
            } else
            {
                boxFilaVeiculos.Text = terminal.listaVeiculos().Replace("\n", Environment.NewLine);
                boxFilaVisitantes.Text = terminal.listaVisitantes().Replace("\n", Environment.NewLine);
            }
        }

        private void btnRegistraVeiculo_Click(object sender, EventArgs e)
        {
            int placa, lotacao;
            string condutor;

            placa = int.Parse(inptPlaca.Text);
            lotacao = int.Parse(inptLotacao.Text);
            condutor = inptCondutor.Text;

            Veiculo veiculo = new Veiculo(placa, lotacao, condutor);
            if (terminal.adicionarVeiculo(veiculo))
            {
                boxConsole.Text = "Adicionado com sucesso";
                boxFilaVeiculos.Text = terminal.listaVeiculos().Replace("\n", Environment.NewLine);
            } else
            {
                boxConsole.Text = "Este veículo já foi adicionado";
            }
            
        }

        private void btnRegistraVisitante_Click(object sender, EventArgs e)
        {
            int inscricao;

            inscricao = int.Parse(inptInscricao.Text);

            Visitante visitante = new Visitante(inscricao);
            if (terminal.adicionarVisitante(visitante))
            {
                boxConsole.Text = "Adicionado com sucesso";
                boxFilaVisitantes.Text = terminal.listaVisitantes().Replace("\n", Environment.NewLine);
                boxFilaVeiculos.Text = terminal.listaVeiculos().Replace("\n", Environment.NewLine);
            }
            else
            {
                boxConsole.Text = "Este visitante já está na fila";
            }
        }

        private void btnFinalizaJornada_Click(object sender, EventArgs e)
        {
            boxConsole.Text = terminal.finalizarJornada().Replace("\n", Environment.NewLine);
        }

       
    }
}
