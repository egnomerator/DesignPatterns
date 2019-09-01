using DesignPatterns.Implementations.ChainOfResponsibility;
using System;

namespace DesignPatterns.Demos
{
    public class ChainOfResponsibility
    {
        public static void Run()
        {
            var head = new ExpenseHandler(new Employee("1st Level Manager", 1000))
                .SetNext(new ExpenseHandler(new Employee("2nd Level Manager", 10000)))
                .SetNext(new ExpenseHandler(new Employee("3nd Level Manager", 100000)))
                .SetNext(new ExpenseHandler(new Employee("C Level Manager", 1000000)));

            var smallCost = 500;
            var largeCost = 95000;
            var hugeCost = 950000;
            var massiveCost = 1500000;

            var smallExpense = new ExpenseReport(smallCost, worthIt: true);
            var largeExpense = new ExpenseReport(largeCost, worthIt: false);
            var hugeExpense = new ExpenseReport(hugeCost, worthIt: true);
            var massiveExpense = new ExpenseReport(massiveCost, worthIt: true);

            Console.WriteLine($"{smallCost:C} expense: {head.Approve(smallExpense)}");
            Console.WriteLine($"{largeCost:C} expense: {head.Approve(largeExpense)}");
            Console.WriteLine($"{hugeCost:C} expense: {head.Approve(hugeExpense)}");
            Console.WriteLine($"{massiveCost:C} expense: {head.Approve(massiveExpense)}");
        }
    }
}
