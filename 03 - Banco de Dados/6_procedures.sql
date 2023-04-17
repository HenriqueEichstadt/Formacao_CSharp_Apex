
CREATE DATABASE ProjetoViews1704;


USE ProjetoViews1704;

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

-- store procedures

-- criando procedure para inserir uma cidade
CREATE PROCEDURE inserirCidade @nome nvarchar(15) AS
INSERT INTO Cidades (Nome) VALUES (@nome);

-- executando uma procedure

EXEC inserirCidade @nome = 'Florianópolis';

-- removendo uma procedure
DROP PROCEDURE inserirCidade;

-- criando procedure para inserir um cliente
CREATE PROCEDURE inserirCliente @nome VARCHAR(30), @idCidade INT AS
INSERT INTO Clientes (Nome, IdCidade) VALUES (@nome, @idCidade);

EXEC inserirCliente @nome = 'Henrique', @idCidade = 1;

-- podemos criar uma lógica dentro de uma procedure, segue um exemplo:
CREATE PROCEDURE teste @valor INT AS

	IF @valor > 10
	BEGIN
		PRINT 'Entrou no If';
	END;

	-- como seria em javascript:
	if(@valor > 10) {
		document.write('Entrou no IF');
	}