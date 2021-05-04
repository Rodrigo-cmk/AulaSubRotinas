using System;

namespace AulaSubRotinas
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExibirHora();
            //AguardarUsuario();
            //ExibirHora();
            //AguardarUsuario("Pressione outra");
            //ExibirHora();

            //string nome = LerString("Nome: ");
            //string sobrenome = LerString("Sobrenome: ");

            //string nomeCompleto = obterNome(nome, sobrenome);

            //Console.WriteLine($"Obrigado, {nomeCompleto}");

            
        }

        static void ExibirHora()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.ResetColor();
        }

        static void AguardarUsuario(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
        static void AguardarUsuario()
        {
            AguardarUsuario("Pressione A");

        }

        static string obterNome(string nome, string sobrenome)
        {
            // poderia ter feito dessa forma: string nomeCompleto = $"{nome} {sobrenome}";
            // return nomeCompleto;
            return $"{nome} {sobrenome}";
        }

        static string LerString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}
