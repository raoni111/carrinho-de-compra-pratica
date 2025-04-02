namespace Programm
{
    class Praticando
    {
        static void Main(string[] args)
        {
            ProductiesManagement productiesManagement = new ProductiesManagement();

            ConsoleManagement consoleManagement = new ConsoleManagement(productiesManagement);

            consoleManagement.InitProgramm();
        }
    }
}