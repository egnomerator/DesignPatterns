namespace DesignPatterns.Implementations.Decorator
{
    public class Cap : StackableOverrideDecorator
    {
        private readonly decimal _cap;
        public Cap(IInvoice invoice, decimal cap) : base(invoice)
        {
            _cap = cap;
        }

        protected override decimal ApplyOverride()
        {
            var currentBalance = _invoice.GetBalanceDue();
            return currentBalance > _cap ? _cap : currentBalance;
        }
    }
}
