using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livros
    {
        public string Nome { get; set; }

        public string Autor { get; set; }

        public int QuantidadeLivros { get; set; }

        public int LivrosEmprestados { get; set; }

        public int Aluguel { get; set; }

        public int DiasComLivro { get; set; }

        int contador = 0;

        public int QuantRenovacoes { get; set; }

        public int qtdLivrosCadastrados { get; set; }


        public void Inicio()
        {
            QuantidadeLivros = 3;
            Aluguel = 15;
        }

        public void CadastroLivros()
        {
            Console.WriteLine("Digite o nome do livro: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do autor do Livro: ");
            Autor = Console.ReadLine();

            Console.WriteLine("Cadastro efetuado com sucesso\n");
        }

        public bool VerificaLivros()
        {
            if (Nome == "" || Autor == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void EmprestimoLivros()
        {
            Console.WriteLine("Informe a quantidade de livros desejados");
            LivrosEmprestados = Convert.ToInt32(Console.ReadLine());


            if (LivrosEmprestados > QuantidadeLivros)
            {
                Console.WriteLine("Quantidade excedida. Máximo de 3 livros\n");
            }

            else
            {
                Console.WriteLine("Empréstimo efetuado");
                Console.WriteLine($"Você pegou {LivrosEmprestados} livros\n");
            }

        }

        public void Devolucao()
        {

            Console.WriteLine("Informe quantos dias ficou com o livro:");
            DiasComLivro = Convert.ToInt32(Console.ReadLine());

            if (DiasComLivro <= Aluguel)
            {
                Console.WriteLine("Livro(s) entregue a tempo!");
            }

            else
            {
                contador = DiasComLivro - Aluguel;
                Console.WriteLine($"Você passou {contador} dias do prazo máximo que era de {Aluguel} dias! Seu cadastro foi bloqueado.");
            }

        }

        public void Renovar()
        {
            if (QuantRenovacoes < 2)
            {
                DiasComLivro = DiasComLivro + 15;

                Console.WriteLine("Renovado com sucesso!\n");

                QuantRenovacoes++;
            }
            else
            {
                Console.WriteLine("Limite máximo de renovações é de 02.\n");
            }
        }

        public void LimparPropriedades()
        {
            Nome = "";
            Autor = "";
        }

    }
}

