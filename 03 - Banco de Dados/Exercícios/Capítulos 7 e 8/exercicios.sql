
-------------------------
--Com base neste capítulo, desenvolva as questões abaixo utilizando as funcionalidades dos Joins:

--1. Criar uma base de dados chamada exercicio_joins
CREATE DATABASE exercicio_joins;
USE exercicio_joins;

--2. Implemente a tabela cursos, com os seguintes campos:
	--Código INT AI(Auto incremento) e PK(Primary key)
	--Curso VARCHAR(20)
CREATE TABLE Cursos (
	Codigo INT identity(1, 1),
	Curso Varchar (20),
	primary key(Codigo)
);


--3. Desenvolva a tabela clientes, com os seguintes campos:
	--Código INT AI e PK
	--Cliente VARCHAR(30)
	--Codigo_Curso INT FK
CREATE TABLE Clientes (
	Codigo INT identity(1, 1),
	Cliente VARCHAR (30),
	Codigo_Curso INT, 
	primary key(Codigo),
	Foreign key (Codigo_Curso) references Cursos(Codigo)
);

--4. Cadastre os cursos:
	--1 Java
	--2 C#
	--3 Python
	--4 PHP
	--5 Node.js
INSERT INTO
	Cursos (Curso)
VALUES
	('Java'),
	('C#'),
	('Python'),
	('PHP'),
	('Node.js');

	select * from Cursos



--5. Cadastre os seguintes clientes:
	--1 Larissa 3
	--2 Gabriel 1
	--3 Jean 1
	--4 Gabriella 2
	--5 Robson 3
	--6 Isabella 3
	--7 Eduardo 2
	--8 Juliana 3
	--9 Carlos 2
	--10 Lorena 1
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

	   	  
--6. Liste o nome dos clientes e o nome dos cursos que cada um está participando.
SELECT
	clientes.Cliente AS NomeCliente,
	Cursos.Curso AS NomeCurso
FROM
	clientes
	INNER JOIN Cursos ON Cursos.Codigo = Clientes.Codigo_Curso

--7. Contar a quantidade de cursos adquiridos pelos clientes. Exiba o nome e a quantidade desses cursos. 
--Será obrigatório a exibição de todos os cursos, independente se há clientes realizando esse curso.

SELECT 
	Cursos.Curso AS Nome,
count (Clientes.Codigo_Curso)
from Cursos
	LEFT JOIN Clientes ON Clientes.Codigo_Curso = Cursos.Codigo
group by Cursos.Curso;

-- 8. Exiba o nome dos cursos que não possuem nenhum cliente participando

SELECT
	Curso
FROM Clientes
	RIGHT JOIN Cursos ON Cursos.Codigo = Clientes.Codigo_Curso
WHERE Cliente IS NULL
GROUP BY Curso;