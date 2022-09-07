// See https://aka.ms/new-console-template for more information
using Biblioteca;

Livros livros = new Livros();

string opcao;
bool menuAberto = true;
int contador = 0;
livros.Inicio();
livros.LimparPropriedades();

Console.WriteLine("Biblioteca");

while (menuAberto)
{
    Console.Clear();

    Console.WriteLine("Escolha a opção desejada:\n");
    Console.WriteLine("1 - Cadastro");
    Console.WriteLine("2 - Emprestimo");
    Console.WriteLine("3 - Devolução");
    Console.WriteLine("4 - Renovação");
    Console.WriteLine("5 - Sair");


    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        livros.CadastroLivros();

        Console.WriteLine("Aperte qualquer teclar para continuar");
        Console.ReadKey();
    }

    else if (opcao == "2")
    {

        if (livros.VerificaLivros())
        {
            livros.EmprestimoLivros();
            contador = contador + 1;
            livros.LimparPropriedades();

            Console.WriteLine("Aperte qualquer teclar para continuar");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Produto não está cadastrado!\n");

            Console.WriteLine("Aperte qualquer teclar para continuar");
            Console.ReadKey();
        }
    }

    else if (opcao == "3")
    {
        livros.Devolucao();

        Console.WriteLine("Aperte qualquer teclar para continuar");
        Console.ReadKey();

    }

    else if (opcao == "4")
    {
        livros.Renovar();

        Console.WriteLine("Aperte qualquer teclar para continuar");
        Console.ReadKey();
    }

    else if (opcao == "5")
    {
        Console.WriteLine("Boa leitura!");
        menuAberto = false;
    }

}
