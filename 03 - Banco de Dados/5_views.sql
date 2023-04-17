
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

-- views

-- criando uma view que busca clientes e cidade do cliente
CREATE VIEW BuscaClientesECidades AS
SELECT
	cli.Id AS IdCliente,
	cli.Nome NomeCliente,
	cid.Nome NomeCidade
FROM Clientes cli
	INNER JOIN Cidades cid ON cid.Id = cli.IdCidade;

-- executando a view
SELECT * FROM BuscaClientesECidades;

-- excluindo a view
DROP VIEW BuscaClientesECidades;


