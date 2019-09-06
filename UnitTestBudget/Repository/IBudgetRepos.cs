using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestBudget.Entity;

namespace UnitTestBudget.Repository
{
    public interface IBudgetRepos
    {
        List<Budget> GetAll(string strStartDate, string strEndDate);
    }
}
