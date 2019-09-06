using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestBudget.Repository;

namespace UnitTestBudget.Factory
{
    public class RepositoryFactory
    {
        public static IBudgetRepos GetBudgetRepos()
        {
            return new BudgetRepos();
        }
    }
}
