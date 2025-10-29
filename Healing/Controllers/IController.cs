using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healing.Controllers
{
    interface IController<TEntity> : IDisposable where TEntity : class
    {
        TEntity Select(string id);
        List<TEntity> Select(List<string> parametros);
        List<TEntity> Select(List<string> parametros, int Limit);
        List<TEntity> Select(List<string> parametros, string OrderBy, bool Order, int Limit = 0);
        List<TEntity> Select(List<string> parametros, string GroupBy, int Limit = 0, string OrderBy = "");
        int Save(TEntity obj);
        int Delete(TEntity obj);
        int Count(List<string> parametros);
    }
}
