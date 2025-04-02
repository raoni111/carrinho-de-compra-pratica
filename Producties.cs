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
            try
            {
                producties.Remove(producties[index]);
                return true;
            } catch
            {
                return false;
            }
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
                Console.WriteLine($"| Nome: {producties[i].Name}");
                Console.WriteLine($"| Quatidade: {producties[i].Qtd}");
                Console.WriteLine($"| Preço: R${producties[i].Price.ToString("F2")}");
                Console.WriteLine($"| Preço Total: R${producties[i].GetTotal().ToString("F2")}");

            }

            if (!simplified) {
                Console.WriteLine("===================================================");
                Console.WriteLine($"| Valor Total: R${TotalPrice().ToString("F2")}");
                Console.WriteLine("===================================================");
                Console.WriteLine("| Aperte enter para voltar.");
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