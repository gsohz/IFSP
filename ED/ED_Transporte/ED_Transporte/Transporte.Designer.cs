
namespace ED_Transporte
{
    partial class Transporte
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlaca = new System.Windows.Forms.Label();
            this.inptPlaca = new System.Windows.Forms.TextBox();
            this.inptCondutor = new System.Windows.Forms.TextBox();
            this.lblCondutor = new System.Windows.Forms.Label();
            this.inptLotacao = new System.Windows.Forms.TextBox();
            this.lblLotacao = new System.Windows.Forms.Label();
            this.boxFilaVeiculos = new System.Windows.Forms.TextBox();
            this.lblFilaVeiculos = new System.Windows.Forms.Label();
            this.btnRegistraVeiculo = new System.Windows.Forms.Button();
            this.inptInscricao = new System.Windows.Forms.TextBox();
            this.lblInscricao = new System.Windows.Forms.Label();
            this.btnRegistraVisitante = new System.Windows.Forms.Button();
            this.lblFilaVisitantes = new System.Windows.Forms.Label();
            this.boxFilaVisitantes = new System.Windows.Forms.TextBox();
            this.btnFinalizaJornada = new System.Windows.Forms.Button();
            this.lblConsole = new System.Windows.Forms.Label();
            this.boxConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(33, 18);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(124, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa do veículo: ";
            // 
            // inptPlaca
            // 
            this.inptPlaca.Location = new System.Drawing.Point(33, 44);
            this.inptPlaca.Name = "inptPlaca";
            this.inptPlaca.Size = new System.Drawing.Size(142, 27);
            this.inptPlaca.TabIndex = 1;
            // 
            // inptCondutor
            // 
            this.inptCondutor.Location = new System.Drawing.Point(33, 104);
            this.inptCondutor.Name = "inptCondutor";
            this.inptCondutor.Size = new System.Drawing.Size(142, 27);
            this.inptCondutor.TabIndex = 3;
            // 
            // lblCondutor
            // 
            this.lblCondutor.AutoSize = true;
            this.lblCondutor.Location = new System.Drawing.Point(33, 79);
            this.lblCondutor.Name = "lblCondutor";
            this.lblCondutor.Size = new System.Drawing.Size(151, 20);
            this.lblCondutor.TabIndex = 2;
            this.lblCondutor.Text = "Condutor do veículo: ";
            // 
            // inptLotacao
            // 
            this.inptLotacao.Location = new System.Drawing.Point(33, 164);
            this.inptLotacao.Name = "inptLotacao";
            this.inptLotacao.Size = new System.Drawing.Size(142, 27);
            this.inptLotacao.TabIndex = 5;
            // 
            // lblLotacao
            // 
            this.lblLotacao.AutoSize = true;
            this.lblLotacao.Location = new System.Drawing.Point(33, 140);
            this.lblLotacao.Name = "lblLotacao";
            this.lblLotacao.Size = new System.Drawing.Size(142, 20);
            this.lblLotacao.TabIndex = 4;
            this.lblLotacao.Text = "Lotação do veículo: ";
            // 
            // boxFilaVeiculos
            // 
            this.boxFilaVeiculos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boxFilaVeiculos.Enabled = false;
            this.boxFilaVeiculos.Location = new System.Drawing.Point(208, 180);
            this.boxFilaVeiculos.Multiline = true;
            this.boxFilaVeiculos.Name = "boxFilaVeiculos";
            this.boxFilaVeiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxFilaVeiculos.Size = new System.Drawing.Size(273, 144);
            this.boxFilaVeiculos.TabIndex = 6;
            // 
            // lblFilaVeiculos
            // 
            this.lblFilaVeiculos.AutoSize = true;
            this.lblFilaVeiculos.Location = new System.Drawing.Point(289, 150);
            this.lblFilaVeiculos.Name = "lblFilaVeiculos";
            this.lblFilaVeiculos.Size = new System.Drawing.Size(111, 20);
            this.lblFilaVeiculos.TabIndex = 7;
            this.lblFilaVeiculos.Text = "Fila de Veículos";
            // 
            // btnRegistraVeiculo
            // 
            this.btnRegistraVeiculo.Location = new System.Drawing.Point(208, 68);
            this.btnRegistraVeiculo.Name = "btnRegistraVeiculo";
            this.btnRegistraVeiculo.Size = new System.Drawing.Size(106, 63);
            this.btnRegistraVeiculo.TabIndex = 8;
            this.btnRegistraVeiculo.Text = "Registrar Veículo";
            this.btnRegistraVeiculo.UseVisualStyleBackColor = true;
            this.btnRegistraVeiculo.Click += new System.EventHandler(this.btnRegistraVeiculo_Click);
            // 
            // inptInscricao
            // 
            this.inptInscricao.Location = new System.Drawing.Point(435, 44);
            this.inptInscricao.Name = "inptInscricao";
            this.inptInscricao.Size = new System.Drawing.Size(155, 27);
            this.inptInscricao.TabIndex = 11;
            // 
            // lblInscricao
            // 
            this.lblInscricao.AutoSize = true;
            this.lblInscricao.Location = new System.Drawing.Point(435, 18);
            this.lblInscricao.Name = "lblInscricao";
            this.lblInscricao.Size = new System.Drawing.Size(155, 20);
            this.lblInscricao.TabIndex = 10;
            this.lblInscricao.Text = "Inscrição do visitante: ";
            // 
            // btnRegistraVisitante
            // 
            this.btnRegistraVisitante.Location = new System.Drawing.Point(628, 73);
            this.btnRegistraVisitante.Name = "btnRegistraVisitante";
            this.btnRegistraVisitante.Size = new System.Drawing.Size(103, 52);
            this.btnRegistraVisitante.TabIndex = 12;
            this.btnRegistraVisitante.Text = "Registrar Visitante";
            this.btnRegistraVisitante.UseVisualStyleBackColor = true;
            this.btnRegistraVisitante.Click += new System.EventHandler(this.btnRegistraVisitante_Click);
            // 
            // lblFilaVisitantes
            // 
            this.lblFilaVisitantes.AutoSize = true;
            this.lblFilaVisitantes.Location = new System.Drawing.Point(584, 150);
            this.lblFilaVisitantes.Name = "lblFilaVisitantes";
            this.lblFilaVisitantes.Size = new System.Drawing.Size(120, 20);
            this.lblFilaVisitantes.TabIndex = 14;
            this.lblFilaVisitantes.Text = "Fila de Visitantes";
            // 
            // boxFilaVisitantes
            // 
            this.boxFilaVisitantes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boxFilaVisitantes.Enabled = false;
            this.boxFilaVisitantes.Location = new System.Drawing.Point(503, 180);
            this.boxFilaVisitantes.Multiline = true;
            this.boxFilaVisitantes.Name = "boxFilaVisitantes";
            this.boxFilaVisitantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxFilaVisitantes.Size = new System.Drawing.Size(273, 144);
            this.boxFilaVisitantes.TabIndex = 13;
            // 
            // btnFinalizaJornada
            // 
            this.btnFinalizaJornada.Location = new System.Drawing.Point(648, 419);
            this.btnFinalizaJornada.Name = "btnFinalizaJornada";
            this.btnFinalizaJornada.Size = new System.Drawing.Size(140, 29);
            this.btnFinalizaJornada.TabIndex = 9;
            this.btnFinalizaJornada.Text = "Finalizar Jornada";
            this.btnFinalizaJornada.UseVisualStyleBackColor = true;
            this.btnFinalizaJornada.Click += new System.EventHandler(this.btnFinalizaJornada_Click);
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Location = new System.Drawing.Point(33, 377);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(69, 20);
            this.lblConsole.TabIndex = 16;
            this.lblConsole.Text = "Console: ";
            // 
            // boxConsole
            // 
            this.boxConsole.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boxConsole.Enabled = false;
            this.boxConsole.Location = new System.Drawing.Point(108, 361);
            this.boxConsole.Multiline = true;
            this.boxConsole.Name = "boxConsole";
            this.boxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxConsole.Size = new System.Drawing.Size(318, 86);
            this.boxConsole.TabIndex = 15;
            // 
            // Transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.boxConsole);
            this.Controls.Add(this.lblFilaVisitantes);
            this.Controls.Add(this.boxFilaVisitantes);
            this.Controls.Add(this.btnRegistraVisitante);
            this.Controls.Add(this.inptInscricao);
            this.Controls.Add(this.lblInscricao);
            this.Controls.Add(this.btnFinalizaJornada);
            this.Controls.Add(this.btnRegistraVeiculo);
            this.Controls.Add(this.lblFilaVeiculos);
            this.Controls.Add(this.boxFilaVeiculos);
            this.Controls.Add(this.inptLotacao);
            this.Controls.Add(this.lblLotacao);
            this.Controls.Add(this.inptCondutor);
            this.Controls.Add(this.lblCondutor);
            this.Controls.Add(this.inptPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Name = "Transporte";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox inptPlaca;
        private System.Windows.Forms.TextBox inptCondutor;
        private System.Windows.Forms.Label lblCondutor;
        private System.Windows.Forms.TextBox inptLotacao;
        private System.Windows.Forms.Label lblLotacao;
        private System.Windows.Forms.TextBox boxFilaVeiculos;
        private System.Windows.Forms.Label lblFilaVeiculos;
        private System.Windows.Forms.Button btnRegistraVeiculo;
        private System.Windows.Forms.TextBox inptInscricao;
        private System.Windows.Forms.Label lblInscricao;
        private System.Windows.Forms.Button btnRegistraVisitante;
        private System.Windows.Forms.Label lblFilaVisitantes;
        private System.Windows.Forms.TextBox boxFilaVisitantes;
        private System.Windows.Forms.Button btnFinalizaJornada;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.TextBox boxConsole;
    }
}

