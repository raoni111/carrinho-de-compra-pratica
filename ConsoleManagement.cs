namespace Programm
{
    class ConsoleManagement
    {
        public ProductiesManagement productiesManagement;        

        public ConsoleManagement(ProductiesManagement productiesManagement)
        {
            this.productiesManagement = productiesManagement;
        }

        public void InitProgramm()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================================================");
                Console.WriteLine("|               Carrinho de Compras                ");
                Console.WriteLine("===================================================");
                Console.WriteLine($"| Produtos: {productiesManagement.Length()}");
                Console.WriteLine("|--------------------------------------------------");
                Console.WriteLine("| Opções:                                          ");
                Console.WriteLine("| [1] Adicionar Produto                            ");
                Console.WriteLine("| [2] Apagar Produto                               ");
                Console.WriteLine("| [3] Mostrar Produtos                             ");
                Console.WriteLine("---------------------------------------------------");
                int option = ReadOption();
                Console.WriteLine("===================================================");

                OptionManagement(option);
            }
        }
        void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("===================================================");
            Console.WriteLine("|                Adicionar ao Carrinho             ");
            Console.WriteLine("===================================================");
            string productName = ReadString("| Nome do Produto: ");
            int qtd = ReadInterger("| Quantidade: ");
            double price = ReadPrice();

            Product product = new Product(productName, qtd, price);

            productiesManagement.AddProduct(product);
        }

        void RemoveProduct()
        {
            Console.Clear();
            Console.WriteLine("===================================================");
            Console.WriteLine("|                Adicionar ao Carrinho             ");
            Console.WriteLine("===================================================");
        }

        static int ReadInterger(string msg)
        {
            int interger;

            while (true)
            {
                try
                {
                    Console.Write($"| {msg}");
                    interger = int.Parse(Console.ReadLine());
                    break;
                } catch
                {
                    Console.WriteLine("| Digite um valor valido! ");
                }
            }

            return interger;
        }

        static double ReadPrice()
        {
            double price;

            while (true)
            {
                try
                {
                    Console.Write("| Preço: ");
                    price = double.Parse(Console.ReadLine());
                    break;
                } catch
                {
                    Console.WriteLine("| Digite um valor valido!");
                }
            }

            return price;
        }
        static string ReadString(string msg)
        {
            Console.Write($"| {msg}");
            string str = Console.ReadLine();

            return str;
        }
        static int ReadOption() 
        {
            int option = 0;
            while (true) {
                try
                {
                    Console.Write("| Escolha uma opção: ");
                    option = int.Parse(Console.ReadLine());
                    break;
                } catch
                {
                    Console.WriteLine("| Escolha uma opção valida");
                }
            }
            return option;
        }

        void OptionManagement(int option)
        {
            if (option == 0 || option > 3)
            {

                return;
            }

            switch (option)
            {
                case 1:
                    AddProduct();
                    return;
                case 3:
                    productiesManagement.DisplayProducties(false);
                    return;
                default:
                    return;
            }
        }
    }
}