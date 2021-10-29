using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Pruduto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int n1)
        {
            Quantidade = Quantidade - n1;
            // Quantidade += n1;
        }
        public void RemoverProduto(int remore)
        {
            Quantidade -= remore;
        }
    }
}
