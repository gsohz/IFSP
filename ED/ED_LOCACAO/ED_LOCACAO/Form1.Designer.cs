
namespace ED_LOCACAO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInptIdEquipamento = new System.Windows.Forms.TextBox();
            this.txtInptDescEquipamento = new System.Windows.Forms.TextBox();
            this.btnAddEquipamento = new System.Windows.Forms.Button();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.lblCadastrarEquipamento = new System.Windows.Forms.Label();
            this.lblIdEquipamento = new System.Windows.Forms.Label();
            this.lblDescEquipamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrevSaidaContrato = new System.Windows.Forms.Label();
            this.lblPrevRetornoContrato = new System.Windows.Forms.Label();
            this.lblTipoNecessContrato = new System.Windows.Forms.Label();
            this.lblQtdeNecessContrato = new System.Windows.Forms.Label();
            this.txtInptDiaPrevSaidaContrato = new System.Windows.Forms.TextBox();
            this.txtInptMesPrevSaidaContrato = new System.Windows.Forms.TextBox();
            this.txtInptAnoPrevSaidaContrato = new System.Windows.Forms.TextBox();
            this.lblBarraPrevSaida1 = new System.Windows.Forms.Label();
            this.lblBarraPrevSaida2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInptAnoPrevRetornoContrato = new System.Windows.Forms.TextBox();
            this.txtInptMesPrevRetornoContrato = new System.Windows.Forms.TextBox();
            this.txtInptDiaPrevRetornoContrato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInptIdEquipamento
            // 
            this.txtInptIdEquipamento.Location = new System.Drawing.Point(141, 63);
            this.txtInptIdEquipamento.Name = "txtInptIdEquipamento";
            this.txtInptIdEquipamento.Size = new System.Drawing.Size(125, 27);
            this.txtInptIdEquipamento.TabIndex = 0;
            // 
            // txtInptDescEquipamento
            // 
            this.txtInptDescEquipamento.Location = new System.Drawing.Point(141, 100);
            this.txtInptDescEquipamento.Name = "txtInptDescEquipamento";
            this.txtInptDescEquipamento.Size = new System.Drawing.Size(125, 27);
            this.txtInptDescEquipamento.TabIndex = 1;
            // 
            // btnAddEquipamento
            // 
            this.btnAddEquipamento.Location = new System.Drawing.Point(47, 149);
            this.btnAddEquipamento.Name = "btnAddEquipamento";
            this.btnAddEquipamento.Size = new System.Drawing.Size(196, 29);
            this.btnAddEquipamento.TabIndex = 2;
            this.btnAddEquipamento.Text = "Adicionar Equipamento";
            this.btnAddEquipamento.UseVisualStyleBackColor = true;
            this.btnAddEquipamento.Click += new System.EventHandler(this.btnAddEquipamento_Click);
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtBoxOutput.Location = new System.Drawing.Point(89, 208);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.Size = new System.Drawing.Size(154, 63);
            this.txtBoxOutput.TabIndex = 3;
            // 
            // lblCadastrarEquipamento
            // 
            this.lblCadastrarEquipamento.AutoSize = true;
            this.lblCadastrarEquipamento.Location = new System.Drawing.Point(63, 19);
            this.lblCadastrarEquipamento.Name = "lblCadastrarEquipamento";
            this.lblCadastrarEquipamento.Size = new System.Drawing.Size(165, 20);
            this.lblCadastrarEquipamento.TabIndex = 4;
            this.lblCadastrarEquipamento.Text = "Cadastrar Equipamento";
            // 
            // lblIdEquipamento
            // 
            this.lblIdEquipamento.AutoSize = true;
            this.lblIdEquipamento.Location = new System.Drawing.Point(32, 66);
            this.lblIdEquipamento.Name = "lblIdEquipamento";
            this.lblIdEquipamento.Size = new System.Drawing.Size(27, 20);
            this.lblIdEquipamento.TabIndex = 5;
            this.lblIdEquipamento.Text = "ID:";
            // 
            // lblDescEquipamento
            // 
            this.lblDescEquipamento.AutoSize = true;
            this.lblDescEquipamento.Location = new System.Drawing.Point(32, 101);
            this.lblDescEquipamento.Name = "lblDescEquipamento";
            this.lblDescEquipamento.Size = new System.Drawing.Size(81, 20);
            this.lblDescEquipamento.TabIndex = 6;
            this.lblDescEquipamento.Text = "Descrição: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastrar Contrato";
            // 
            // lblPrevSaidaContrato
            // 
            this.lblPrevSaidaContrato.AutoSize = true;
            this.lblPrevSaidaContrato.Location = new System.Drawing.Point(346, 64);
            this.lblPrevSaidaContrato.Name = "lblPrevSaidaContrato";
            this.lblPrevSaidaContrato.Size = new System.Drawing.Size(106, 20);
            this.lblPrevSaidaContrato.TabIndex = 8;
            this.lblPrevSaidaContrato.Text = "Previsão saída:";
            // 
            // lblPrevRetornoContrato
            // 
            this.lblPrevRetornoContrato.AutoSize = true;
            this.lblPrevRetornoContrato.Location = new System.Drawing.Point(346, 102);
            this.lblPrevRetornoContrato.Name = "lblPrevRetornoContrato";
            this.lblPrevRetornoContrato.Size = new System.Drawing.Size(120, 20);
            this.lblPrevRetornoContrato.TabIndex = 9;
            this.lblPrevRetornoContrato.Text = "Previsão retorno:";
            // 
            // lblTipoNecessContrato
            // 
            this.lblTipoNecessContrato.AutoSize = true;
            this.lblTipoNecessContrato.Location = new System.Drawing.Point(346, 140);
            this.lblTipoNecessContrato.Name = "lblTipoNecessContrato";
            this.lblTipoNecessContrato.Size = new System.Drawing.Size(135, 20);
            this.lblTipoNecessContrato.TabIndex = 10;
            this.lblTipoNecessContrato.Text = "ID tipo necessário: ";
            // 
            // lblQtdeNecessContrato
            // 
            this.lblQtdeNecessContrato.AutoSize = true;
            this.lblQtdeNecessContrato.Location = new System.Drawing.Point(346, 178);
            this.lblQtdeNecessContrato.Name = "lblQtdeNecessContrato";
            this.lblQtdeNecessContrato.Size = new System.Drawing.Size(122, 20);
            this.lblQtdeNecessContrato.TabIndex = 11;
            this.lblQtdeNecessContrato.Text = "Qtde necessário: ";
            // 
            // txtInptDiaPrevSaidaContrato
            // 
            this.txtInptDiaPrevSaidaContrato.Location = new System.Drawing.Point(501, 61);
            this.txtInptDiaPrevSaidaContrato.Name = "txtInptDiaPrevSaidaContrato";
            this.txtInptDiaPrevSaidaContrato.Size = new System.Drawing.Size(48, 27);
            this.txtInptDiaPrevSaidaContrato.TabIndex = 12;
            // 
            // txtInptMesPrevSaidaContrato
            // 
            this.txtInptMesPrevSaidaContrato.Location = new System.Drawing.Point(568, 61);
            this.txtInptMesPrevSaidaContrato.Name = "txtInptMesPrevSaidaContrato";
            this.txtInptMesPrevSaidaContrato.Size = new System.Drawing.Size(48, 27);
            this.txtInptMesPrevSaidaContrato.TabIndex = 13;
            // 
            // txtInptAnoPrevSaidaContrato
            // 
            this.txtInptAnoPrevSaidaContrato.Location = new System.Drawing.Point(637, 62);
            this.txtInptAnoPrevSaidaContrato.Name = "txtInptAnoPrevSaidaContrato";
            this.txtInptAnoPrevSaidaContrato.Size = new System.Drawing.Size(48, 27);
            this.txtInptAnoPrevSaidaContrato.TabIndex = 14;
            // 
            // lblBarraPrevSaida1
            // 
            this.lblBarraPrevSaida1.AutoSize = true;
            this.lblBarraPrevSaida1.Location = new System.Drawing.Point(552, 64);
            this.lblBarraPrevSaida1.Name = "lblBarraPrevSaida1";
            this.lblBarraPrevSaida1.Size = new System.Drawing.Size(15, 20);
            this.lblBarraPrevSaida1.TabIndex = 15;
            this.lblBarraPrevSaida1.Text = "/";
            // 
            // lblBarraPrevSaida2
            // 
            this.lblBarraPrevSaida2.AutoSize = true;
            this.lblBarraPrevSaida2.Location = new System.Drawing.Point(620, 64);
            this.lblBarraPrevSaida2.Name = "lblBarraPrevSaida2";
            this.lblBarraPrevSaida2.Size = new System.Drawing.Size(15, 20);
            this.lblBarraPrevSaida2.TabIndex = 16;
            this.lblBarraPrevSaida2.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "/";
            // 
            // txtInptAnoPrevRetornoContrato
            // 
            this.txtInptAnoPrevRetornoContrato.Location = new System.Drawing.Point(637, 99);
            this.txtInptAnoPrevRetornoContrato.Name = "txtInptAnoPrevRetornoContrato";
            this.txtInptAnoPrevRetornoContrato.Size = new System.Drawing.Size(48, 27);
            this.txtInptAnoPrevRetornoContrato.TabIndex = 19;
            // 
            // txtInptMesPrevRetornoContrato
            // 
            this.txtInptMesPrevRetornoContrato.Location = new System.Drawing.Point(568, 98);
            this.txtInptMesPrevRetornoContrato.Name = "txtInptMesPrevRetornoContrato";
            this.txtInptMesPrevRetornoContrato.Size = new System.Drawing.Size(48, 27);
            this.txtInptMesPrevRetornoContrato.TabIndex = 18;
            // 
            // txtInptDiaPrevRetornoContrato
            // 
            this.txtInptDiaPrevRetornoContrato.Location = new System.Drawing.Point(501, 98);
            this.txtInptDiaPrevRetornoContrato.Name = "txtInptDiaPrevRetornoContrato";
            this.txtInptDiaPrevRetornoContrato.Size = new System.Drawing.Size(48, 27);
            this.txtInptDiaPrevRetornoContrato.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInptAnoPrevRetornoContrato);
            this.Controls.Add(this.txtInptMesPrevRetornoContrato);
            this.Controls.Add(this.txtInptDiaPrevRetornoContrato);
            this.Controls.Add(this.lblBarraPrevSaida2);
            this.Controls.Add(this.lblBarraPrevSaida1);
            this.Controls.Add(this.txtInptAnoPrevSaidaContrato);
            this.Controls.Add(this.txtInptMesPrevSaidaContrato);
            this.Controls.Add(this.txtInptDiaPrevSaidaContrato);
            this.Controls.Add(this.lblQtdeNecessContrato);
            this.Controls.Add(this.lblTipoNecessContrato);
            this.Controls.Add(this.lblPrevRetornoContrato);
            this.Controls.Add(this.lblPrevSaidaContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescEquipamento);
            this.Controls.Add(this.lblIdEquipamento);
            this.Controls.Add(this.lblCadastrarEquipamento);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.btnAddEquipamento);
            this.Controls.Add(this.txtInptDescEquipamento);
            this.Controls.Add(this.txtInptIdEquipamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInptIdEquipamento;
        private System.Windows.Forms.TextBox inptDescEquipamento;
        private System.Windows.Forms.TextBox txtInptDescEquipamento;
        private System.Windows.Forms.Button btnAddEquipamento;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Label lblCadastrarEquipamento;
        private System.Windows.Forms.Label lblIdEquipamento;
        private System.Windows.Forms.Label lblDescEquipamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrevSaidaContrato;
        private System.Windows.Forms.Label lblPrevRetornoContrato;
        private System.Windows.Forms.Label lblTipoNecessContrato;
        private System.Windows.Forms.Label lblQtdeNecessContrato;
        private System.Windows.Forms.TextBox txtInptDiaPrevSaidaContrato;
        private System.Windows.Forms.TextBox txtInptMesPrevSaidaContrato;
        private System.Windows.Forms.TextBox txtInptAnoPrevSaidaContrato;
        private System.Windows.Forms.Label lblBarraPrevSaida1;
        private System.Windows.Forms.Label lblBarraPrevSaida2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInptAnoPrevRetornoContrato;
        private System.Windows.Forms.TextBox txtInptMesPrevRetornoContrato;
        private System.Windows.Forms.TextBox txtInptDiaPrevRetornoContrato;
    }
}