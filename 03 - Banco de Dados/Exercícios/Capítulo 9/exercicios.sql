CREATE DATABASE exercicio_capitulo_9;
USE exercicio_capitulo_9;

CREATE TABLE Cursos (
	Codigo INT identity(1, 1),
	Curso Varchar (20),
	primary key(Codigo)
);

CREATE TABLE Clientes (
	Codigo INT identity(1, 1),
	Cliente VARCHAR (30),
	Codigo_Curso INT, 
	primary key(Codigo),
	Foreign key (Codigo_Curso) references Cursos(Codigo)
);

INSERT INTO
	Cursos (Curso)
VALUES
	('Java'),
	('C#'),
	('Python'),
	('PHP'),
	('Node.js');


INSERT INTO
	Clientes (Cliente, Codigo_Curso)
VALUES
	('Larissa', 3),
	('Gabriel', 1),
	('Jean', 1),
	('Gabriella', 2),
	('Robson', 3),
	('Isabella', 3),
	('Eduardo', 2),
	('Juliana', 3),
	('Carlos', 2),
	('Lorena', 1);


-- Exercícios

-- Implementando o exercício anterior de Joins, crie uma View contendo as seguintes funcionalidades:
-- 1. Listar o nome do cliente e o nome do curso.



-- 2. Listar todos os cursos e o nome dos clientes que fazem determinado curso, caso não exista cliente para determinado curso, deverá aparecer null no nome do cliente.



-- 3. Exibir o nome dos cursos e a quantidade de clientes cadastrados em cada curso.



-- 4. Exibir em ordem alfabética o nome dos clientes.



-- 5. Excluir todas as Views criadas.