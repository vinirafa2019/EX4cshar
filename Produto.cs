using System;
using System.Collections.Generic;
using System.Text;

namespace EX_4
{
    class Produto
    {
        public  string nome;
        public double preco;
        public int qtd;
        //Metodo Contrutor
        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        //get/set
        public string getnome()
        {
            return nome;
        }
        public void setnome(string nome)
        {
            this.nome = nome;
        }
        public double getpreco()
        {
            return preco;
        }
        public void setpreco(double preco)
        {
            this.preco = preco;
        }
        public int getqtd()
        {
            return qtd;
        }
        public void setqtd(int qtd)
        {
            this.qtd = qtd;

        }
    
    }
}