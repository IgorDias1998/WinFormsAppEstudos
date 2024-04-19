using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppEstudos.DataAcess;
using WinFormsAppEstudos.SecurityBanco;

namespace WinFormsAppEstudos
{

    public partial class FormCadastroCliente : Form
    {
        MySqlConnection Conexao;
        Password senha = new Password();
        private int? idCliente = null;

        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void labelCadastroCliente_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = ConexaoBD.ObterConexao())
                {
                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao;

                    if (idCliente == null)
                    {
                        cmd.CommandText = "INSERT INTO Cliente (cli_nome, cli_endereco, cli_telefone) " +
                                        "VALUES " +
                                        "(@cli_nome, @cli_endereco, @cli_telefone)";
                        cmd.Parameters.AddWithValue("@cli_codigo", textBoxNomeCliente.Text);
                        cmd.Parameters.AddWithValue("@cli_endereco", textBoxEndereco.Text);
                        cmd.Parameters.AddWithValue("@cli_telefone", textBoxTelefone);

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente cadastrado com sucesso");

                        LimparCampos();

                        Conexao.Close();

                    } else
                    {
                        cmd.CommandText = "UPDATE Cliente SET cli_nome=@cli_nome, cli_endereco=@cli_endereco, cli_telefone=@cli_telefone " +
                                            "WHERE cli_codigo=@cli_codigo";

                        //continua
                    }
                }

            }
            catch
            {

            }
        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void LimparCampos()
        {
            textBoxNomeCliente.Clear();
            textBoxEndereco.Clear();
            textBoxTelefone.Clear();
        }
    }
}
