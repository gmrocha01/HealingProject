using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healing.Repositories
{
    public abstract class RepositoryAbs<TEntity> : BaseClass where TEntity : class
    {
        protected abstract List<TEntity> _Select(List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "");
        protected abstract int Insert(TEntity obj);
        protected abstract int Update(TEntity obj);
    }
}
