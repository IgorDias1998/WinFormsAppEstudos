namespace WinFormsAppEstudos
{
    partial class FormCadastroCliente
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
            labelNomeCliente = new Label();
            textBoxNomeCliente = new TextBox();
            labelEndereco = new Label();
            textBox1 = new TextBox();
            labelTelefone = new Label();
            textBoxTelefone = new TextBox();
            buttonSalvarCliente = new Button();
            labelBuscarCliente = new Label();
            textBox2 = new TextBox();
            listViewClientes = new ListView();
            buttonBuscarCliente = new Button();
            buttonExcluirCliente = new Button();
            SuspendLayout();
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.AutoSize = true;
            labelNomeCliente.Location = new Point(12, 27);
            labelNomeCliente.Name = "labelNomeCliente";
            labelNomeCliente.Size = new Size(51, 19);
            labelNomeCliente.TabIndex = 0;
            labelNomeCliente.Text = "Nome";
            labelNomeCliente.Click += labelCadastroCliente_Click;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(12, 49);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(311, 26);
            textBoxNomeCliente.TabIndex = 1;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(12, 95);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(73, 19);
            labelEndereco.TabIndex = 2;
            labelEndereco.Text = "Endereço";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 26);
            textBox1.TabIndex = 3;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(12, 163);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(71, 19);
            labelTelefone.TabIndex = 4;
            labelTelefone.Text = "Telefone";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(12, 185);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(311, 26);
            textBoxTelefone.TabIndex = 5;
            // 
            // buttonSalvarCliente
            // 
            buttonSalvarCliente.BackColor = Color.SteelBlue;
            buttonSalvarCliente.ForeColor = SystemColors.ControlLightLight;
            buttonSalvarCliente.Location = new Point(152, 227);
            buttonSalvarCliente.Name = "buttonSalvarCliente";
            buttonSalvarCliente.Size = new Size(171, 34);
            buttonSalvarCliente.TabIndex = 12;
            buttonSalvarCliente.Text = "Salvar cliente";
            buttonSalvarCliente.UseVisualStyleBackColor = false;
            // 
            // labelBuscarCliente
            // 
            labelBuscarCliente.AutoSize = true;
            labelBuscarCliente.Location = new Point(381, 27);
            labelBuscarCliente.Name = "labelBuscarCliente";
            labelBuscarCliente.Size = new Size(107, 19);
            labelBuscarCliente.TabIndex = 7;
            labelBuscarCliente.Text = "Buscar cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(381, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 26);
            textBox2.TabIndex = 8;
            // 
            // listViewClientes
            // 
            listViewClientes.Location = new Point(381, 95);
            listViewClientes.Name = "listViewClientes";
            listViewClientes.Size = new Size(527, 166);
            listViewClientes.TabIndex = 9;
            listViewClientes.UseCompatibleStateImageBehavior = false;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.BackColor = Color.SteelBlue;
            buttonBuscarCliente.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarCliente.ForeColor = SystemColors.ButtonHighlight;
            buttonBuscarCliente.Location = new Point(737, 41);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(171, 34);
            buttonBuscarCliente.TabIndex = 12;
            buttonBuscarCliente.Text = "Buscar";
            buttonBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // buttonExcluirCliente
            // 
            buttonExcluirCliente.BackColor = Color.Red;
            buttonExcluirCliente.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluirCliente.ForeColor = Color.White;
            buttonExcluirCliente.Location = new Point(737, 267);
            buttonExcluirCliente.Name = "buttonExcluirCliente";
            buttonExcluirCliente.Size = new Size(171, 34);
            buttonExcluirCliente.TabIndex = 12;
            buttonExcluirCliente.Text = "Excluir Cliente";
            buttonExcluirCliente.UseVisualStyleBackColor = false;
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(942, 310);
            Controls.Add(buttonExcluirCliente);
            Controls.Add(buttonBuscarCliente);
            Controls.Add(listViewClientes);
            Controls.Add(textBox2);
            Controls.Add(labelBuscarCliente);
            Controls.Add(buttonSalvarCliente);
            Controls.Add(textBoxTelefone);
            Controls.Add(labelTelefone);
            Controls.Add(textBox1);
            Controls.Add(labelEndereco);
            Controls.Add(textBoxNomeCliente);
            Controls.Add(labelNomeCliente);
            Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormCadastroCliente";
            Text = "FormCadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeCliente;
        private TextBox textBoxNomeCliente;
        private Label labelEndereco;
        private TextBox textBox1;
        private Label labelTelefone;
        private TextBox textBoxTelefone;
        private Button buttonSalvarCliente;
        private Label labelBuscarCliente;
        private TextBox textBox2;
        private ListView listViewClientes;
        private Button buttonBuscarCliente;
        private Button buttonExcluirCliente;
    }
}