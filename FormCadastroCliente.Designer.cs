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
            textBox1 = new TextBox();
            labelNome = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 26);
            textBox1.TabIndex = 2;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(14, 15);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(102, 19);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome cliente";
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 329);
            Controls.Add(labelNome);
            Controls.Add(textBox1);
            Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormCadastroCliente";
            Text = "FormCadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label labelNome;
    }
}