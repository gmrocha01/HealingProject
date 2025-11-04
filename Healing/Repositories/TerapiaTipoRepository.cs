using Healing.DBConnection;
using Healing.Models;
using Healing.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Healing.Repositories
{
    public class TerapiaTipoRepository : RepositoryAbs<TerapiaTipo>, IRepository<TerapiaTipo>
    {
        private Connection _db;

        public TerapiaTipoRepository()
        {
            _db = new Connection();
        }

        protected override List<TerapiaTipo> _Select(List<string> parametros = null, int limit = 0, string orderBy = "", string groupBy = "")
        {
            List<TerapiaTipo> listaObjeto = new List<TerapiaTipo>();

            if (parametros == null)
            {
                parametros = new List<string>();
            }

            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT * FROM terapias_tipo ");

            if (parametros.Count > 0)
            {
                StringBuilder qParametros = new StringBuilder();
                qParametros.AppendLine("WHERE ");

                foreach (string parametro in parametros)
                {
                    string parm = parametro;
                    qParametros.AppendLine(parm + " AND ");
                }

                query.AppendLine(qParametros.ToString().Substring(0, qParametros.Length - 6));
            }
            //query.AppendLine("WHERE " + string.Join(" AND ", parametros));

            if (!string.IsNullOrEmpty(groupBy))
                query.AppendLine("GROUP BY " + groupBy);

            query.AppendLine("ORDER BY " + (string.IsNullOrEmpty(orderBy) ? "id" : orderBy));

            if (limit > 0)
                query.AppendLine("LIMIT " + limit);

            DataTable dt = _db.Select(query.ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TerapiaTipo registro = new TerapiaTipo();
                registro.Id = dt.Rows[i]["id"].ToString();
                registro.Descricao = dt.Rows[i]["descricao"].ToString();
                registro.Valor = dt.Rows[i]["valor"].ToString().GetDecimal();
                listaObjeto.Add(registro);
            }

            return listaObjeto;
        }

        public TerapiaTipo Select(string id)
        {
            List<string> parametros = new List<string>();
            parametros.Add("id = '" + id + "'");
            return this._Select(parametros, 1).FirstOrDefault();
        }

        public List<TerapiaTipo> Select(List<string> parametros)
        {
            return this._Select(parametros);
        }

        public List<TerapiaTipo> Select(List<string> parametros, int Limit)
        {
            return this._Select(parametros, Limit);
        }

        public List<TerapiaTipo> Select(List<string> parametros, string OrderBy, bool Order, int Limit = 0)
        {
            return this._Select(parametros, Limit, OrderBy);
        }

        public List<TerapiaTipo> Select(List<string> parametros, string GroupBy, int Limit = 0, string OrderBy = "")
        {
            return this._Select(parametros, Limit, OrderBy, GroupBy);
        }

        public List<TerapiaTipo> SelectLoadAll(List<Type> Carregar, List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "")
        {
            throw new NotImplementedException();
        }

        protected override int Insert(TerapiaTipo obj)
        {
            obj.Id = Guid.NewGuid().ToString();

            StringBuilder query = new StringBuilder();
            query.AppendLine("INSERT INTO terapias_tipo(")
            .AppendLine("id , ")
            .AppendLine("descricao , ")
            .AppendLine("valor  ) VALUES(").AppendLine(" '" + obj.Id + "' ,  ")
            .AppendLine(" '" + obj.Descricao + "' ,  ")
            .AppendLine(" '" + obj.Valor.GetStringDB() + "' )");

            return _db.Execute(query.ToString());
        }

        protected override int Update(TerapiaTipo obj)
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("UPDATE terapias_tipo ")
            .AppendLine("SET ")
            .AppendLine("id = '" + obj.Id + "', ")
            .AppendLine("descricao = '" + obj.Descricao + "', ")
            .AppendLine("valor = '" + obj.Valor.GetStringDB() + "'")
            .AppendLine(" WHERE id = '" + obj.Id + "'");

            return _db.Execute(query.ToString());
        }

        public int Delete(TerapiaTipo obj)
        {
            string query = $"DELETE FROM terapias_tipo WHERE id = {obj.Id}";
            return _db.Execute(query);
        }

        public int Save(TerapiaTipo obj)
        {
            try
            {
                object o = (object)obj;
                PrepararDadosPBanco.Preparar(typeof(TerapiaTipo), ref o);

                if (string.IsNullOrEmpty(obj.Id.ToString()))
                {
                    return this.Insert(obj);
                }
                else
                {
                    return this.Update(obj);
                }
            }
            catch (Exception)
            {
                throw new Exception("Problemas ao preparar o registro para salvar!");
            }            
        }

        public int Count(List<string> parametros)
        {
            throw new NotImplementedException();
        }

        public int Query(string query)
        {
            return _db.Execute(query.ToString());
        }

        public int ExecuteQuery(string query)
        {
            return _db.Execute(query.ToString());
        }

        public int IniciarTransaction()
        {
            throw new NotImplementedException();
        }

        public int ComitTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
