﻿using DesignPatterns.Implementations.Decorator;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Demos
{
    public class Decorator
    {
        public static void Run()
        {
            var costs = new List<decimal> { 5000, 2000, 30000, 50000, 15000 };
            var invoice = new Invoice(costs);

            DisplayOverrideResultInfo("Original Balance Due", invoice.GetBalanceDue());

            const int twoKDiscount = 2000;
            var dollarDiscount = new DollarDiscount(invoice, twoKDiscount);

            DisplayOverrideResultInfo("   After 2K Discount", dollarDiscount.GetBalanceDue());

            const decimal fivePercent = 0.05m;
            var percentageDiscount = new PercentageDiscount(dollarDiscount, fivePercent);

            DisplayOverrideResultInfo(" After 5 Percent Off", percentageDiscount.GetBalanceDue());

            const int ninetyKCap = 90000;
            var cap = new Cap(percentageDiscount, ninetyKCap);

            DisplayOverrideResultInfo("       After 90K Cap", cap.GetBalanceDue());

            var overdueFee = new OverdueFee(cap);

            DisplayOverrideResultInfo("   After Overdue Fee", overdueFee.GetBalanceDue());
        }

        private static void DisplayOverrideResultInfo(string message, decimal amount)
        {
            Console.WriteLine($"{message}: {amount:C}");
        }
    }
}
