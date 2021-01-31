using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace Projeto_2
{
    class Produto
    {
        public String Nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade; 
        }
        public void AdicionarProdutos(int quantity)
        {
            quantidade = quantidade + quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            quantidade -= quantity;
        }
        public override string ToString()
        {
            return Nome + ", $" + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ","
                + quantidade
                + "Unidade, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        
    }
}
