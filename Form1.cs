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

                string sql = "INSERT INTO Produto (pro_codigo, pro_nome, pro_descricao, pro_preco)" +
                    "VALUES('" + textBox2.Text + "', '" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Produto cadastrado com sucesso!");

                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
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
                string q = "'%" + textBox5.Text + "%'";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM Produto " +
                            "WHERE pro_nome LIKE " + q;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();
                
                listView1.Items.Clear();

                while(reader.Read())
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
    }
}
