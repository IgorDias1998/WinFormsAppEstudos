namespace WinFormsAppEstudos
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            listView1 = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            buttonExcluir = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(11, 37);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(259, 26);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 14);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 2;
            label2.Text = "Código do produto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 26);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 90);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(484, 26);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 168);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 6;
            label4.Text = "Preço";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 26);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 197);
            label5.Name = "label5";
            label5.Size = new Size(28, 19);
            label5.TabIndex = 8;
            label5.Text = "R$";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(325, 182);
            button1.Name = "button1";
            button1.Size = new Size(171, 34);
            button1.TabIndex = 9;
            button1.Text = "Salvar Produto";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 23);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 10;
            label6.Text = "Buscar produto";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(550, 45);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(321, 26);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(900, 37);
            button2.Name = "button2";
            button2.Size = new Size(171, 34);
            button2.TabIndex = 12;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Location = new Point(551, 90);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(520, 196);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(149, 28);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(148, 24);
            toolStripMenuItem1.Text = "Exluir item";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.Cursor = Cursors.Hand;
            buttonExcluir.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluir.ForeColor = SystemColors.ControlLightLight;
            buttonExcluir.Location = new Point(900, 296);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(171, 34);
            buttonExcluir.TabIndex = 14;
            buttonExcluir.Text = "Excluir item";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Visible = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1131, 342);
            Controls.Add(buttonExcluir);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Sistema";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox textBox5;
        private Button button2;
        private ListView listView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button buttonExcluir;
    }
}
