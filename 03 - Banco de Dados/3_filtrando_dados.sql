
SELECT * FROM Clientes;

-- Selecionar os clientes com mais de 22 anos

SELECT * FROM Clientes WHERE Idade > 22;

-- Selecionar os clientes com 22 anos ou mais

SELECT * FROM Clientes WHERE Idade >= 22;

-- filtrando com mais de uma condição usando Operador E (AND)

SELECT * FROM Clientes WHERE Idade > 22 AND Nome = 'Seu zé'


-- filtrando com mais de uma condição usando Operador OU (OR)

SELECT * FROM Clientes WHERE Idade > 22 OR Nome = 'João'

