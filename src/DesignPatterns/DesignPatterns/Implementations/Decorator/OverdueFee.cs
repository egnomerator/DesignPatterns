namespace DesignPatterns.Implementations.Decorator
{
    public class OverdueFee : StackableOverrideDecorator
    {
        private readonly decimal _overdueFee = 0.03m;
        public OverdueFee(IInvoice invoice) : base(invoice)
        {
        }

        protected override decimal ApplyOverride()
        {
            var currentBalance = _invoice.GetBalanceDue();
            return currentBalance + currentBalance * _overdueFee;
        }
    }
}
