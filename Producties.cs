using System.Globalization;

namespace Programm
{
    class ProductiesManagement
    {
        List<Product> producties = new List<Product>();

        public List<Product> AddProduct(Product product)
        {
            producties.Add(product);

            return producties;
        }

        public bool RemoveProduct(int index)
        {
            return producties.Remove(producties[index]);
        }

        public void DisplayProducties(bool simplified)
        {
            Console.Clear();
            Console.WriteLine("===================================================");
            Console.WriteLine("|                    Produtos                      ");
            Console.WriteLine("===================================================");

            for (int i = 0; i < producties.Count(); i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("|--------------------------------------------------");
                }
                Console.WriteLine($"| Produto: {i + 1}");
                Console.WriteLine($"| Nome: {producties[i].name}");
                Console.WriteLine($"| Quatidade: {producties[i].qtd}");
                Console.WriteLine($"| Preço: R${producties[i].price.ToString("F2")}");
                Console.WriteLine($"| Preço Total: R${producties[i].GetTotal()}");

            }

            if (!simplified) { 
                Console.WriteLine("|--------------------------------------------------");
                Console.WriteLine($"| Valor Total: {TotalPrice().ToString("F2")}");
                Console.WriteLine("===================================================");
                Console.WriteLine("| Aperte qualquer botão para voltar");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("===================================================");
            }
        }

        public double TotalPrice()
        {
            double total = 0;

            for (int i = 0; i < producties.Count(); i++)
            {
                total += producties[i].GetTotal();
            }

            return total;
        }

        public int Length()
        {
            return producties.Count();
        }
    }
}