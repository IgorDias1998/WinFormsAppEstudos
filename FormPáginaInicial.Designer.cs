namespace WinFormsAppEstudos
{
    partial class FormPáginaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPáginaInicial));
            buttonRealizarVenda = new Button();
            buttonCadastrarProduto = new Button();
            buttonCadastrarCliente = new Button();
            SuspendLayout();
            // 
            // buttonRealizarVenda
            // 
            buttonRealizarVenda.BackgroundImage = (Image)resources.GetObject("buttonRealizarVenda.BackgroundImage");
            buttonRealizarVenda.Location = new Point(35, 46);
            buttonRealizarVenda.Name = "buttonRealizarVenda";
            buttonRealizarVenda.Size = new Size(189, 188);
            buttonRealizarVenda.TabIndex = 0;
            buttonRealizarVenda.UseVisualStyleBackColor = true;
            buttonRealizarVenda.Click += buttonRealizarVenda_Click;
            // 
            // buttonCadastrarProduto
            // 
            buttonCadastrarProduto.BackgroundImage = (Image)resources.GetObject("buttonCadastrarProduto.BackgroundImage");
            buttonCadastrarProduto.Location = new Point(311, 46);
            buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            buttonCadastrarProduto.Size = new Size(189, 188);
            buttonCadastrarProduto.TabIndex = 1;
            buttonCadastrarProduto.UseVisualStyleBackColor = true;
            buttonCadastrarProduto.Click += buttonCadastrarProduto_Click;
            // 
            // buttonCadastrarCliente
            // 
            buttonCadastrarCliente.BackgroundImage = (Image)resources.GetObject("buttonCadastrarCliente.BackgroundImage");
            buttonCadastrarCliente.Cursor = Cursors.Hand;
            buttonCadastrarCliente.Location = new Point(578, 46);
            buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            buttonCadastrarCliente.Size = new Size(189, 188);
            buttonCadastrarCliente.TabIndex = 2;
            buttonCadastrarCliente.UseVisualStyleBackColor = true;
            buttonCadastrarCliente.Click += buttonCadastrarCliente_Click;
            // 
            // FormPáginaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 298);
            Controls.Add(buttonCadastrarCliente);
            Controls.Add(buttonCadastrarProduto);
            Controls.Add(buttonRealizarVenda);
            Name = "FormPáginaInicial";
            Text = "FormPáginaInicial";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRealizarVenda;
        private Button buttonCadastrarProduto;
        private Button buttonCadastrarCliente;
    }
}