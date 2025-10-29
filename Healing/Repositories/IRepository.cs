using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healing.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Select(string id);
        List<TEntity> Select(List<string> parametros);
        List<TEntity> Select(List<string> parametros, int Limit);
        List<TEntity> Select(List<string> parametros, string OrderBy, bool Order, int Limit = 0);
        List<TEntity> Select(List<string> parametros, string GroupBy, int Limit = 0, string OrderBy = "");
        List<TEntity> SelectLoadAll(List<Type> Carregar, List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "");
        int Save(TEntity obj);
        int Delete(TEntity obj);
        int Count(List<string> parametros);
        int Query(string query);
        int ExecuteQuery(string query);
        //bool IniciarTransaction();
        //bool ComitTransaction();
    }
}
