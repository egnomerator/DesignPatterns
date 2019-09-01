using System;

namespace DesignPatterns.Implementations.ChainOfResponsibility
{
    public class EscalationTerminatingExpenseHandler : IExpenseHandler
    {
        public static EscalationTerminatingExpenseHandler Singleton { get; } = new EscalationTerminatingExpenseHandler();

        private EscalationTerminatingExpenseHandler() { }

        public Decision Approve(ExpenseReport expenseReport)
        {
            return Decision.Denied;
        }

        public IExpenseHandler SetNext(IExpenseHandler expenseApprover)
        {
            throw new InvalidOperationException("Cannot set next on escalation terminating handler.");
        }
    }
}
