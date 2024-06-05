using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_LOJA_MOTO
{
    public partial class TelaLogin : Form
    {
        string detailsConnection = "Server=localhost; Port=3306; Uid=root; Pwd=ODDY; Database=database_loja_motos";
        MySqlConnection conn;

        public TelaLogin()
        {
            try
            {
                conn = new MySqlConnection(detailsConnection);
                conn.ConnectionString = detailsConnection;
                conn.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro ao se conectar na base de dados!");
            }
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string capturaNome = textBoxNome.Text;
            string capturaSenha = textBoxSenha.Text;

            if (protecaoSQLInject(capturaNome, capturaSenha) == false)
            {
                MessageBox.Show("Login ou Senha com caractéres especiais inválidos!");
            }
            else if(capturaNome == "" || capturaNome == null)
            {
                MessageBox.Show("Login inválido ou Vazio, insira dados correto!");
            }
            else if (capturaSenha == "" || capturaSenha == null)
            {
                MessageBox.Show("Senha inválida ou Vazia, insira dados correto!");
            }
            else
            {
                try
                {
                    string SQLQuery = "SELECT * FROM motos_usuarios WHERE nome='" + capturaNome + "' AND senha='" + capturaSenha + "'";
                    MySqlCommand command = new MySqlCommand(SQLQuery, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable resultado = new DataTable();

                    adapter.Fill(resultado);

                    if (resultado.Rows.Count == 0)
                    {
                        MessageBox.Show("Nome ou Senha incorreto!");

                        textBoxNome.Text = "";
                        textBoxSenha.Text = "";
                    }
                    else
                    {
                        TelaSistema telaSistema = new TelaSistema();
                        telaSistema.Show();
                        this.Hide();
                    }
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ocorreu um erro na tentativa de comunicação com a base de dados!");
                }
                conn.Close();
            }
        }

        private bool protecaoSQLInject(string nome, string senha)
        {
            string catchErro = nome + senha;

            foreach (char character in catchErro)
            {
                if (character == '\'' || character == '"')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
