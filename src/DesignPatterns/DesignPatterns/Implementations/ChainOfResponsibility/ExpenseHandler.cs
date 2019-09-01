namespace DesignPatterns.Implementations.ChainOfResponsibility
{
    public class ExpenseHandler : IExpenseHandler
    {
        private IExpenseHandler _next;
        private readonly IExpenseApprover _expenseApprover;

        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            _expenseApprover = expenseApprover;
            _next = EscalationTerminatingExpenseHandler.Singleton;
        }

        public Decision Approve(ExpenseReport expenseReport)
        {
            var decision = _expenseApprover.Approve(expenseReport);

            return decision.Equals(Decision.Escalated) ? _next.Approve(expenseReport) : decision;

        }

        public IExpenseHandler SetNext(IExpenseHandler expenseHandler)
        {
            _next = expenseHandler;
            return _next;
        }
    }
}
