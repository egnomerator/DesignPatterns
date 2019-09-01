namespace DesignPatterns.Implementations.ChainOfResponsibility
{
    public interface IExpenseHandler
    {
        Decision Approve(ExpenseReport expenseReport);
        IExpenseHandler SetNext(IExpenseHandler expenseApprover);
    }
}
