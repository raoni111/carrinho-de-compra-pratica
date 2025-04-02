namespace Programm
{
    class Product
    {
        public string Name;
        public double Price;
        public int Qtd = 0;

        public Product(string name, int qtd, double price)
        {
            Name = name;
            Qtd = qtd;
            Price = price;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Produto: {Name}");
            Console.WriteLine($"Quantidade: {Qtd}");
            Console.WriteLine($"Preço: {Price}");
        }

        public double GetTotal()
        {
            return Price * Qtd;
        }
    }
}