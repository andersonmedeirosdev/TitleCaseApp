using System.Globalization;

namespace TitleCaseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva uma frase para manipularmos:");
            string titulacao = Console.ReadLine();

            string novoTexto = ConverterTitleCase(titulacao);
            Console.WriteLine(novoTexto);
            
            Console.ReadLine();
        }

        static string ConverterTitleCase(string titulacao)
        {
            var textinfo = new CultureInfo("pt-BR", false).TextInfo;
            return textinfo.ToTitleCase(titulacao);
        }
    }
}