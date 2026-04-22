using FinanceTrace_v0._2;
using System.Text;

namespace FinanceTrace
{
    internal class Program
    {
        // Sabitler — programın sabit değerleri
        const string AppName = "FinanceTrace";
        const string Version = "0.2";
        const decimal MaxAmount = 1_000_000m;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // TEST

            //var test = new Transaction(500, "Maaş", "İş", TransactionType.Income);
            //Console.WriteLine($"Miktar: {test.Amount:C}");
            //Console.WriteLine($"Açıklama: {test.Description}");
            //Console.WriteLine($"Kategori: {test.Category}");
            //Console.WriteLine($"Tür: {test.Type}");
            //Console.WriteLine($"Date: {test.Date}");
            //return;

            // TEST END

            decimal totalIncome = 0;
            decimal totalOutcome = 0;

            Console.WriteLine($"=== {AppName} v{Version} ===");
            Console.Write("What's your name? ");
            string? name = Console.ReadLine();

            bool running = true;
            while (running)
            {
                ShowMenu();
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        totalIncome += ReadAmount("Income amount: ");
                        Console.WriteLine($"Income added. Total: {totalIncome:C}");
                        break;

                    case "2":
                        totalOutcome += ReadAmount("Outcome amount: ");
                        Console.WriteLine($" Outcome added. Total: {totalOutcome:C}");
                        break;

                    case "3":
                        ShowSummary(name, totalIncome, totalOutcome);
                        break;

                    case "4":
                        if(Confirm("Are you sure you want to reset?"))
                        {
                            totalIncome = 0;
                            totalOutcome = 0;
                            Console.WriteLine("Reset done.");
                        }
                        else
                        {
                            Console.WriteLine("Reset cancelled");
                        }
                      
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine(" Invalid choice. Pick 1-5.");
                        break;
                }
                Console.WriteLine();
            }
        }

        // Menüyü ekrana bastıran metot
        static void ShowMenu()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("1) Add income");
            Console.WriteLine("2) Add outcome");
            Console.WriteLine("3) Show summary");
            Console.WriteLine("4) Reset All");
            Console.WriteLine("5) Exit");
            Console.Write("Choice: ");
        }

        // Güvenli sayı okuma — geçerli sayı alana kadar sormaya devam eder
        static decimal ReadAmount(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal amount) && amount > 0 && amount <= MaxAmount)
                {
                    return amount;
                }
                 
                Console.WriteLine($"  Please enter a positive number (e.g. 1500.50) and {MaxAmount:N0} .");
            }
        }

       // Soru Soran Method

        static bool Confirm(string question)
        {
            Console.Write($"{question} (y/n): ");
            string? answer = Console.ReadLine();
            return answer?.ToLower() == "y";
        }

       


        // Özet raporu basan metot
        static void ShowSummary(string? name, decimal income, decimal outcome)
        {
            decimal balance = income - outcome;

            Console.WriteLine();
            Console.WriteLine("===== SUMMARY =====");
            Console.WriteLine($"User:    {name}");
            Console.WriteLine($"Income:  {income:C}");
            Console.WriteLine($"Outcome: {outcome:C}");
            Console.WriteLine($"Balance: {balance:C}");

            // Modern switch expression kullanımı
            string status = balance switch
            {
                > 0 => "👍 You're saving money, great!",
                0 => "😐 Break-even.",
                _ => "⚠️  You're in deficit, be careful."
            };

            Console.WriteLine(status);
            Console.WriteLine("===================");
        }
    }
}