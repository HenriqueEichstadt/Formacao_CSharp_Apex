
SELECT * FROM Clientes;

-- Selecionar os clientes com mais de 22 anos

SELECT * FROM Clientes WHERE Idade > 22;

-- Selecionar os clientes com 22 anos ou mais

SELECT * FROM Clientes WHERE Idade >= 22;

-- filtrando com mais de uma condi��o usando Operador E (AND)

SELECT * FROM Clientes
	WHERE Idade > 22 AND Nome = 'Seu zé';


-- filtrando com mais de uma condi��o usando Operador OU (OR)

SELECT * FROM Clientes WHERE Idade > 22 OR Nome = 'João';


-- Obtendo o cliente com a menor idade

SELECT Min(Idade) FROM Clientes;

-- Obter o cliente com a maior idade

SELECT Max(Idade) FROM Clientes;

-- contando clientes

SELECT COUNT(*) FROM Clientes;

-- obtendo média de idade dos clientes

SELECT AVG(Idade) AS Media_Idade FROM CLIENTES;

-- Somando idade dos clientes

SELECT SUM(Idade) FROM CLIENTES;

-- Obter XXX registros da tabela clientes

SELECT TOP 2 * FROM Clientes;

-- filtrando nomes que começam com a letra 'j'

SELECT * FROM Clientes WHERE Nome LIKE 'j%';

-- filtrando nomes que terminam com a letra 'o'

SELECT * FROM Clientes WHERE Nome LIKE '%o';

-- filtrando nomes que tenham 'Guilherme'

SELECT * FROM Clientes WHERE Nome LIKE '%Guilherme%';

-- Obtendo clientes em que a idade é 25 ou 18
-- Usando operador lógico
SELECT * FROM Clientes where Idade = 25 OR Idade = 18
-- Usando IN
SELECT * FROM Clientes where Idade IN (25, 18)

-- Usando Between para obter entre um range de Idade
-- Usando operador lógico
SELECT * FROM Clientes Where Idade >= 25 AND Idade <= 80;
-- Usando BETWEEN
SELECT * FROM Clientes Where Idade BETWEEN 25 AND 80;


-- Order By
-- Obter os clientes ordenados pela idade (ordem crescente)
-- (A palavra ASC é opcional pois por padrão o SQL Server já ordena crescente)
SELECT * FROM Clientes ORDER BY Idade ASC;

-- Obter os clientes ordenados pela idade (ordem decrescente)
SELECT * FROM Clientes ORDER BY Idade DESC;

-- ordenando por uma coluna textual

SELECT * FROM Clientes ORDER BY Nome;

-- Group By

-- obter idade e e quantidade de clientes

-- Agrupo todos os clientes pela Idade e conto quantos possuem essa determinada idade
SELECT 
	Idade,
	COUNT(*)
FROM Clientes GROUP BY Idade;