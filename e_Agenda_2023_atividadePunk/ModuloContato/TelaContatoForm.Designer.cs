namespace e_Agenda_2023_atividadePunk.ModuloContato
{
    partial class TelaContatoForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtid = new TextBox();
            label2 = new Label();
            txtnome = new TextBox();
            txttelefone = new TextBox();
            txtcargo = new TextBox();
            txtemail = new TextBox();
            txtempresa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(316, 241);
            btnGravar.MaximumSize = new Size(66, 43);
            btnGravar.MinimumSize = new Size(66, 43);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(66, 43);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(388, 241);
            btnCancelar.MaximumSize = new Size(66, 43);
            btnCancelar.MinimumSize = new Size(66, 43);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(66, 43);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 33);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "iD";
            // 
            // txtid
            // 
            txtid.Location = new Point(80, 30);
            txtid.Name = "txtid";
            txtid.Size = new Size(79, 23);
            txtid.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(80, 59);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(374, 23);
            txtnome.TabIndex = 5;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(80, 88);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(152, 23);
            txttelefone.TabIndex = 6;
            // 
            // txtcargo
            // 
            txtcargo.Location = new Point(80, 117);
            txtcargo.Name = "txtcargo";
            txtcargo.Size = new Size(152, 23);
            txtcargo.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(298, 88);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(156, 23);
            txtemail.TabIndex = 12;
            // 
            // txtempresa
            // 
            txtempresa.Location = new Point(298, 117);
            txtempresa.Name = "txtempresa";
            txtempresa.Size = new Size(156, 23);
            txtempresa.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 91);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 14;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 96);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 15;
            label4.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 120);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 17;
            label6.Text = "Empresa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 120);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 18;
            label7.Text = "Cargo";
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 306);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtempresa);
            Controls.Add(txtemail);
            Controls.Add(txtcargo);
            Controls.Add(txttelefone);
            Controls.Add(txtnome);
            Controls.Add(label2);
            Controls.Add(txtid);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            MaximizeBox = false;
            MaximumSize = new Size(507, 345);
            MinimizeBox = false;
            MinimumSize = new Size(507, 345);
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtid;
        private Label label2;
        private TextBox txtnome;
        private TextBox txttelefone;
        private TextBox txtcargo;
        private TextBox txtemail;
        private TextBox txtempresa;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}