namespace DesignPatterns.Implementations.ChainOfResponsibility
{
    public class Employee : IExpenseApprover
    {
        public string Name { get; }
        public int Limit { get; }

        public Employee(string name, int limit)
        {
            Name = name;
            Limit = limit;
        }

        public Decision Approve(ExpenseReport expenseReport)
        {
            if (expenseReport.Cost > Limit) return Decision.Escalated;
            return expenseReport.WorthIt ? Decision.Approved : Decision.Denied;
        }
    }
}
