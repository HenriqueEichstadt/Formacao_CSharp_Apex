

namespace Capitulo11.OrientacaoObjetos.Objetos
{
    public class Pessoa
    {
        // características
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Rg { get; set; }
        public double Peso { get; set; }

        // construtor
        public Pessoa(string nome, string cpf, int rg)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
        }

        public Pessoa()
        {

        }

        // comportamentos
        public void Comer(string alimento)
        {
            Console.WriteLine(Nome + " comeu " + alimento);
            EscovarOsDentes();
        }

        public void Dormir()
        {
            EscovarOsDentes();
            Console.WriteLine("Dormir!");
        }

        // permitir que obejetos 'filhos' (que herdem da pessoa)
        // implementem 'Pensar' do seu próprio jeito
        public virtual void Pensar()
        {
            Console.WriteLine("Pessoa pensou!");
        }

        /*
         modificadores de acesso

            - public: todo mundo tem acesso
            - private: somente tem acesso dentro do próprio objeto
            - protected: usado com herança
         */
        private void EscovarOsDentes()
        {
            Console.WriteLine("Escovou os dentes!");
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Cpf: {Cpf}";
        }
    }
}
