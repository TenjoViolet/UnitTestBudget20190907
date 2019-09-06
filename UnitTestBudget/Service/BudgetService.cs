using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestBudget.Entity;
using UnitTestBudget.Repository;

namespace UnitTestBudget.Service
{
    public class BudgetService
    {
        IBudgetRepos _budgetRepos;

        public BudgetService (IBudgetRepos budgetRepos)
        {
            _budgetRepos = budgetRepos;
        }

        public Decimal TotalAmount(string strStartDate, string strEndDate)
        {
            Decimal decRet = 0;
            Int32 intDayCount = 0;
            List<Budget> ltBudget = _budgetRepos.GetAll(strStartDate, strEndDate);

            
            return decRet;
        }
    }
}
