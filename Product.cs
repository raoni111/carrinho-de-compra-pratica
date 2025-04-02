namespace Programm
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Qtd {get; private set;}

        public Product(string name, int qtd, double price)
        {
            Name = name;
            Qtd = qtd;
            Price = price;
        }
        public double Total
        {
            get
            {
                return Price * Qtd;
            }
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Produto: {Name}");
            Console.WriteLine($"Quantidade: {Qtd}");
            Console.WriteLine($"Preço: {Price}");
        }


    }
}