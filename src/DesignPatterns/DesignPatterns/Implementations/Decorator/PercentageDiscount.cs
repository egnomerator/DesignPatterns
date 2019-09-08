namespace DesignPatterns.Implementations.Decorator
{
    public class PercentageDiscount : StackableOverrideDecorator
    {
        private readonly decimal _percentageDiscount;
        public PercentageDiscount(IInvoice invoice, decimal percentageDiscount) : base(invoice)
        {
            _percentageDiscount = percentageDiscount;
        }

        protected override decimal ApplyOverride()
        {
            var currentBalance = _invoice.GetBalanceDue();
            return currentBalance - currentBalance * _percentageDiscount;
        }
    }
}
