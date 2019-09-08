using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Implementations.Decorator
{
    public class Invoice : IInvoice
    {
        private readonly List<decimal> _costs;

        public Invoice(List<decimal> costs)
        {
            _costs = costs ?? new List<decimal>();
        }

        public decimal GetBalanceDue()
        {
            return _costs.Sum();
        }
    }
}
