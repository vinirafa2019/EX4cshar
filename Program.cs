using System.Collections;

using System.Collections.Generic;
namespace EX_4
{
	class Program
    {	
		static void Main(string[] args)
        {
			Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
			Livro l2 = new Livro("Senhor Dos Anéis", 60, 30, "J. R. R. tolkien", "fantasia", 500);
			Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

			VideoGame ps4 = new VideoGame("ps4", 1800, 100, "Sony", "Slim", false);
			VideoGame ps4Usado = new VideoGame("ps4", 1000, 7, "Sony", "Slim", true);
			VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);


			List<Livro> livros = new List<Livro>();
			livros.Add(l1);
			livros.Add(l2);
			livros.Add(l3);

			List<VideoGame> games = new List<VideoGame>();
			games.Add(ps4);
			games.Add(ps4Usado);
			games.Add(xbox);

			Loja americanas = new Loja("Americanas", "12345678",livros,games);

			l2.calculaImposto();
			l3.calculaImposto();

			ps4Usado.calculaImposto();
			ps4.calculaImposto();

			americanas.listalivros();
			americanas.listaVideoGame();
			americanas.calculaPatrimonio();
			
		}
	}
}
