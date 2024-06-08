namespace Sistema_LOJA_MOTO
{
    partial class TelaSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSistema));
            this.estrutura_principal = new System.Windows.Forms.TableLayoutPanel();
            this.painelTopo = new System.Windows.Forms.Panel();
            this.imgMoto = new System.Windows.Forms.PictureBox();
            this.tituloPagina = new System.Windows.Forms.Label();
            this.colunas_conteudo_menu = new System.Windows.Forms.SplitContainer();
            this.painel_conteudo_cadastrar = new System.Windows.Forms.Panel();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.comboBoxAno = new System.Windows.Forms.ComboBox();
            this.labelSubtituloResultadoValorParcela = new System.Windows.Forms.Label();
            this.comboBoxParcelas = new System.Windows.Forms.ComboBox();
            this.labelSubtituloValorParcela = new System.Windows.Forms.Label();
            this.labelSubtituloResultadoTotalPagar = new System.Windows.Forms.Label();
            this.labelParcela = new System.Windows.Forms.Label();
            this.labelSubtituloTotalPagar = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelSubtituloResultadoValorMoto = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelSubtituloValorMoto = new System.Windows.Forms.Label();
            this.comboBoxCor = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxValorVenda = new System.Windows.Forms.TextBox();
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.textBoxValorOriginal = new System.Windows.Forms.TextBox();
            this.labelValorOriginal = new System.Windows.Forms.Label();
            this.labelCor = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.textBoxQuilometragem = new System.Windows.Forms.TextBox();
            this.labelQuilometragem = new System.Windows.Forms.Label();
            this.textBoxCilindrada = new System.Windows.Forms.TextBox();
            this.labelCilindrada = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.estrutura_principal.SuspendLayout();
            this.painelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colunas_conteudo_menu)).BeginInit();
            this.colunas_conteudo_menu.Panel1.SuspendLayout();
            this.colunas_conteudo_menu.Panel2.SuspendLayout();
            this.colunas_conteudo_menu.SuspendLayout();
            this.painel_conteudo_cadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // estrutura_principal
            // 
            this.estrutura_principal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.estrutura_principal.ColumnCount = 1;
            this.estrutura_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.estrutura_principal.Controls.Add(this.painelTopo, 0, 0);
            this.estrutura_principal.Controls.Add(this.colunas_conteudo_menu, 0, 1);
            this.estrutura_principal.Location = new System.Drawing.Point(-3, 0);
            this.estrutura_principal.Name = "estrutura_principal";
            this.estrutura_principal.RowCount = 2;
            this.estrutura_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.estrutura_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 422F));
            this.estrutura_principal.Size = new System.Drawing.Size(940, 502);
            this.estrutura_principal.TabIndex = 0;
            // 
            // painelTopo
            // 
            this.painelTopo.BackColor = System.Drawing.Color.Red;
            this.painelTopo.Controls.Add(this.imgMoto);
            this.painelTopo.Controls.Add(this.tituloPagina);
            this.painelTopo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelTopo.Location = new System.Drawing.Point(3, 3);
            this.painelTopo.Name = "painelTopo";
            this.painelTopo.Size = new System.Drawing.Size(934, 74);
            this.painelTopo.TabIndex = 0;
            // 
            // imgMoto
            // 
            this.imgMoto.BackColor = System.Drawing.Color.Red;
            this.imgMoto.Image = ((System.Drawing.Image)(resources.GetObject("imgMoto.Image")));
            this.imgMoto.Location = new System.Drawing.Point(14, 3);
            this.imgMoto.Name = "imgMoto";
            this.imgMoto.Size = new System.Drawing.Size(56, 66);
            this.imgMoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMoto.TabIndex = 22;
            this.imgMoto.TabStop = false;
            // 
            // tituloPagina
            // 
            this.tituloPagina.AutoSize = true;
            this.tituloPagina.BackColor = System.Drawing.Color.Red;
            this.tituloPagina.Font = new System.Drawing.Font("Malgun Gothic", 32.75F, System.Drawing.FontStyle.Bold);
            this.tituloPagina.ForeColor = System.Drawing.Color.Black;
            this.tituloPagina.Location = new System.Drawing.Point(76, 6);
            this.tituloPagina.Name = "tituloPagina";
            this.tituloPagina.Size = new System.Drawing.Size(289, 60);
            this.tituloPagina.TabIndex = 0;
            this.tituloPagina.Text = "MotoSystem";
            // 
            // colunas_conteudo_menu
            // 
            this.colunas_conteudo_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colunas_conteudo_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colunas_conteudo_menu.Location = new System.Drawing.Point(3, 83);
            this.colunas_conteudo_menu.Name = "colunas_conteudo_menu";
            // 
            // colunas_conteudo_menu.Panel1
            // 
            this.colunas_conteudo_menu.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colunas_conteudo_menu.Panel1.Controls.Add(this.painel_conteudo_cadastrar);
            // 
            // colunas_conteudo_menu.Panel2
            // 
            this.colunas_conteudo_menu.Panel2.BackColor = System.Drawing.Color.Red;
            this.colunas_conteudo_menu.Panel2.Controls.Add(this.btn_sair);
            this.colunas_conteudo_menu.Panel2.Controls.Add(this.btn_deletar);
            this.colunas_conteudo_menu.Panel2.Controls.Add(this.btn_consultar);
            this.colunas_conteudo_menu.Panel2.Controls.Add(this.btn_alterar);
            this.colunas_conteudo_menu.Panel2.Controls.Add(this.btn_limpar);
            this.colunas_conteudo_menu.Panel2.Controls.Add(this.btn_cadastrar);
            this.colunas_conteudo_menu.Size = new System.Drawing.Size(934, 416);
            this.colunas_conteudo_menu.SplitterDistance = 817;
            this.colunas_conteudo_menu.TabIndex = 1;
            // 
            // painel_conteudo_cadastrar
            // 
            this.painel_conteudo_cadastrar.Controls.Add(this.textBoxCodigo);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelCodigo);
            this.painel_conteudo_cadastrar.Controls.Add(this.comboBoxAno);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelSubtituloResultadoValorParcela);
            this.painel_conteudo_cadastrar.Controls.Add(this.comboBoxParcelas);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelSubtituloValorParcela);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelSubtituloResultadoTotalPagar);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelParcela);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelSubtituloTotalPagar);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelDescricao);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelSubtituloResultadoValorMoto);
            this.painel_conteudo_cadastrar.Controls.Add(this.textBoxDescricao);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelSubtituloValorMoto);
            this.painel_conteudo_cadastrar.Controls.Add(this.comboBoxCor);
            this.painel_conteudo_cadastrar.Controls.Add(this.comboBoxMarca);
            this.painel_conteudo_cadastrar.Controls.Add(this.textBoxValorVenda);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelValorVenda);
            this.painel_conteudo_cadastrar.Controls.Add(this.textBoxValorOriginal);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelValorOriginal);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelCor);
            this.painel_conteudo_cadastrar.Controls.Add(this.textBoxPlaca);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelPlaca);
            this.painel_conteudo_cadastrar.Controls.Add(this.textBoxQuilometragem);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelQuilometragem);
            this.painel_conteudo_cadastrar.Controls.Add(this.textBoxCilindrada);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelCilindrada);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelAno);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelMarca);
            this.painel_conteudo_cadastrar.Controls.Add(this.textBoxModelo);
            this.painel_conteudo_cadastrar.Controls.Add(this.labelModelo);
            this.painel_conteudo_cadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_conteudo_cadastrar.Location = new System.Drawing.Point(0, 0);
            this.painel_conteudo_cadastrar.Name = "painel_conteudo_cadastrar";
            this.painel_conteudo_cadastrar.Size = new System.Drawing.Size(817, 416);
            this.painel_conteudo_cadastrar.TabIndex = 24;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodigo.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxCodigo.Location = new System.Drawing.Point(14, 29);
            this.textBoxCodigo.MaximumSize = new System.Drawing.Size(150, 25);
            this.textBoxCodigo.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(150, 25);
            this.textBoxCodigo.TabIndex = 51;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(14, 11);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(58, 17);
            this.labelCodigo.TabIndex = 50;
            this.labelCodigo.Text = "Codigo";
            // 
            // comboBoxAno
            // 
            this.comboBoxAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAno.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxAno.FormattingEnabled = true;
            this.comboBoxAno.Location = new System.Drawing.Point(14, 209);
            this.comboBoxAno.MaximumSize = new System.Drawing.Size(150, 0);
            this.comboBoxAno.MinimumSize = new System.Drawing.Size(150, 0);
            this.comboBoxAno.Name = "comboBoxAno";
            this.comboBoxAno.Size = new System.Drawing.Size(150, 25);
            this.comboBoxAno.Sorted = true;
            this.comboBoxAno.TabIndex = 49;
            // 
            // labelSubtituloResultadoValorParcela
            // 
            this.labelSubtituloResultadoValorParcela.AutoSize = true;
            this.labelSubtituloResultadoValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelSubtituloResultadoValorParcela.ForeColor = System.Drawing.Color.DimGray;
            this.labelSubtituloResultadoValorParcela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubtituloResultadoValorParcela.Location = new System.Drawing.Point(716, 389);
            this.labelSubtituloResultadoValorParcela.Name = "labelSubtituloResultadoValorParcela";
            this.labelSubtituloResultadoValorParcela.Size = new System.Drawing.Size(67, 20);
            this.labelSubtituloResultadoValorParcela.TabIndex = 5;
            this.labelSubtituloResultadoValorParcela.Text = "Valor Z";
            this.labelSubtituloResultadoValorParcela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubtituloResultadoValorParcela.Visible = false;
            // 
            // comboBoxParcelas
            // 
            this.comboBoxParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxParcelas.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxParcelas.FormattingEnabled = true;
            this.comboBoxParcelas.Location = new System.Drawing.Point(400, 210);
            this.comboBoxParcelas.MaximumSize = new System.Drawing.Size(150, 0);
            this.comboBoxParcelas.MinimumSize = new System.Drawing.Size(150, 0);
            this.comboBoxParcelas.Name = "comboBoxParcelas";
            this.comboBoxParcelas.Size = new System.Drawing.Size(150, 25);
            this.comboBoxParcelas.TabIndex = 45;
            this.comboBoxParcelas.SelectedIndexChanged += new System.EventHandler(this.comboBoxParcelas_SelectedIndexChanged);
            // 
            // labelSubtituloValorParcela
            // 
            this.labelSubtituloValorParcela.AutoSize = true;
            this.labelSubtituloValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtituloValorParcela.ForeColor = System.Drawing.Color.Black;
            this.labelSubtituloValorParcela.Location = new System.Drawing.Point(542, 385);
            this.labelSubtituloValorParcela.Name = "labelSubtituloValorParcela";
            this.labelSubtituloValorParcela.Size = new System.Drawing.Size(180, 24);
            this.labelSubtituloValorParcela.TabIndex = 4;
            this.labelSubtituloValorParcela.Text = "Valor das Parcela:";
            // 
            // labelSubtituloResultadoTotalPagar
            // 
            this.labelSubtituloResultadoTotalPagar.AutoSize = true;
            this.labelSubtituloResultadoTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelSubtituloResultadoTotalPagar.ForeColor = System.Drawing.Color.DimGray;
            this.labelSubtituloResultadoTotalPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubtituloResultadoTotalPagar.Location = new System.Drawing.Point(414, 389);
            this.labelSubtituloResultadoTotalPagar.Name = "labelSubtituloResultadoTotalPagar";
            this.labelSubtituloResultadoTotalPagar.Size = new System.Drawing.Size(68, 20);
            this.labelSubtituloResultadoTotalPagar.TabIndex = 3;
            this.labelSubtituloResultadoTotalPagar.Text = "Valor Y";
            this.labelSubtituloResultadoTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubtituloResultadoTotalPagar.Visible = false;
            // 
            // labelParcela
            // 
            this.labelParcela.AutoSize = true;
            this.labelParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParcela.Location = new System.Drawing.Point(400, 192);
            this.labelParcela.Name = "labelParcela";
            this.labelParcela.Size = new System.Drawing.Size(71, 17);
            this.labelParcela.TabIndex = 44;
            this.labelParcela.Text = "Parcelas";
            // 
            // labelSubtituloTotalPagar
            // 
            this.labelSubtituloTotalPagar.AutoSize = true;
            this.labelSubtituloTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtituloTotalPagar.ForeColor = System.Drawing.Color.Black;
            this.labelSubtituloTotalPagar.Location = new System.Drawing.Point(281, 385);
            this.labelSubtituloTotalPagar.Name = "labelSubtituloTotalPagar";
            this.labelSubtituloTotalPagar.Size = new System.Drawing.Size(139, 24);
            this.labelSubtituloTotalPagar.TabIndex = 2;
            this.labelSubtituloTotalPagar.Text = "Total a Pagar:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(400, 11);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(80, 17);
            this.labelDescricao.TabIndex = 43;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelSubtituloResultadoValorMoto
            // 
            this.labelSubtituloResultadoValorMoto.AutoSize = true;
            this.labelSubtituloResultadoValorMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelSubtituloResultadoValorMoto.ForeColor = System.Drawing.Color.DimGray;
            this.labelSubtituloResultadoValorMoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubtituloResultadoValorMoto.Location = new System.Drawing.Point(149, 389);
            this.labelSubtituloResultadoValorMoto.Name = "labelSubtituloResultadoValorMoto";
            this.labelSubtituloResultadoValorMoto.Size = new System.Drawing.Size(68, 20);
            this.labelSubtituloResultadoValorMoto.TabIndex = 1;
            this.labelSubtituloResultadoValorMoto.Text = "Valor X";
            this.labelSubtituloResultadoValorMoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubtituloResultadoValorMoto.Visible = false;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescricao.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxDescricao.Location = new System.Drawing.Point(400, 29);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(395, 144);
            this.textBoxDescricao.TabIndex = 42;
            // 
            // labelSubtituloValorMoto
            // 
            this.labelSubtituloValorMoto.AutoSize = true;
            this.labelSubtituloValorMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtituloValorMoto.ForeColor = System.Drawing.Color.Black;
            this.labelSubtituloValorMoto.Location = new System.Drawing.Point(9, 385);
            this.labelSubtituloValorMoto.Name = "labelSubtituloValorMoto";
            this.labelSubtituloValorMoto.Size = new System.Drawing.Size(146, 24);
            this.labelSubtituloValorMoto.TabIndex = 0;
            this.labelSubtituloValorMoto.Text = "Valor da Moto:";
            // 
            // comboBoxCor
            // 
            this.comboBoxCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCor.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxCor.FormattingEnabled = true;
            this.comboBoxCor.Items.AddRange(new object[] {
            "Preto",
            "Cinza",
            "Branco",
            "Azul",
            "Vermelho",
            "Amarelo",
            "",
            ""});
            this.comboBoxCor.Location = new System.Drawing.Point(212, 29);
            this.comboBoxCor.MaximumSize = new System.Drawing.Size(150, 0);
            this.comboBoxCor.MinimumSize = new System.Drawing.Size(150, 0);
            this.comboBoxCor.Name = "comboBoxCor";
            this.comboBoxCor.Size = new System.Drawing.Size(150, 25);
            this.comboBoxCor.TabIndex = 41;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMarca.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Honda",
            "Yamaha",
            "BMW",
            "Suzuki",
            "Harley Davidson",
            "Royal Enfield",
            "Triumph",
            "Kawasaki",
            "Ducati",
            "Piaggio",
            "KTM",
            "Shineray",
            "Mottu",
            "Dafra",
            "Outra"});
            this.comboBoxMarca.Location = new System.Drawing.Point(14, 147);
            this.comboBoxMarca.MaximumSize = new System.Drawing.Size(150, 0);
            this.comboBoxMarca.MinimumSize = new System.Drawing.Size(150, 0);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(150, 25);
            this.comboBoxMarca.TabIndex = 40;
            // 
            // textBoxValorVenda
            // 
            this.textBoxValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValorVenda.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxValorVenda.Location = new System.Drawing.Point(212, 148);
            this.textBoxValorVenda.MaximumSize = new System.Drawing.Size(150, 25);
            this.textBoxValorVenda.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBoxValorVenda.Name = "textBoxValorVenda";
            this.textBoxValorVenda.Size = new System.Drawing.Size(150, 25);
            this.textBoxValorVenda.TabIndex = 39;
            this.textBoxValorVenda.TextChanged += new System.EventHandler(this.textBoxValorVenda_TextChanged);
            // 
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorVenda.Location = new System.Drawing.Point(212, 130);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(97, 17);
            this.labelValorVenda.TabIndex = 38;
            this.labelValorVenda.Text = "Valor Venda";
            // 
            // textBoxValorOriginal
            // 
            this.textBoxValorOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValorOriginal.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxValorOriginal.Location = new System.Drawing.Point(212, 88);
            this.textBoxValorOriginal.MaximumSize = new System.Drawing.Size(150, 25);
            this.textBoxValorOriginal.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBoxValorOriginal.Name = "textBoxValorOriginal";
            this.textBoxValorOriginal.Size = new System.Drawing.Size(150, 25);
            this.textBoxValorOriginal.TabIndex = 37;
            // 
            // labelValorOriginal
            // 
            this.labelValorOriginal.AutoSize = true;
            this.labelValorOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorOriginal.Location = new System.Drawing.Point(212, 70);
            this.labelValorOriginal.Name = "labelValorOriginal";
            this.labelValorOriginal.Size = new System.Drawing.Size(108, 17);
            this.labelValorOriginal.TabIndex = 36;
            this.labelValorOriginal.Text = "Valor Original";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCor.Location = new System.Drawing.Point(212, 11);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(33, 17);
            this.labelCor.TabIndex = 35;
            this.labelCor.Text = "Cor";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlaca.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxPlaca.Location = new System.Drawing.Point(212, 210);
            this.textBoxPlaca.MaximumSize = new System.Drawing.Size(150, 25);
            this.textBoxPlaca.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(150, 25);
            this.textBoxPlaca.TabIndex = 34;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaca.Location = new System.Drawing.Point(212, 192);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(48, 17);
            this.labelPlaca.TabIndex = 33;
            this.labelPlaca.Text = "Placa";
            // 
            // textBoxQuilometragem
            // 
            this.textBoxQuilometragem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuilometragem.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxQuilometragem.Location = new System.Drawing.Point(212, 269);
            this.textBoxQuilometragem.MaximumSize = new System.Drawing.Size(150, 25);
            this.textBoxQuilometragem.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBoxQuilometragem.Name = "textBoxQuilometragem";
            this.textBoxQuilometragem.Size = new System.Drawing.Size(150, 25);
            this.textBoxQuilometragem.TabIndex = 32;
            // 
            // labelQuilometragem
            // 
            this.labelQuilometragem.AutoSize = true;
            this.labelQuilometragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuilometragem.Location = new System.Drawing.Point(212, 251);
            this.labelQuilometragem.Name = "labelQuilometragem";
            this.labelQuilometragem.Size = new System.Drawing.Size(117, 17);
            this.labelQuilometragem.TabIndex = 31;
            this.labelQuilometragem.Text = "Quilometragem";
            // 
            // textBoxCilindrada
            // 
            this.textBoxCilindrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCilindrada.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxCilindrada.Location = new System.Drawing.Point(14, 269);
            this.textBoxCilindrada.MaximumSize = new System.Drawing.Size(150, 25);
            this.textBoxCilindrada.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBoxCilindrada.Name = "textBoxCilindrada";
            this.textBoxCilindrada.Size = new System.Drawing.Size(150, 25);
            this.textBoxCilindrada.TabIndex = 30;
            // 
            // labelCilindrada
            // 
            this.labelCilindrada.AutoSize = true;
            this.labelCilindrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCilindrada.Location = new System.Drawing.Point(14, 251);
            this.labelCilindrada.Name = "labelCilindrada";
            this.labelCilindrada.Size = new System.Drawing.Size(81, 17);
            this.labelCilindrada.TabIndex = 29;
            this.labelCilindrada.Text = "Cilindrada";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.Location = new System.Drawing.Point(14, 189);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(36, 17);
            this.labelAno.TabIndex = 27;
            this.labelAno.Text = "Ano";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(14, 129);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(52, 17);
            this.labelMarca.TabIndex = 26;
            this.labelMarca.Text = "Marca";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModelo.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxModelo.Location = new System.Drawing.Point(14, 88);
            this.textBoxModelo.MaximumSize = new System.Drawing.Size(150, 25);
            this.textBoxModelo.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(150, 25);
            this.textBoxModelo.TabIndex = 25;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(14, 70);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(60, 17);
            this.labelModelo.TabIndex = 24;
            this.labelModelo.Text = "Modelo";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sair.FlatAppearance.BorderSize = 10;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_sair.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(8, 382);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(98, 32);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_deletar.FlatAppearance.BorderSize = 10;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_deletar.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.Location = new System.Drawing.Point(8, 185);
            this.btn_deletar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(98, 32);
            this.btn_deletar.TabIndex = 10;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_consultar.FlatAppearance.BorderSize = 10;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_consultar.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(8, 141);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(98, 32);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_alterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_alterar.FlatAppearance.BorderSize = 10;
            this.btn_alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_alterar.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(8, 97);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(98, 32);
            this.btn_alterar.TabIndex = 8;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpar.FlatAppearance.BorderSize = 10;
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_limpar.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(8, 52);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(98, 32);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cadastrar.FlatAppearance.BorderSize = 10;
            this.btn_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cadastrar.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(8, 9);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(98, 32);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // TelaSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 501);
            this.Controls.Add(this.estrutura_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 540);
            this.MinimumSize = new System.Drawing.Size(950, 540);
            this.Name = "TelaSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotoSystem - Tela do Sistema";
            this.estrutura_principal.ResumeLayout(false);
            this.painelTopo.ResumeLayout(false);
            this.painelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoto)).EndInit();
            this.colunas_conteudo_menu.Panel1.ResumeLayout(false);
            this.colunas_conteudo_menu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colunas_conteudo_menu)).EndInit();
            this.colunas_conteudo_menu.ResumeLayout(false);
            this.painel_conteudo_cadastrar.ResumeLayout(false);
            this.painel_conteudo_cadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel estrutura_principal;
        private System.Windows.Forms.Panel painelTopo;
        private System.Windows.Forms.Label tituloPagina;
        private System.Windows.Forms.PictureBox imgMoto;
        private System.Windows.Forms.SplitContainer colunas_conteudo_menu;
        private System.Windows.Forms.Panel painel_conteudo_cadastrar;
        private System.Windows.Forms.Label labelSubtituloResultadoValorParcela;
        private System.Windows.Forms.ComboBox comboBoxParcelas;
        private System.Windows.Forms.Label labelSubtituloValorParcela;
        private System.Windows.Forms.Label labelSubtituloResultadoTotalPagar;
        private System.Windows.Forms.Label labelParcela;
        private System.Windows.Forms.Label labelSubtituloTotalPagar;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelSubtituloResultadoValorMoto;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelSubtituloValorMoto;
        private System.Windows.Forms.ComboBox comboBoxCor;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxValorVenda;
        private System.Windows.Forms.Label labelValorVenda;
        private System.Windows.Forms.TextBox textBoxValorOriginal;
        private System.Windows.Forms.Label labelValorOriginal;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.TextBox textBoxQuilometragem;
        private System.Windows.Forms.Label labelQuilometragem;
        private System.Windows.Forms.TextBox textBoxCilindrada;
        private System.Windows.Forms.Label labelCilindrada;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.ComboBox comboBoxAno;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
    }
}