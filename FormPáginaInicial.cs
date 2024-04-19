using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppEstudos
{
    public partial class FormPáginaInicial : Form
    {
        public FormPáginaInicial()
        {
            InitializeComponent();
        }

        private void buttonRealizarVenda_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            // Instancia o formulário de produto
            Form1 formProduto = new Form1();
            // Exibe o formulário de produto
            formProduto.Show();
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCliente = new FormCadastroCliente();
            formCliente.Show();

        }
    }
}
