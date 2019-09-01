namespace DesignPatterns.Implementations.ChainOfResponsibility
{
    public class ExpenseReport
    {
        public int Cost { get; }
        public bool WorthIt { get; }
        public ExpenseReport(int cost, bool worthIt)
        {
            Cost = cost;
            WorthIt = worthIt;
        }
    }
}
