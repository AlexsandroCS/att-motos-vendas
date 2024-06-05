# Criando banco de dados.
CREATE schema database_loja_motos;

# Setando o banco de dados.
USE database_loja_motos;

# Criando uma Tabela de vendas de motos usadas "Não definitivo".
CREATE TABLE motos_vendas(
	codigo INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	modelo VARCHAR(20) NOT NULL,
    marca VARCHAR(20) NOT NULL,
    ano YEAR NOT NULL,
	cilindrada INT(4) NOT NULL,
    quilometragem INT NOT NULL,
    cor ENUM('Preto', 'Cinza', 'Branco', 'Azul', 'Vermelho', 'Amarelo', 'Verde') NOT NULL,
    valor_original DOUBLE NOT NULL,
    valor_venda DOUBLE NOT NULL,
    placa VARCHAR(7) NOT NULL,
    parcelas INT(2) NOT NULL,
    valor_parcelas DOUBLE NOT NULL,
    data_anuncio DATETIME NOT NULL,
    data_venda DATETIME,
    descricao TEXT(600)
 );
 
 # Selecionando todas as motos existente da tabela.
 SELECT * FROM motos_vendas;
 
 # Tabela de Login "Não definitivo".
 CREATE TABLE motos_usuarios(
	codigo INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
    nome VARCHAR(32) NOT NULL UNIQUE,
    senha VARCHAR(32) NOT NULL
 );
 
 # Criando um Login
 INSERT INTO motos_usuarios VALUES (null, 'Alexsandro','123');
 