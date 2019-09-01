namespace DesignPatterns.Implementations.ChainOfResponsibility
{
    public interface IExpenseApprover
    {
        Decision Approve(ExpenseReport expenseReport);
    }

    public enum Decision
    {
        Escalated,
        Approved,
        Denied
    }
}
