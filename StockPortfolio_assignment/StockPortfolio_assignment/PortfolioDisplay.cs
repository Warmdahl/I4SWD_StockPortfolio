using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio_assignment
{
    class PortfolioDisplay : IObserver<Portfolio>
    {
        public void Update(Portfolio subject)
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Stock portfolio:");
            IReadOnlyCollection<PortFolioEntry> entries = subject.GetPortFolioEntries();

            foreach (PortFolioEntry entry in entries)
            {
                Console.WriteLine($"Stock: {entry.stock.Name} " +
                                  $"- amount: {entry.amount} " +
                                  $"- price: {entry.stock.Value} " +
                                  $"- held value: {entry.stock.Value * entry.amount}");
            }
            Console.WriteLine($"Total holdings: {subject.GetTotalStockValue()}");
        }
    }
}
