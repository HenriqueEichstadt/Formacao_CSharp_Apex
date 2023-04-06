
-- adicionar registro na tabela de clientes

INSERT INTO Clientes (Id, Nome, Cpf, Idade, Email)
	VALUES (1, 'Seu zé', '000.000.000-00', 25, 'ze@gmail.com');


-- Criando vários registros ao mesmo tempo

INSERT INTO Clientes (Id, Nome, Cpf, Idade, Email)
	VALUES 
	(2, 'João', '123.000.000-00', 18, 'joao@gmail.com'),
	(3, 'Maria', '456.000.000-00', 22, 'maria@gmail.com'),
	(4, 'Siilvio', '789.000.000-00', 30, 'silvio@gmail.com');


-- selecionar todos os dados (consultar)

SELECT * FROM Clientes;

-- selecionar apenas algumas colunas da tabela (consultar)

SELECT Email, Nome FROM Clientes;

-- selecionar registros dando apelido a colunas

SELECT Email AS MeuEmail, Nome AS ColunaNome FROM Clientes;

-- atualizando uma coluna de um registro

UPDATE Clientes SET Cpf = '123.456.789-11' WHERE Id = 1;

-- Excluir um registro filtrado da tabela

DELETE FROM Clientes WHERE Cpf = '789.000.000-00';

-- excluir todos os clientes

DELETE FROM Clientes;





