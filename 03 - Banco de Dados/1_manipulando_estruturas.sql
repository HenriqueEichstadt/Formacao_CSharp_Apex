
-- Criando um banco de dados 'Projeto'

CREATE DATABASE Projeto;


-- comando para avisar o SQL Server qual banco deseja utilizar

USE Projeto;

-- Criando uma tabela clientes

CREATE TABLE Clientes(
	Id INT NOT NULL,
	Nome VARCHAR(200),
	Cpf VARCHAR(14),
	Idade INT
);

-- Adicionar uma coluna a uma tabela existente

ALTER TABLE Clientes ADD Email VARCHAR(100);

-- Remover uma coluna da tabela

ALTER TABLE Clientes DROP COLUMN Email;

-- Renomear o nome de uma tabela

EXEC sp_rename 'Clientes', 'Usuarios';

-- Excluir tabala

DROP TABLE Usuarios;

-- Excluir banco de dados

DROP DATABASE Projeto;



