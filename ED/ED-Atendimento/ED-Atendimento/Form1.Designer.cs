
namespace ED_Atendimento
{
    partial class Form1
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnListSenha = new System.Windows.Forms.Button();
            this.btnListAtendimentos = new System.Windows.Forms.Button();
            this.txtIGuiche = new System.Windows.Forms.TextBox();
            this.lblGuiche = new System.Windows.Forms.Label();
            this.txtBAtendimentos = new System.Windows.Forms.TextBox();
            this.txtBSenhas = new System.Windows.Forms.TextBox();
            this.lblQtdGuiches = new System.Windows.Forms.Label();
            this.lblNumGuiches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(77, 21);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(94, 29);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(596, 21);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(94, 29);
            this.btnChamar.TabIndex = 1;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnListSenha
            // 
            this.btnListSenha.Location = new System.Drawing.Point(36, 311);
            this.btnListSenha.Name = "btnListSenha";
            this.btnListSenha.Size = new System.Drawing.Size(176, 29);
            this.btnListSenha.TabIndex = 3;
            this.btnListSenha.Text = "Listar Senhas";
            this.btnListSenha.UseVisualStyleBackColor = true;
            this.btnListSenha.Click += new System.EventHandler(this.btnListSenha_Click);
            // 
            // btnListAtendimentos
            // 
            this.btnListAtendimentos.Location = new System.Drawing.Point(512, 311);
            this.btnListAtendimentos.Name = "btnListAtendimentos";
            this.btnListAtendimentos.Size = new System.Drawing.Size(196, 29);
            this.btnListAtendimentos.TabIndex = 4;
            this.btnListAtendimentos.Text = "Listar Atendimentos";
            this.btnListAtendimentos.UseVisualStyleBackColor = true;
            this.btnListAtendimentos.Click += new System.EventHandler(this.btnListAtendimentos_Click);
            // 
            // txtIGuiche
            // 
            this.txtIGuiche.Location = new System.Drawing.Point(493, 22);
            this.txtIGuiche.Name = "txtIGuiche";
            this.txtIGuiche.Size = new System.Drawing.Size(72, 27);
            this.txtIGuiche.TabIndex = 5;
            // 
            // lblGuiche
            // 
            this.lblGuiche.AutoSize = true;
            this.lblGuiche.Location = new System.Drawing.Point(431, 25);
            this.lblGuiche.Name = "lblGuiche";
            this.lblGuiche.Size = new System.Drawing.Size(56, 20);
            this.lblGuiche.TabIndex = 6;
            this.lblGuiche.Text = "Chichê:";
            // 
            // txtBAtendimentos
            // 
            this.txtBAtendimentos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBAtendimentos.Location = new System.Drawing.Point(410, 80);
            this.txtBAtendimentos.Multiline = true;
            this.txtBAtendimentos.Name = "txtBAtendimentos";
            this.txtBAtendimentos.ReadOnly = true;
            this.txtBAtendimentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBAtendimentos.Size = new System.Drawing.Size(437, 201);
            this.txtBAtendimentos.TabIndex = 7;
            // 
            // txtBSenhas
            // 
            this.txtBSenhas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBSenhas.Location = new System.Drawing.Point(12, 80);
            this.txtBSenhas.Multiline = true;
            this.txtBSenhas.Name = "txtBSenhas";
            this.txtBSenhas.ReadOnly = true;
            this.txtBSenhas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBSenhas.Size = new System.Drawing.Size(224, 201);
            this.txtBSenhas.TabIndex = 8;
            // 
            // lblQtdGuiches
            // 
            this.lblQtdGuiches.AutoSize = true;
            this.lblQtdGuiches.Location = new System.Drawing.Point(274, 80);
            this.lblQtdGuiches.Name = "lblQtdGuiches";
            this.lblQtdGuiches.Size = new System.Drawing.Size(99, 20);
            this.lblQtdGuiches.TabIndex = 9;
            this.lblQtdGuiches.Text = "Qtde guichês:";
            // 
            // lblNumGuiches
            // 
            this.lblNumGuiches.AutoSize = true;
            this.lblNumGuiches.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumGuiches.Location = new System.Drawing.Point(297, 118);
            this.lblNumGuiches.Name = "lblNumGuiches";
            this.lblNumGuiches.Size = new System.Drawing.Size(52, 62);
            this.lblNumGuiches.TabIndex = 10;
            this.lblNumGuiches.Text = "0";
            this.lblNumGuiches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 362);
            this.Controls.Add(this.lblNumGuiches);
            this.Controls.Add(this.lblQtdGuiches);
            this.Controls.Add(this.txtBSenhas);
            this.Controls.Add(this.txtBAtendimentos);
            this.Controls.Add(this.lblGuiche);
            this.Controls.Add(this.txtIGuiche);
            this.Controls.Add(this.btnListAtendimentos);
            this.Controls.Add(this.btnListSenha);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnListSenha;
        private System.Windows.Forms.Button btnListAtendimentos;
        private System.Windows.Forms.TextBox txtIGuiche;
        private System.Windows.Forms.Label lblGuiche;
        private System.Windows.Forms.TextBox txtBAtendimentos;
        private System.Windows.Forms.TextBox txtBSenhas;
        private System.Windows.Forms.Label lblQtdGuiches;
        private System.Windows.Forms.Label lblNumGuiches;
    }
}

