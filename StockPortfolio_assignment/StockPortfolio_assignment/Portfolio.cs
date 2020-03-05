using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockPortfolio_assignment;

namespace StockPortfolio_assignment
{
    class Portfolio : Subject<Portfolio>, IObserver<Stock>
    {
        private readonly  List<PortFolioEntry> stockList = new List<PortFolioEntry>();

        public void Add(Stock stock, int amount)
        {
            stockList.Add(new PortFolioEntry() {amount = amount, stock = stock});
            stock.Attach(this);
            NotifyPortfolioChanged();
        }

        public void Update(Stock subject)
        {
            NotifyPortfolioChanged();
        }

        void NotifyPortfolioChanged()
        {
            foreach (IObserver<Portfolio> observer in observers)
            {
                observer.Update(this);
            }
        }

        public int GetTotalStockValue()
        {
            int totalValue = 0;
            foreach (PortFolioEntry entry in stockList)
            {
                int stockValue = entry.amount * entry.stock.Value;
                totalValue += stockValue;
            }
            return totalValue;
        }

        public IReadOnlyCollection<PortFolioEntry> GetPortFolioEntries()
        {
            return stockList.AsReadOnly();
        }
    }
}
