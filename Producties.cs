namespace Programm
{
    class ProductiesManagement
    {
        private List<Product> Producties = new List<Product>();

        public double Total
        {
            get
            {
                double total = 0;

                for (int i = 0; i < Producties.Count(); i++)
                {
                    total += Producties[i].Total;
                }

                return total;
            }
        }

        public int Length
        {
            get
            {
                return Producties.Count();
            }
        }


        public List<Product> AddProduct(Product product)
        {
            Producties.Add(product);

            return Producties;
        }

        public bool RemoveProduct(int index)
        {
            try
            {
                Producties.Remove(Producties[index]);
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

            for (int i = 0; i < Producties.Count(); i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("|--------------------------------------------------");
                }
                Console.WriteLine($"| Produto: {i + 1}");
                Console.WriteLine($"| Nome: {Producties[i].Name}");
                Console.WriteLine($"| Quatidade: {Producties[i].Qtd}");
                Console.WriteLine($"| Preço: R${Producties[i].Price.ToString("F2")}");
                Console.WriteLine($"| Preço Total: R${Producties[i].Total.ToString("F2")}");

            }

            if (!simplified) {
                Console.WriteLine("===================================================");
                Console.WriteLine($"| Valor Total: R${Total.ToString("F2")}");
                Console.WriteLine("===================================================");
                Console.WriteLine("| Aperte enter para voltar.");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("===================================================");
            }
        }
    }
}