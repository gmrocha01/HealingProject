using Healing.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healing.Controllers
{
    public abstract class ControllerAbs<TEntity> : BaseClass, IController<TEntity> where TEntity : class
    {
        bool disposed = false;

        protected IRepository<TEntity> Repositorio;

        // Protected implementation of Dispose pattern.
        protected override void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
                this.Repositorio.Dispose();
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~ControllerAbs()
        {
            Dispose(true);
        }

        public TEntity Select(string id)
        {
            try
            {
                return this.Repositorio.Select(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public List<TEntity> Select(List<string> parametros)
        {
            try
            {
                return this.Repositorio.Select(parametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public List<TEntity> Select(List<string> parametros, int Limit)
        {
            try
            {
                return this.Repositorio.Select(parametros, Limit);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public List<TEntity> Select(List<string> parametros, string OrderBy, bool Order, int Limit = 0)
        {
            try
            {
                return this.Repositorio.Select(parametros, OrderBy, Order, Limit);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public List<TEntity> Select(List<string> parametros, string GroupBy, int Limit = 0, string OrderBy = "")
        {
            try
            {
                return this.Repositorio.Select(parametros, GroupBy, Limit, OrderBy);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public virtual int Save(TEntity obj)
        {
            try
            {
                return this.Repositorio.Save(obj);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public virtual int Delete(TEntity obj)
        {
            try
            {
                return this.Repositorio.Delete(obj);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public int Count(List<string> parametros)
        {
            try
            {
                return this.Repositorio.Count(parametros);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }
    }
}
