

CREATE DATABASE banco_dados_aula1204;

USE banco_dados_aula1204;

-- Criando uma tabela com chave primária

CREATE TABLE Usuarios (
	Id INT IDENTITY(1, 1),
	Nome VARCHAR(30),
	Idade INT,
	Email VARCHAR(40),

	PRIMARY KEY(Id)
);

INSERT INTO Usuarios (Nome, Idade, Email)
	VALUES
	('Zé', 15, 'email@.com');

SELECT * FROM Usuarios;

-- Capítulo 08 - Joins

-- Criar estruturas exemplo

CREATE TABLE Cidades(
	Id INT IDENTITY(1, 1),
	Nome VARCHAR(30),
	PRIMARY KEY(Id)
);

CREATE TABLE Clientes(
	Id INT IDENTITY(1, 1),
	Nome VARCHAR(30),
	IdCidade INT,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdCidade) REFERENCES Cidades(Id)
);

-- Incluindo dados nas tabelas
INSERT INTO Cidades (Nome)
VALUES
	('Blumenau'),
	('Gaspar'),
	('Indaial'),
	('Timbó'),
	('Massaranduba');


INSERT INTO Clientes (Nome, IdCidade)
VALUES
	('Zé', 1),
	('Maria', 2),
	('Souza', 3),
	('João', 4),
	('André', 5),
    ('Henrique', 5);

SELECT * FROM Cidades;
SELECT * FROM Clientes;

-- JOIN para obter nome do cliente e nome da cidade (Sem apelidos para tabelas)

SELECT
	Clientes.Nome AS NomeCliente,
	Cidades.Nome AS CidadeNome
FROM Clientes
	INNER JOIN Cidades 
		ON Cidades.Id = Clientes.IdCidade

-- JOIN para obter nome do cliente e nome da cidade (Com apelidos para tabelas)
SELECT
	cli.Nome AS NomeCliente,
	cid.Nome AS CidadeNome
FROM Clientes AS cli
	INNER JOIN Cidades AS cid
		ON cid.Id = cli.IdCidade;


-- INNER JOIN -> registro precisa existir na tabela 'Clientes' e na 'Cidades'

-- LEFT JOIN -> registro precisa existir na tabela principal e pode não
-- existir no JOIN

SELECT * FROM Clientes -- obrigatório
	LEFT JOIN Cidades ON Cidades.Id = Clientes.IdCidade; -- join opcional

-- RIGHT JOIN

SELECT * FROM Clientes -- opcional
	RIGHT JOIN Cidades ON Cidades.Id = Clientes.IdCidade; -- join obrigatorio