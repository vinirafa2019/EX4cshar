using System;
using System.Collections.Generic;
using System.Text;

namespace EX_4
{
    class Loja
    {
        private String nome;
        private String cnpj;
        private List<Livro> livros;
        private List<VideoGame> games;

  

        public Loja(String nome, String cnpj, List<Livro> livros, List<VideoGame> games)
        {
            this.cnpj = cnpj;
            this.nome = nome;
            this.livros = livros;
            this.games = games;
        }


        public String getnome()
        {
            return nome;
        }
        public void setnome(String nome)
        {
            this.nome = nome;
        }
        public String getcnpj()
        {
            return cnpj;
        }
        public void setcnpj(String cnpj)
        {
            this.cnpj = cnpj;
        }

        public void listalivros()
        {

            Console.WriteLine("--------------------------------------");
            if (livros != null)
            {
                Console.WriteLine("A loja Americanas possui estes livros para venda: \n");

                livros.ForEach(l1 => Console.WriteLine("Titulo: "+ l1.getnome()+", Preço: " + l1.getpreco()+ ", Quantidade: " + l1.getqtd()+ ", " + l1.getautor()+ ", " + l1.gettema()+ ", " + l1.getqtdPag()));

            }
            else { Console.WriteLine("A loja não tem livros no seu estoque"); }
            Console.WriteLine("------------------------------------------------");
        }
        public void listaVideoGame()
        {
            if (games != null)
            {
                Console.WriteLine("A loja Americanas possui estes videogames para venda: \n");
                games.ForEach(ps4 => Console.WriteLine("Video-game: "+ ps4.getmodelo() + ", Preço: " + ps4.getpreco() + ", Quantidade: " + ps4.getqtd()+" em estoque"));
            }
            else { Console.WriteLine("A loja não tem video-games no seu estoque"); }
            Console.WriteLine("------------------------------------------------");
        }

        public double calculaPatrimonio()
        {
            Double r = 0.00;
            foreach (Livro i in livros)
            {
                r =r + i.getpreco() * i.getqtd();
            }
            foreach(VideoGame i in games)
            {
                r = r+ i.getpreco() * i.getqtd(); ;
            }
            Console.WriteLine("O patrimonio da loja: " + getnome() + " é de " + r);
            
            return r;
        }
    }
}