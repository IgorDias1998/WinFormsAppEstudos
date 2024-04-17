using MySql.Data.MySqlClient;
using System.Net.Mail;
using WinFormsAppEstudos.SecurityBanco;

namespace WinFormsAppEstudos
{
    public partial class Form1 : Form
    {
        Password senha = new Password();
        MySqlConnection Conexao;
        private string data_source;

        private int? codigoProduto = null;

        public Form1()
        {
            InitializeComponent();

            data_source = $"datasource=localhost;username=root;password={senha.PasswordStorage()};database=Venda_Produto";


            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Código", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Descrição", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Preço", 80, HorizontalAlignment.Left);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = Conexao;

                if (codigoProduto == null)
                {
                    comando.CommandText = "INSERT INTO Produto (pro_codigo, pro_nome,  pro_descricao, pro_preco) " +
                      "VALUES " +
                      "(@pro_codigo, @pro_nome,  @pro_descricao, @pro_preco) ";

                    comando.Parameters.AddWithValue("@pro_codigo", textBox2.Text);
                    comando.Parameters.AddWithValue("@pro_nome", textBox1.Text);
                    comando.Parameters.AddWithValue("@pro_descricao", textBox3.Text);
                    comando.Parameters.AddWithValue("@pro_preco", textBox4.Text);

                    comando.Prepare();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Produto cadastrado com sucesso!");

                    limparCampos();
                }
                else
                {
                    //Atualização de contato
                    comando.CommandText = "UPDATE Produto SET pro_codigo=@pro_codigo, pro_nome=@pro_nome, pro_descricao=@pro_descricao, pro_preco=@pro_preco " +
                      "WHERE pro_codigo=@pro_codigo";

                    comando.Parameters.AddWithValue("@pro_codigo", textBox2.Text);
                    comando.Parameters.AddWithValue("@pro_nome", textBox1.Text);
                    comando.Parameters.AddWithValue("@pro_descricao", textBox3.Text);
                    comando.Parameters.AddWithValue("@pro_preco", textBox4.Text);

                    comando.Prepare();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Produto atualizado com sucesso!");

                    limparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = Conexao;

                comando.CommandText = "SELECT * " +
                                        "FROM Produto " +
                                        "WHERE pro_nome LIKE @pro_nome ";

                comando.Parameters.AddWithValue("@pro_nome", "%" + textBox5.Text + "%");

                comando.Prepare();

                MySqlDataReader reader = comando.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDouble(3).ToString()
                    };

                    var linha_listView = new ListViewItem(row);

                    listView1.Items.Add(linha_listView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itensSelecionados = listView1.SelectedItems;

            foreach (ListViewItem item in itensSelecionados)
            {
                codigoProduto = Convert.ToInt32(item.SubItems[0].Text);

                textBox1.Text = item.SubItems[1].Text;
                textBox2.Text = item.SubItems[0].Text;
                textBox3.Text = item.SubItems[2].Text;
                textBox4.Text = item.SubItems[3].Text;

                buttonExcluir.Visible = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            excluirItem();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            excluirItem();
        }

        private void limparCampos()
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void excluirItem()
        {
            try
            {

                DialogResult conf = MessageBox.Show("Deseja realmente excluir este registro?",
                                "Tem certeza?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                if (conf == DialogResult.Yes)
                {
                    //Exluir no banco de dados
                    Conexao = new MySqlConnection(data_source);

                    Conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando.Connection = Conexao;

                    comando.CommandText = "DELETE FROM produto WHERE pro_codigo=@pro_codigo";

                    comando.Parameters.AddWithValue("@pro_codigo", codigoProduto);

                    comando.Prepare();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Item excluído com sucesso!",
                                    "Sucesso!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    buttonExcluir.Visible = false;

                    limparCampos();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Number + "ocorreu " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                            "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
