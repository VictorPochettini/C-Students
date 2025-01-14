using System;

class Nomes
{
    static void Cadastro(string[] alunos)
    {
        for (int i = 0; i < 100; i++)
        {
            if (alunos[i] == null)
            {
                Console.Write("Digite o nome do aluno: ");
                alunos[i] = Console.ReadLine();
                Console.WriteLine("Aluno cadastrado!\n");
                break;
            }
        }
    }

    static void Ler(string[] alunos, string procurado)
    {
        bool encontrado = false;
        for (int i = 0; i < 100; i++)
        {
            if (alunos[i] == procurado)
            {
                Console.WriteLine($"O aluno {procurado} foi encontrado!\n");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"O aluno {procurado} não existe :(\n");
        }
    }

    static void Deletar(string[] alunos, string deletado)
    {
        bool encontrado = false;
        for (int i = 0; i < 100; i++)
        {
            if (alunos[i] == deletado)
            {
                alunos[i] = null;
                Console.WriteLine("O aluno foi deletado\n");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("O aluno não existe\n");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite a ação que deseja executar:\n(1) Cadastrar aluno\n(2) Procurar aluno\n(3) Deletar aluno\n");
        int opcao = int.Parse(Console.ReadLine());
        string[] alunos = new string[100];

        switch (opcao)
        {
            case 1:
                Cadastro(alunos);
                break;
            case 2:
                Console.Write("Digite o nome do aluno procurado:\n");
                string procurado = Console.ReadLine();
                Ler(alunos, procurado);
                break;
            case 3:
                Console.Write("Digite o nome do aluno a ser deletado:\n");
                string deletado = Console.ReadLine();
                Deletar(alunos, deletado);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}
