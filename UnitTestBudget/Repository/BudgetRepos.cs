using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestBudget.Entity;

namespace UnitTestBudget.Repository
{
    public class BudgetRepos:IBudgetRepos
    {
        public List<Budget> GetAll(string strStartDate, string strEndDate)
        {
            //假裝是資料庫撈資料
            List<Budget> ltBudget = new List<Budget>
            {
                new Budget{ YearMonth="2019/09", Amount=100},
                new Budget{ YearMonth="2019/10", Amount=1},
            };

            return ltBudget;
        }
    }
}
