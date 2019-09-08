namespace DesignPatterns.Implementations.Decorator
{
    public class DollarDiscount : StackableOverrideDecorator
    {
        private readonly decimal _dollarDiscount;

        public DollarDiscount(IInvoice invoice, decimal dollarDiscount) : base(invoice)
        {
            _dollarDiscount = dollarDiscount;
        }

        protected override decimal ApplyOverride()
        {
            var currentBalance = _invoice.GetBalanceDue();
            return currentBalance - _dollarDiscount;
        }
    }
}
