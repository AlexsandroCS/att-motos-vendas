# Criando banco de dados.
CREATE schema database_loja_motos;

# Setando o banco de dados.
USE database_loja_motos;

# Criando uma Tabela de vendas de motos usadas "Não definitivo".
CREATE TABLE motos_vendas(
	codigo INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
	modelo VARCHAR(30) NOT NULL,
    marca VARCHAR(30) NOT NULL,
    ano YEAR NOT NULL,
	cilindrada INT(4) NOT NULL,
    placa VARCHAR(7) NOT NULL UNIQUE,
    quilometragem DOUBLE NOT NULL,
    cor ENUM('Preto', 'Cinza', 'Branco', 'Azul', 'Vermelho', 'Amarelo', 'Verde') NOT NULL,
    valor_original DOUBLE NOT NULL,
    valor_venda DOUBLE NOT NULL,
    valor_total DOUBLE NOT NULL,
    parcelas INT(2) NOT NULL,
    valor_parcelas DOUBLE NOT NULL,
    data_anuncio DATETIME NOT NULL,
    descricao TEXT(600),
    delete_by INT,
    delete_at DATETIME
 );
 
 # Selecionando todas as motos existente da tabela.
 SELECT * FROM motos_vendas;
 
 # Tabela de Login "Não definitivo".
 CREATE TABLE motos_usuarios(
	codigo INT NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
    nome VARCHAR(32) NOT NULL UNIQUE,
    senha VARCHAR(32) NOT NULL
 );
 
 # Criando Logins
 INSERT INTO motos_usuarios VALUES (null, 'Alexsandro','123');
 INSERT INTO motos_usuarios VALUES (null, 'Elson','123');
 INSERT INTO motos_usuarios VALUES (null, 'Hannah','123');
 INSERT INTO motos_usuarios VALUES (null, 'Yago','123');
 INSERT INTO motos_usuarios VALUES (null, 'Bob','123');
 
 # Selecionando todos os usuários existente da tabela.
 SELECT * FROM motos_usuarios;
 
 # Adicionando campos para o softdelete.
 ALTER TABLE motos_vendas ADD COLUMN delete_by INT NULL, ADD COLUMN delete_at DATETIME;