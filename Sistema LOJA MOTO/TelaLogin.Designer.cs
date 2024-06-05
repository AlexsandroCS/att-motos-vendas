namespace Sistema_LOJA_MOTO
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.subtituloUsuario = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.imgFundo = new System.Windows.Forms.PictureBox();
            this.tituloPagina = new System.Windows.Forms.Label();
            this.imgMoto = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgIconEmail = new System.Windows.Forms.PictureBox();
            this.imgIconSenha = new System.Windows.Forms.PictureBox();
            this.btn_esqueci_senha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNome.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(674, 305);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNome.Size = new System.Drawing.Size(223, 22);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.White;
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenha.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(674, 350);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSenha.Multiline = true;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(223, 22);
            this.textBoxSenha.TabIndex = 1;
            // 
            // subtituloUsuario
            // 
            this.subtituloUsuario.AutoSize = true;
            this.subtituloUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtituloUsuario.ForeColor = System.Drawing.Color.Red;
            this.subtituloUsuario.Location = new System.Drawing.Point(634, 249);
            this.subtituloUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtituloUsuario.Name = "subtituloUsuario";
            this.subtituloUsuario.Size = new System.Drawing.Size(283, 31);
            this.subtituloUsuario.TabIndex = 2;
            this.subtituloUsuario.Text = "INSIRA SEU USUÁRIO!";
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.White;
            this.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_entrar.FlatAppearance.BorderSize = 10;
            this.btn_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_entrar.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(701, 382);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(163, 28);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // imgFundo
            // 
            this.imgFundo.BackColor = System.Drawing.Color.Transparent;
            this.imgFundo.Image = ((System.Drawing.Image)(resources.GetObject("imgFundo.Image")));
            this.imgFundo.Location = new System.Drawing.Point(-240, -119);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(840, 709);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFundo.TabIndex = 8;
            this.imgFundo.TabStop = false;
            // 
            // tituloPagina
            // 
            this.tituloPagina.AutoSize = true;
            this.tituloPagina.BackColor = System.Drawing.Color.Red;
            this.tituloPagina.Font = new System.Drawing.Font("Malgun Gothic", 26.75F, System.Drawing.FontStyle.Bold);
            this.tituloPagina.Location = new System.Drawing.Point(277, 102);
            this.tituloPagina.Name = "tituloPagina";
            this.tituloPagina.Size = new System.Drawing.Size(236, 96);
            this.tituloPagina.TabIndex = 9;
            this.tituloPagina.Text = "Login\r\nMotoSystem";
            // 
            // imgMoto
            // 
            this.imgMoto.BackColor = System.Drawing.Color.Red;
            this.imgMoto.Image = ((System.Drawing.Image)(resources.GetObject("imgMoto.Image")));
            this.imgMoto.Location = new System.Drawing.Point(44, 91);
            this.imgMoto.Name = "imgMoto";
            this.imgMoto.Size = new System.Drawing.Size(214, 298);
            this.imgMoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMoto.TabIndex = 10;
            this.imgMoto.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(617, 5);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(301, 241);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 11;
            this.imgUser.TabStop = false;
            // 
            // imgIconEmail
            // 
            this.imgIconEmail.Image = ((System.Drawing.Image)(resources.GetObject("imgIconEmail.Image")));
            this.imgIconEmail.Location = new System.Drawing.Point(640, 300);
            this.imgIconEmail.Name = "imgIconEmail";
            this.imgIconEmail.Size = new System.Drawing.Size(31, 31);
            this.imgIconEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconEmail.TabIndex = 12;
            this.imgIconEmail.TabStop = false;
            // 
            // imgIconSenha
            // 
            this.imgIconSenha.Image = ((System.Drawing.Image)(resources.GetObject("imgIconSenha.Image")));
            this.imgIconSenha.Location = new System.Drawing.Point(640, 347);
            this.imgIconSenha.Name = "imgIconSenha";
            this.imgIconSenha.Size = new System.Drawing.Size(31, 29);
            this.imgIconSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconSenha.TabIndex = 13;
            this.imgIconSenha.TabStop = false;
            // 
            // btn_esqueci_senha
            // 
            this.btn_esqueci_senha.BackColor = System.Drawing.Color.White;
            this.btn_esqueci_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_esqueci_senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_esqueci_senha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_esqueci_senha.FlatAppearance.BorderSize = 10;
            this.btn_esqueci_senha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_esqueci_senha.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esqueci_senha.Location = new System.Drawing.Point(674, 438);
            this.btn_esqueci_senha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_esqueci_senha.Name = "btn_esqueci_senha";
            this.btn_esqueci_senha.Size = new System.Drawing.Size(223, 28);
            this.btn_esqueci_senha.TabIndex = 14;
            this.btn_esqueci_senha.Text = "Esqueci Minha Senha";
            this.btn_esqueci_senha.UseVisualStyleBackColor = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(934, 501);
            this.Controls.Add(this.btn_esqueci_senha);
            this.Controls.Add(this.imgIconSenha);
            this.Controls.Add(this.imgIconEmail);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.imgMoto);
            this.Controls.Add(this.tituloPagina);
            this.Controls.Add(this.imgFundo);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.subtituloUsuario);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxNome);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotoSystem - Tela de Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label subtituloUsuario;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.PictureBox imgFundo;
        private System.Windows.Forms.Label tituloPagina;
        private System.Windows.Forms.PictureBox imgMoto;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.PictureBox imgIconEmail;
        private System.Windows.Forms.PictureBox imgIconSenha;
        private System.Windows.Forms.Button btn_esqueci_senha;
    }
}

