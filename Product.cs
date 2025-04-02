namespace Programm
{
    class Product
    {
        public string name;
        public double price;
        public int qtd = 0;

        public Product(string name, int qtd, double price)
        {
            this.name = name;
            this.qtd = qtd;
            this.price = price;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Produto: {name}");
            Console.WriteLine($"Quantidade: {qtd}");
            Console.WriteLine($"Preço: {price}");
        }

        public double GetTotal()
        {
            return price * qtd;
        }
    }
}