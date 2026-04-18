using System.Text;
namespace FinanceTrace_v0._2
{
    internal class Program
    {
        const string AppName = "FinanceTrace";
        const string Version = "0.2";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            decimal totalIncome = 0;
            decimal totalOutcome = 0;

            Console.WriteLine($"=== {AppName} v{Version} ===");
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();



            // Show Menu
            static void ShowMenu()
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("1) Add income");
                Console.WriteLine("2) Add outcome");
                Console.WriteLine("3) Show summary");
                Console.WriteLine("4) Exit");
                Console.Write("Choice: ");
            }

            // Read Numbers

            static decimal ReadAmount(string prompt)
            {
                while(true)
                {
                    Console.WriteLine(prompt);
                    string? input = Console.ReadLine();

                    if (decimal.TryParse(input, out decimal amount) && amount > 0)
                        return amount;
                    Console.WriteLine("Please enter a positive number");

                }
            }


            

            Console.Read();





        }
    }
}
