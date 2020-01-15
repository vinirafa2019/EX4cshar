using System;
using System.Collections.Generic;
using System.Text;

namespace EX_4
{
    class VideoGame : Produto 
    {
		private String marca;
		private String modelo;
		private bool isUsado;

		public VideoGame(String nome, double preco, int qtd, String marca, String modelo, bool isUsado) : base (nome,preco,qtd)
		{			
			this.marca = marca;
			this.modelo = modelo;
			this.isUsado = isUsado;
		}
		public String getmarca()
		{
			return marca;
		}
		public void setmarca(String marca)
		{
			this.marca = marca;
		}
		public String getmodelo()
		{
			return modelo;
		}
		public void setmodelo(String modelo)
		{
			this.modelo = modelo;
		}
	

		public Double calculaImposto()
		{
			double I = 0;
			if (isUsado == true)
			{
				I = preco * 0.25;
				Console.WriteLine("Imposto PS4 Slim Usado,R$ " + I);
				return I;
			}
			else
			{
				I = preco * 0.45;
				Console.WriteLine("Imposto PS4 Slim, R$ " + I);
				return I;
			}
		}
	}
}
