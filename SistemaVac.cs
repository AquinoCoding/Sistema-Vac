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
            public string sobrenome;
            public string rg;
            public string cep;
            public string numCell;

        }
        static List<Usuario> usuarios = new List<Usuario>();
        static Random rnd = new Random();


        static void Main(string[] args)
        {
            Console.WriteLine("Sistema iniciado...");
            Menu();

        }

        static void Menu()
        {

            Usuario usuario = new Usuario();
            Console.WriteLine("Cadastro de Usuário");

            Console.WriteLine("Informe o seu Primeiro Nome:");
            usuario.nome = Console.ReadLine();

            Console.WriteLine("Informe o seu Sobrenome:");
            usuario.sobrenome = Console.ReadLine();

            Console.WriteLine("Informe seu RG:");
            usuario.rg = Console.ReadLine();

            Console.WriteLine("Informe seu CEP:");
            usuario.cep = Console.ReadLine();

            Console.WriteLine("Informe seu numero de Celular: ");
            usuario.numCell = Console.ReadLine();

            usuarios.Add(usuario);

            Console.WriteLine("Cadastro concluido com Sucesso");
            ValidacaoToken();

        }

        static int Token()
        {

            int token = rnd.Next(1000, 9999);
            Console.WriteLine($"Seu Token é {token}");
            return token;

        }

        static void ValidacaoToken()
        {
            int tokenPass = Token();
            Console.WriteLine($"\nInforme o Token: ");
            int ValidationTokenUser = int.Parse(Console.ReadLine());

            if (ValidationTokenUser == tokenPass)
            {
                ConfirmCont();

            }
            else
            {
                Console.WriteLine("Token Incorreto");
            }

        }

        static void ConfirmCont()
        {

            Console.WriteLine("Token Validado com Sucesso\n");
            foreach (Usuario usuario in usuarios)
            {
                
                Console.WriteLine($"=========================================\n");
                Console.WriteLine($"Seja bem vindo(a): {usuario.nome}");
                Console.WriteLine("Confirme seus Dados!");
                Console.WriteLine($"Nome Completo: {usuario.nome} {usuario.sobrenome}");
                Console.WriteLine($"RG: {usuario.rg}");
                Console.WriteLine($"CEP: {usuario.cep}");
                Console.WriteLine($"Celular: {usuario.numCell}");
                Console.WriteLine($"=========================================\n");

            }
        }

    }
}
