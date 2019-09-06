using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestBudget.Service;

namespace UnitTestBudget.Factory
{
    public class ServiceFactory
    {
        public static BudgetService GetBudgetService()
        {
            return new BudgetService(RepositoryFactory.GetBudgetRepos());
        }
    }
}
