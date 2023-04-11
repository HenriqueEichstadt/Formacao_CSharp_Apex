
-- Exercícios

-- 1. Criar uma base de dados chamada: exercicio

CREATE DATABASE exercicio;

-- 2. Selecionar a base criada anteriormente

USE exercicio;

-- 3. Criar uma tabela chamada uzuarios, com a seguinte estrutura:
        -- a. nome varchar de 20 caracteres
        -- b. sobrenome de 40 caracteres
        -- c. idade do tipo inteiro

CREATE TABLE Uzuarios(
	Nome VARCHAR(20),
	Sobrenome VARCHAR(40),
	Idade INT
);

-- 4. Renomeie a tabela uzuarios para usuarios.

EXEC sp_rename 'Uzuarios', 'Usuarios';

-- 5. Adicione uma coluna e-mail com suporte até 40 caracteres

ALTER TABLE Usuarios ADD Email VARCHAR(40);

-- 6. Exclua a coluna Sobrenome

ALTER TABLE Usuarios DROP COLUMN Sobrenome;

-- 7. Cadastre os seguintes dados:
    /*
    Nome, Idade, Email
    Vanessa 16 vanessa.rosa@gmail.com
    Adailton 22 adailton.mas@yahoo.com
    Andressa 36 andressa.simas@uol.com.br
    Mayra 24 mayra_antunes@gmail.com
    Cristiane 14 cris.maya@gmail.com
    Carina 27 carina.almeida@gmail.com
    Clóvis 29 clovis.simao@hotmail.com
    Gabriela 23 gabriela.bragantino@live.com
    Cibele null cibele_lins@uol.com.br
    */

INSERT INTO Usuarios (Nome, Idade, Email)
	VALUES
	('Vanessa', 16, 'vanessa.rosa@gmail.com'),
    ('Adailton', 22, 'adailton.mas@yahoo.com'),
    ('Andressa', 36, 'andressa.simas@uol.com.br'),
    ('Mayra', 24, 'mayra_antunes@gmail.com'),
    ('Cristiane', 14, 'cris.maya@gmail.com'),
    ('Carina', 27, 'carina.almeida@gmail.com'),
    ('Clóvis', 29, 'clovis.simao@hotmail.com'),
    ('Gabriela', 23, 'gabriela.bragantino@live.com'),
    ('Cibele', null, 'cibele_lins@uol.com.br');

-- 8. Exiba quantos registros existem na tabela

SELECT COUNT(*) FROM Usuarios;

-- 9. Exibir a quantidade de usuários com idade até 17 anos

SELECT COUNT(*) AS Quantidade FROM Usuarios where Idade <= 17;

-- 10.Retornar a quantidade de usuários com o e-mail gmail

SELECT COUNT(*) FROM Usuarios WHERE Email LIKE '%gmail%';

-- 11.Retornar o nome e a idade da pessoa mais velha

SELECT TOP 1 Nome, Idade FROM Usuarios ORDER BY Idade DESC;

-- 12.Retornar os dados do usuário com idade igual a nulo

SELECT * FROM Usuarios Where Idade IS NULL;
--SELECT * FROM Usuarios Where Idade IS NOT NULL

-- 13.Alterar para 27 todas as idades nulas

UPDATE Usuarios SET Idade = 27 WHERE Idade IS NULL;

-- 14.Deletar todos os usuários com idade inferior a 18 anos

DELETE FROM Usuarios WHERE Idade < 18;

-- 15.Excluir todos os dados da tabela e reiniciar a contabilização

DELETE FROM Usuarios;

-- 16.Excluir a base de dados

DROP DATABASE exercicio;

-- EXTRAS
-- 17. Obter Nome e Idade do Usuário mais novo (menor idade)

SELECT TOP 1 Nome, Idade FROM Usuarios ORDER BY Idade;

-- 18. Obter média de Idade dos Usuarios

SELECT AVG(Idade) FROM Usuarios;

-- 19. Obter Soma da idade dos Usuários

SELECT SUM(Idade) FROM Usuarios;

-- 20. Obter Idade e quantidade de registros (com a idade)

SELECT 
	Idade,
	COUNT(*)
FROM Usuarios GROUP BY Idade;