using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_LOJA_MOTO
{
    public partial class TelaSistema : Form
    {
        // Conexão com o banco de dados.
        string detailsConnection = "Server=localhost; Port=3306; Uid=root; Pwd=ODDY; Database=database_loja_motos";
        MySqlConnection conn = new MySqlConnection();

        public TelaSistema()
        {
            try
            {
                conn.ConnectionString = detailsConnection;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ocorreu um erro ao se conectar na base de dados!");
            }

            InitializeComponent();
            inicializaItemsCombobox();
        }

        // Método que faz a inserção de valores no comboBoxParcelas e comboBoxAno.
        private void inicializaItemsCombobox()
        {

            for (int i = 1; i < 48 + 1; i++)
            {
                comboBoxParcelas.Items.Add(i.ToString());
            }

            for (int i = 2000; i < DateTime.Now.Year + 1; i++)
            {
                comboBoxAno.Items.Add(i.ToString());
            }
        }

        // Método que calcula os valores de total a pagar e valores de parcelas.
        private double[] calculaPrecosMoto(double valorVenda, int parcelas)
        {
            double novoValorVenda;
            double valorParcelas;

            if (parcelas <= 12)
            {
                novoValorVenda = valorVenda;
                valorParcelas = valorVenda / parcelas;
            }
            else if (parcelas > 12 && parcelas <= 24)
            {
                novoValorVenda = valorVenda * 1.02;
                valorParcelas = novoValorVenda / parcelas;
            }
            else if (parcelas > 24 && parcelas < 36)
            {
                novoValorVenda = valorVenda * 1.05;
                valorParcelas = novoValorVenda / parcelas;
            }
            else
            {
                novoValorVenda = valorVenda * 1.10;
                valorParcelas = novoValorVenda / parcelas;
            }

            double[] resultado = { novoValorVenda, valorParcelas };

            return resultado;
        }

        // Método que altera em tempo real o valor da moto.
        private void textBoxValorVenda_TextChanged(object sender, EventArgs e)
        {
            labelSubtituloResultadoValorMoto.Text = textBoxValorVenda.Text;
            labelSubtituloResultadoValorMoto.Visible = true;
        }

        // Método que altera em tempo real o total a pagar e o valor da parcela.
        private void comboBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            double[] capturaValores = calculaPrecosMoto(double.Parse(textBoxValorVenda.Text), int.Parse(comboBoxParcelas.Text));

            double totalPagar = capturaValores[0];
            double valorParcelas = capturaValores[1];

            labelSubtituloResultadoTotalPagar.Text = totalPagar.ToString("#,0.00");
            labelSubtituloResultadoTotalPagar.Visible = true;

            labelSubtituloResultadoValorParcela.Text = valorParcelas.ToString("#,0.00");
            labelSubtituloResultadoValorParcela.Visible = true;
        }

        // Método do botão Cadastrar.
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string modelo = textBoxModelo.Text;
            string marca = comboBoxMarca.Text;
            int ano = int.Parse(comboBoxAno.Text);
            double cilindrada = double.Parse(textBoxCilindrada.Text);
            double quilometragem = double.Parse(textBoxQuilometragem.Text);
            string cor = comboBoxCor.Text;
            double valorOriginal = double.Parse(textBoxValorOriginal.Text);
            double valorVenda = double.Parse(textBoxValorVenda.Text);
            string placa = textBoxPlaca.Text;
            int parcelas = int.Parse(comboBoxParcelas.Text);
            string descricao = textBoxDescricao.Text;

            double[] capturaValores = calculaPrecosMoto(valorVenda, parcelas);

            double totalPagar = capturaValores[0];
            double valorParcelas = capturaValores[1];

            if (modelo == "" || marca == "" || cor == "")
            {
                MessageBox.Show("Por favor preencha todos os campos!");
            }
            else
            {
                string MYSQuery = "INSERT INTO motos_vendas (codigo, modelo, marca, ano, cilindrada, placa, quilometragem, cor, valor_original, valor_venda, valor_total, parcelas, valor_parcelas, data_anuncio, descricao, delete_by, delete_at) VALUES (null, '" + modelo + "', '" + marca + "', " + ano + ", " + cilindrada + ", '" + placa + "', " + quilometragem + ", '" + cor + "', " + valorOriginal + ", " + valorVenda + ", " + capturaValores[0].ToString("0.00", new CultureInfo("en-US")) + ", " + parcelas + ", " + capturaValores[1].ToString("0.00", new CultureInfo("en-US")) + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + descricao + "', null, null)";

                MessageBox.Show(MYSQuery);

                try
                {
                    MySqlCommand command = new MySqlCommand(MYSQuery, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro foi realizado com sucesso!");
                    limpaCamposFormulario();
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Ocorreu um erro na tezntativa do cadastro!");
                    MessageBox.Show(erro.Message);
                }
            }
            conn.Close();
        }

        // Método do Botão Alterar.
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string modelo = textBoxModelo.Text;
            string marca = comboBoxMarca.Text;
            int ano = int.Parse(comboBoxAno.Text);
            int cilindrada = int.Parse(textBoxCilindrada.Text);
            double quilometragem = double.Parse(textBoxQuilometragem.Text);
            string cor = comboBoxCor.Text;
            double valorOriginal = double.Parse(textBoxValorOriginal.Text);
            double valorVenda = double.Parse(textBoxValorVenda.Text);
            string placa = textBoxPlaca.Text;
            int parcelas = int.Parse(comboBoxParcelas.Text);
            string descricao = textBoxDescricao.Text;

            double[] capturaValores = calculaPrecosMoto(valorVenda, parcelas);

            if (modelo == "" || marca == "" || cor == "")
            {
                MessageBox.Show("Os campos precisam estar preenchidos para fazer alterações!");
            }
            else
            {
                int codigo = int.Parse(textBoxCodigo.Text);

                string strsql = "UPDATE motos_vendas SET modelo='" + modelo + "', marca='" + marca + "', ano=" + ano + ", cilindrada=" + cilindrada + ", placa='" + placa + "', quilometragem=" + quilometragem + ", cor='" + cor + "', valor_original=" + valorOriginal + ", valor_venda=" + valorVenda + ", valor_total=" + capturaValores[0].ToString("0.00", new CultureInfo("en-US")) + ", parcelas=" + parcelas + ", valor_parcelas=" + capturaValores[1].ToString("0.00", new CultureInfo("en-US")) + ", descricao='" + descricao + "' WHERE codigo=" + codigo + ";";

                if (MessageBox.Show("Deseja fazer Alteração na Moto?", "Alterar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(strsql, conn);
                        cmd.ExecuteNonQuery();
                        limpaCamposFormulario();
                        MessageBox.Show("Alteração efetuada com sucesso!");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Os campos não foram alterados devido um erro!");
                    }
                }
            }
            conn.Close();
        }
        // Método do Botão Consultar.
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBoxCodigo.Text == "")
            {
                MessageBox.Show("Não foi possivel encontrar");
            }
            else
            {
                int codigo = int.Parse(textBoxCodigo.Text.Trim());

                string strsql = "SELECT * FROM motos_vendas WHERE delete_by IS NULL AND codigo = " + codigo;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(strsql, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        textBoxCodigo.Text = Convert.ToString(dt.Rows[0][0]);
                        textBoxModelo.Text = Convert.ToString(dt.Rows[0][1]);
                        comboBoxMarca.Text = Convert.ToString(dt.Rows[0][2]);
                        comboBoxAno.Text = Convert.ToString(dt.Rows[0][3]);
                        textBoxCilindrada.Text = Convert.ToString(dt.Rows[0][4]);
                        textBoxPlaca.Text = Convert.ToString(dt.Rows[0][5]);
                        textBoxQuilometragem.Text = Convert.ToString(dt.Rows[0][6]);
                        comboBoxCor.Text = Convert.ToString(dt.Rows[0][7]);
                        textBoxValorOriginal.Text = Convert.ToString(dt.Rows[0][8]);
                        textBoxValorVenda.Text = Convert.ToString(dt.Rows[0][9]);
                        double totalPagar = Convert.ToDouble(dt.Rows[0][10]);
                        labelSubtituloResultadoTotalPagar.Text = totalPagar.ToString("#,0.00");
                        comboBoxParcelas.Text = Convert.ToString(dt.Rows[0][11]);
                        double valorParcela = Convert.ToDouble(dt.Rows[0][12]);
                        labelSubtituloResultadoValorParcela.Text = valorParcela.ToString("#,0.00");
                        textBoxDescricao.Text = Convert.ToString(dt.Rows[0][14]);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            conn.Close();
        }

        // Método do Botão Deletar.
        private void btn_deletar_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBoxCodigo.Text == "")
            {
                MessageBox.Show("Não foi possivel encontrar");
            }
            else
            {
                int codigo = int.Parse(textBoxCodigo.Text.Trim());

                string strsql = "UPDATE motos_vendas SET delete_by = " + 1 + ", delete_at = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE codigo = " + codigo;

                if (MessageBox.Show("Deseja Exluir a Moto?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(strsql, conn);
                        cmd.ExecuteNonQuery();
                        limpaCamposFormulario();
                        MessageBox.Show("Excluido com sucesso");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Não foi possível deletar moto, ocorreu um erro na hora de deletar!");
                    }
                }
            }
            conn.Close();
        }

        // Método do Botão Limpar.
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpaCamposFormulario();
        }

        // Método que limpa os campos.
        private void limpaCamposFormulario()
        {
            textBoxCodigo.Text = "";
            textBoxModelo.Text = "";
            comboBoxMarca.Text = "";
            comboBoxAno.Text = "";
            textBoxCilindrada.Text = "";
            textBoxQuilometragem.Text = "";
            comboBoxCor.Text = "";
            textBoxValorOriginal.Text = "";
            textBoxValorVenda.Text = "";
            textBoxPlaca.Text = "";
            comboBoxParcelas.Text = "";
            textBoxDescricao.Text = "";
            labelSubtituloResultadoValorMoto.Text = "";
            labelSubtituloResultadoTotalPagar.Text = "";
            labelSubtituloResultadoValorParcela.Text = "";
        }

        // Método do Botão Sair.
        private void btn_sair_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Close();
        }
    }
}
