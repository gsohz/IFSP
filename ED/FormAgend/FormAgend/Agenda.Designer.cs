
namespace FormAgend
{
    partial class Agenda
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNasc = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDiaNasc = new System.Windows.Forms.TextBox();
            this.labelBar1 = new System.Windows.Forms.Label();
            this.textBoxMesNasc = new System.Windows.Forms.TextBox();
            this.labelBar2 = new System.Windows.Forms.Label();
            this.textBoxAnoNasc = new System.Windows.Forms.TextBox();
            this.labelTelefones = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.textBoxTelNum = new System.Windows.Forms.TextBox();
            this.checkBoxTelPrincipal = new System.Windows.Forms.CheckBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonLista = new System.Windows.Forms.Button();
            this.textBoxReturnTel = new System.Windows.Forms.TextBox();
            this.textBoxReturnAgenda = new System.Windows.Forms.TextBox();
            this.labelContato = new System.Windows.Forms.Label();
            this.buttonTelAdd = new System.Windows.Forms.Button();
            this.comboBoxTelTipo = new System.Windows.Forms.ComboBox();
            this.labelErrorTel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 62);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 20);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "EMAIL: ";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(30, 101);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(59, 20);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "NOME: ";
            // 
            // labelNasc
            // 
            this.labelNasc.AutoSize = true;
            this.labelNasc.Location = new System.Drawing.Point(30, 137);
            this.labelNasc.Name = "labelNasc";
            this.labelNasc.Size = new System.Drawing.Size(95, 20);
            this.labelNasc.TabIndex = 2;
            this.labelNasc.Text = "DATA NASC: ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(133, 59);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(265, 27);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(133, 98);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(265, 27);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxDiaNasc
            // 
            this.textBoxDiaNasc.Location = new System.Drawing.Point(133, 134);
            this.textBoxDiaNasc.Name = "textBoxDiaNasc";
            this.textBoxDiaNasc.Size = new System.Drawing.Size(62, 27);
            this.textBoxDiaNasc.TabIndex = 5;
            // 
            // labelBar1
            // 
            this.labelBar1.AutoSize = true;
            this.labelBar1.Location = new System.Drawing.Point(201, 137);
            this.labelBar1.Name = "labelBar1";
            this.labelBar1.Size = new System.Drawing.Size(15, 20);
            this.labelBar1.TabIndex = 6;
            this.labelBar1.Text = "/";
            // 
            // textBoxMesNasc
            // 
            this.textBoxMesNasc.Location = new System.Drawing.Point(222, 134);
            this.textBoxMesNasc.Name = "textBoxMesNasc";
            this.textBoxMesNasc.Size = new System.Drawing.Size(63, 27);
            this.textBoxMesNasc.TabIndex = 7;
            // 
            // labelBar2
            // 
            this.labelBar2.AutoSize = true;
            this.labelBar2.Location = new System.Drawing.Point(291, 137);
            this.labelBar2.Name = "labelBar2";
            this.labelBar2.Size = new System.Drawing.Size(15, 20);
            this.labelBar2.TabIndex = 8;
            this.labelBar2.Text = "/";
            // 
            // textBoxAnoNasc
            // 
            this.textBoxAnoNasc.Location = new System.Drawing.Point(312, 134);
            this.textBoxAnoNasc.Name = "textBoxAnoNasc";
            this.textBoxAnoNasc.Size = new System.Drawing.Size(86, 27);
            this.textBoxAnoNasc.TabIndex = 9;
            // 
            // labelTelefones
            // 
            this.labelTelefones.AutoSize = true;
            this.labelTelefones.Location = new System.Drawing.Point(458, 26);
            this.labelTelefones.Name = "labelTelefones";
            this.labelTelefones.Size = new System.Drawing.Size(92, 20);
            this.labelTelefones.TabIndex = 10;
            this.labelTelefones.Text = "TELEFONES: ";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(458, 62);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(70, 20);
            this.labelNum.TabIndex = 11;
            this.labelNum.Text = "Número: ";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(458, 98);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(46, 20);
            this.labelTipo.TabIndex = 12;
            this.labelTipo.Text = "Tipo: ";
            // 
            // textBoxTelNum
            // 
            this.textBoxTelNum.Location = new System.Drawing.Point(534, 59);
            this.textBoxTelNum.Name = "textBoxTelNum";
            this.textBoxTelNum.Size = new System.Drawing.Size(143, 27);
            this.textBoxTelNum.TabIndex = 13;
            // 
            // checkBoxTelPrincipal
            // 
            this.checkBoxTelPrincipal.AutoSize = true;
            this.checkBoxTelPrincipal.Location = new System.Drawing.Point(700, 98);
            this.checkBoxTelPrincipal.Name = "checkBoxTelPrincipal";
            this.checkBoxTelPrincipal.Size = new System.Drawing.Size(88, 24);
            this.checkBoxTelPrincipal.TabIndex = 15;
            this.checkBoxTelPrincipal.Text = "Principal";
            this.checkBoxTelPrincipal.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(30, 181);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(59, 29);
            this.buttonNovo.TabIndex = 16;
            this.buttonNovo.Text = "NOVO";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(95, 181);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(73, 29);
            this.buttonGravar.TabIndex = 17;
            this.buttonGravar.Text = "GRAVAR";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(174, 181);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(74, 29);
            this.buttonExcluir.TabIndex = 18;
            this.buttonExcluir.Text = "EXCLUIR";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Location = new System.Drawing.Point(254, 181);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(94, 29);
            this.buttonPesquisa.TabIndex = 19;
            this.buttonPesquisa.Text = "PESQUISAR";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonLista
            // 
            this.buttonLista.Location = new System.Drawing.Point(354, 181);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(64, 29);
            this.buttonLista.TabIndex = 20;
            this.buttonLista.Text = "LISTAR";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // textBoxReturnTel
            // 
            this.textBoxReturnTel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxReturnTel.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxReturnTel.Location = new System.Drawing.Point(461, 141);
            this.textBoxReturnTel.Multiline = true;
            this.textBoxReturnTel.Name = "textBoxReturnTel";
            this.textBoxReturnTel.ReadOnly = true;
            this.textBoxReturnTel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReturnTel.Size = new System.Drawing.Size(326, 95);
            this.textBoxReturnTel.TabIndex = 21;
            // 
            // textBoxReturnAgenda
            // 
            this.textBoxReturnAgenda.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxReturnAgenda.Location = new System.Drawing.Point(20, 242);
            this.textBoxReturnAgenda.Multiline = true;
            this.textBoxReturnAgenda.Name = "textBoxReturnAgenda";
            this.textBoxReturnAgenda.ReadOnly = true;
            this.textBoxReturnAgenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReturnAgenda.Size = new System.Drawing.Size(767, 189);
            this.textBoxReturnAgenda.TabIndex = 22;
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Location = new System.Drawing.Point(30, 26);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(132, 20);
            this.labelContato.TabIndex = 23;
            this.labelContato.Text = "DADOS CONTATO:";
            // 
            // buttonTelAdd
            // 
            this.buttonTelAdd.Location = new System.Drawing.Point(683, 56);
            this.buttonTelAdd.Name = "buttonTelAdd";
            this.buttonTelAdd.Size = new System.Drawing.Size(111, 29);
            this.buttonTelAdd.TabIndex = 24;
            this.buttonTelAdd.Text = "ADICIONAR";
            this.buttonTelAdd.UseVisualStyleBackColor = true;
            this.buttonTelAdd.Click += new System.EventHandler(this.buttonTelAdd_Click);
            // 
            // comboBoxTelTipo
            // 
            this.comboBoxTelTipo.FormattingEnabled = true;
            this.comboBoxTelTipo.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Móvel"});
            this.comboBoxTelTipo.Location = new System.Drawing.Point(534, 94);
            this.comboBoxTelTipo.Name = "comboBoxTelTipo";
            this.comboBoxTelTipo.Size = new System.Drawing.Size(143, 28);
            this.comboBoxTelTipo.TabIndex = 25;
            // 
            // labelErrorTel
            // 
            this.labelErrorTel.AutoSize = true;
            this.labelErrorTel.Location = new System.Drawing.Point(462, 122);
            this.labelErrorTel.Name = "labelErrorTel";
            this.labelErrorTel.Size = new System.Drawing.Size(0, 20);
            this.labelErrorTel.TabIndex = 26;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelErrorTel);
            this.Controls.Add(this.comboBoxTelTipo);
            this.Controls.Add(this.buttonTelAdd);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.textBoxReturnAgenda);
            this.Controls.Add(this.textBoxReturnTel);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.checkBoxTelPrincipal);
            this.Controls.Add(this.textBoxTelNum);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelTelefones);
            this.Controls.Add(this.textBoxAnoNasc);
            this.Controls.Add(this.labelBar2);
            this.Controls.Add(this.textBoxMesNasc);
            this.Controls.Add(this.labelBar1);
            this.Controls.Add(this.textBoxDiaNasc);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelNasc);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelEmail);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNasc;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxDiaNasc;
        private System.Windows.Forms.Label labelBar1;
        private System.Windows.Forms.TextBox textBoxMesNasc;
        private System.Windows.Forms.Label labelBar2;
        private System.Windows.Forms.TextBox textBoxAnoNasc;
        private System.Windows.Forms.Label labelTelefones;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox textBoxTelNum;
        private System.Windows.Forms.CheckBox checkBoxTelPrincipal;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.Button buttonLista;
        private System.Windows.Forms.TextBox textBoxReturnTel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.Button buttonTelAdd;
        private System.Windows.Forms.ComboBox comboBoxTelTipo;
        private System.Windows.Forms.TextBox textBoxReturnAgenda;
        private System.Windows.Forms.Label labelErrorTel;
    }
}

