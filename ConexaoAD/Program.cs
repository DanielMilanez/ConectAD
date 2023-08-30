using System;


namespace ConexaoAD {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira seu nome de usuário: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string user = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Insira sua senha: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            bool verificando = Conect.AuthenticateUser("192.168.1.12",user, password);

            while (verificando == false) {
                Console.WriteLine();
                Console.WriteLine("Credenciais inválidas");

                Console.Write("Insira seu nome de usuário: ");
                user = Console.ReadLine();
                Console.Write("Insira sua senha: ");
                password = Console.ReadLine();

                verificando = Conect.AuthenticateUser("192.168.1.12", user, password);
            }
            if (verificando == true) {
                Console.WriteLine();
                Console.Write($"Bem-Vindo ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(user);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
            }
        }
    }
}


