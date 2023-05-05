namespace Capitulo11.Polimorfismo
{
    internal class Program
    {
        /*
         Nesse exemplo, temos uma classe base 'Pessoa' e uma classe derivada 'Aluno' 
        (herdando de pessoa). 
         A classe base(mãe) tem um método 'Falar', que é virtual, 
        e a classe derivada sobrescreve esse método. 
         
        Na classe 'Program', criamos duas instâncias de 'Pessoa': uma é do tipo 'Pessoa' e a outra é do tipo 'Aluno', 
          mas ambas são referenciadas pela classe base 'Pessoa'.
         Quando chamamos o método 'Falar' na instância 'pessoa1', a saída será "Pessoa falando...", pois 'pessoa1' é do tipo 'Pessoa'. 
         Quando chamamos o método 'Falar' na instância 'pessoa2', a saída será "Aluno falando...", pois 'pessoa2' é do tipo 'Aluno', 
          que sobrescreveu o método 'Falar' da classe base(mãe).
         */
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            // variável do tipo 'Pessoa' consegue receber um Aluno pois um aluno também é uma 'Pessoa' por conta da herança
            Pessoa pessoa2 = new Aluno(); //aqui

            pessoa1.Falar(); // Saída: Pessoa falando...
            pessoa2.Falar(); // Saída: Aluno falando...

            Aluno aluno1 = new Aluno();

            List<Pessoa> minhaLista = new List<Pessoa>();

            minhaLista.Add(pessoa1);
            minhaLista.Add(pessoa2);
            minhaLista.Add(aluno1);

            foreach(var item in minhaLista)
            {
                item.Falar();
            }
        }
    }
}