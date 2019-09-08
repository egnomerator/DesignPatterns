namespace DesignPatterns.Implementations.Decorator
{
    public abstract class StackableOverrideDecorator : IInvoice
    {
        protected readonly IInvoice _invoice;

        public StackableOverrideDecorator(IInvoice invoice)
        {
            _invoice = invoice;
        }

        protected abstract decimal ApplyOverride();

        public virtual decimal GetBalanceDue()
        {
            return ApplyOverride();
        }
    }
}
