using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockPortfolio_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Portfolio portfolio = new Portfolio();
            PortfolioDisplay portfolioDisplay = new PortfolioDisplay();
            portfolio.Attach(portfolioDisplay);

            Stock google = new Stock(100, "Google");
            Stock vestas = new Stock(500, "Vestas");
            Stock DanskeBank = new Stock(1000, "Danske Bank");

            portfolio.Add(google,100);
            portfolio.Add(vestas,50);
            portfolio.Add(DanskeBank,2000);

            for (int i = 0; i < 10; i++)
            {
                google.UpdateValue();
                vestas.UpdateValue();
                DanskeBank.UpdateValue();
                Thread.Sleep(1000);
            }

            Console.WriteLine("\nPress return key to exit\n");
            Console.ReadLine();
        }
    }
}
