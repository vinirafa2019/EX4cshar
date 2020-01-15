using System;
using System.Collections.Generic;
using System.Text;

namespace EX_4
{
    class Livro : Produto
    {
        private string autor;
		private string tema;
		private int qtdPag;

		public Livro(string nome, double preco, int qtd,string autor, string tema, int qtdPag) : base(nome, preco, qtd)
		{
			
			this.autor = autor; 
			this.tema = tema;
			this.qtdPag = qtdPag;
		}
		


		//get and set
		public string getautor()
		{
			return autor;
		}
		public void setautor(string autor)
		{
			this.autor = autor;
		}
		public string gettema()
		{
			return tema;
		}
		public void settema(string tema)
		{
			this.tema = tema;
		}
		public int getqtdPag()
		{
			return qtdPag;
		}
		public void setqtdPag(int qtdPag)
		{
			this.qtdPag = qtdPag;
		}

		public Double calculaImposto()
		{
			double I = 0;
			if (tema == "educativo")
			{
				Console.WriteLine("Livro educativo nao tem imposto: " + getnome());
				return I;
			}
			else
			{
				I = preco * 0.10;
				Console.WriteLine("R$" + I + " De impostos sobre o livro " + getnome());
				return I;
			}


		}
	}
 }

