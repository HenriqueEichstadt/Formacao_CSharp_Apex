using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo15_16_17.BancoDeDados
{
    /*
	Id INT IDENTITY(1, 1),
	Nome VARCHAR(30),
	Idade INT,
	Email VARCHAR(40),
	PRIMARY KEY(Id)
	*/
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }
}
