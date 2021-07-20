using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemaVacina
{
    class SistemaVac
    {
        struct Usuario
        {
            public string nome;
            public string rg;
            public string cep;
            public string numCell;

        }

        static List<Usuario> usuarios = new List<Usuario>();
        static Random rnd = new Random();


        static void Main(string[] args)
        {
            Console.WriteLine("Sistema iniciado...");
             Token();
        }

        static void Menu()
        {

            Usuario usuario = new Usuario();
            Console.WriteLine("Cadastro de Usuário");

            Console.WriteLine("Informe o seu nome Completo:");
            usuario.nome = Console.ReadLine();

            Console.WriteLine("Informe seu RG:");
            usuario.rg = Console.ReadLine();

            Console.WriteLine("Informe seu CEP:");
            usuario.cep = Console.ReadLine();

            Console.WriteLine("Informe seu numero de Celular: ");
            usuario.numCell = Console.ReadLine();

            usuarios.Add(usuario);
        }

        static void Token()
        {
            
            int token = rnd.Next(1000, 9999);
            Console.Write(token);

        }

        static void ValidacaoToken()
        {

            Console.WriteLine("Informe o Token: ");
            string ValidationTokenUser = Console.ReadLine();

            if (ValidationTokenUser == Token.token){

            }

        }

    }
}
