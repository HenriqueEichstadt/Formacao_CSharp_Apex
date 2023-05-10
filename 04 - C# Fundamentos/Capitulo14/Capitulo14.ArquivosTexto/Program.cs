using System.Text;

namespace Capitulo14.ArquivosTexto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //LerArquivoTextoComStreamReader();
            //EscreverArquivoTextoComStreamWriter();
            //EscreverArquivoComFileStream();
            //LerArquivoComFileStream();
            //EscreverArquivoComFile();
            //LerArquivoComFile();
        }

        public static void LerArquivoTextoComStreamReader()
        {
            var cout = 1;
            StreamReader sr = new StreamReader(@"D:\OneDrive\Documentos\APEX ENSINO\Formação - Programação C#\Repositório GitHub\04 - C# Fundamentos\Capitulo14\Capitulo14.ArquivosTexto\input.txt");
            while (!sr.EndOfStream)
            {
                string linha = sr.ReadLine();
                Console.WriteLine($"linha {cout}: {linha}");
                cout++;
            }
        }

        public static void EscreverArquivoTextoComStreamWriter()
        {
            StreamWriter sw = new StreamWriter(@"D:\OneDrive\Documentos\APEX ENSINO\Formação - Programação C#\Repositório GitHub\04 - C# Fundamentos\Capitulo14\Capitulo14.ArquivosTexto\input2.txt");
            sw.AutoFlush = true;
            sw.WriteLine("Maria 123");
            sw.WriteLine("Zé 456");
            sw.WriteLine("André 789");
            sw.Close();
        }

        public static void EscreverArquivoComFileStream()
        {
            FileStream fluxoSaida = new FileStream("ArquivoSaidaFileStream.txt", FileMode.OpenOrCreate, FileAccess.Write);
            
            string mensagemSaida = "Olá, boa noite!";

            byte[] array = Encoding.UTF8.GetBytes(mensagemSaida);
            int posicao = 0;
            int tamanho = mensagemSaida.Length;
            fluxoSaida.Write(array, posicao, tamanho);
            fluxoSaida.Close();
        }

        public static void LerArquivoComFileStream()
        {
            using (FileStream fluxoEntrada = new FileStream("ArquivoSaidaFileStream.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] bytesLidos = new byte[fluxoEntrada.Length];
                int posicao = 0;

                fluxoEntrada.Read(bytesLidos, posicao, (int)fluxoEntrada.Length);
                string texto = Encoding.UTF8.GetString(bytesLidos);

                Console.WriteLine("Mensagem Lida: " + texto);
            }
        }

        public static void EscreverArquivoComFile()
        {
            // Sobrescreve se arquivo já existir
            File.WriteAllText("Arquivo.txt", "Olá, boa noite. Hoje é Terça");

            // Adicionando ao final do arquivo
            File.AppendAllText("Arquivo.txt", "Aula de leitura e escrita de arquivos.");

            if (File.Exists("Arquivo.txt"))
            {
                Console.WriteLine("O Arquivo já existe");
            }

            // Copiando conteúdo de um arquivo para outro
            File.Copy("Arquivo.txt", "CopiaArquivo.txt", true);
        }

        public static void LerArquivoComFile()
        {
            var leitor = File.OpenText("CopiaArquivo.txt");
            var texto = leitor.ReadToEnd();
            Console.WriteLine($"Texto copiado: {texto}");
            leitor.Close();
        }
    }
}