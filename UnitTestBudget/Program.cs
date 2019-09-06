using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestBudget.Factory;
using UnitTestBudget.Service;

namespace UnitTestBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            BudgetService bs = ServiceFactory.GetBudgetService();
            Decimal decAmt = bs.TotalAmount();
            //Console.ReadKey();
            Console.WriteLine(decAmt);
        }
    }
}
