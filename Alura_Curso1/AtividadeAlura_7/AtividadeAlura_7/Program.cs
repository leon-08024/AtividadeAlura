//Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.


        // Dicionário com usuários e suas senhas
        Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "usuario1", "senha123" },
            { "admin", "admin2024" },
            { "joao", "abc123" }
        };



        void SistemaDeLogin()
        {
            Console.WriteLine("Sistema de Login\n");
            Console.Write("Digite o nome de usuário: ");
            string username = Console.ReadLine()?.Trim() ?? "";
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine()?.Trim() ?? "";
            // Verifica se o usuário existe no dicionário
            if (usuarios.ContainsKey(username))
            {
                // Verifica se a senha está correta
                if (usuarios[username] == senha)
                {
                    Console.WriteLine("Login realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Senha incorreta. Acesso negado.");
                }
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }
