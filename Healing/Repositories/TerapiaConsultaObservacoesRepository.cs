using Healing.Controllers;
using Healing.DBConnection;
using Healing.Models;
using Healing.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healing.Repositories
{
    public class TerapiaConsultaObservacoesRepositorio : RepositoryAbs<TerapiaConsultaObservacoes>, IRepository<TerapiaConsultaObservacoes>
    {
        private Connection _db;

        public TerapiaConsultaObservacoesRepositorio()
        {
            _db = new Connection();
        }

        protected override List<TerapiaConsultaObservacoes> _Select(List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "")
        {
            List<TerapiaConsultaObservacoes> listaRegistros = new List<TerapiaConsultaObservacoes>();

            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM terapias_consultas_observacoes");

                if (Parametros.Count > 0)
                {
                    StringBuilder qParametros = new StringBuilder();
                    qParametros.AppendLine("WHERE ");

                    foreach (string parametro in Parametros)
                    {
                        string parm = parametro;
                        qParametros.AppendLine(parm + " AND ");
                    }

                    query.AppendLine(qParametros.ToString().Substring(0, qParametros.Length - 6));
                }

                if (GroupBy != string.Empty)
                {
                    query.AppendLine("GROUP BY " + GroupBy);
                }

                if (OrderBy == string.Empty)
                {
                    query.AppendLine("ORDER BY id");
                }
                else
                {
                    query.AppendLine("ORDER BY " + OrderBy);
                }

                if (Limit > 0)
                {
                    query.AppendLine("LIMIT " + Limit);
                }

                DataTable dt = _db.Select(query.ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TerapiaConsultaObservacoes registro = new TerapiaConsultaObservacoes();
                    registro.Id = dt.Rows[i]["id"].ToString().GetInteiro();
                    registro.TerapiaConsultaId = dt.Rows[i]["terapias_consultas_id"].ToString().GetInteiro();
                    registro.Descricao = dt.Rows[i]["descricao"].ToString();
                    listaRegistros.Add(registro);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaRegistros;
        }
        public TerapiaConsultaObservacoes Select(string id)
        {
            List<string> parametros = new List<string>();
            parametros.Add("id = '" + id + "'");
            return this.Select(parametros, 1).FirstOrDefault();
        }

        public List<TerapiaConsultaObservacoes> Select(List<string> parametros)
        {
            return this.Select(parametros);
        }

        public List<TerapiaConsultaObservacoes> Select(List<string> parametros, int Limit)
        {
            return this.Select(parametros, Limit);
        }

        public List<TerapiaConsultaObservacoes> Select(List<string> parametros, string OrderBy, bool Order, int Limit = 0)
        {
            return this._Select(parametros, Limit, OrderBy);
        }

        public List<TerapiaConsultaObservacoes> Select(List<string> parametros, string GroupBy, int Limit = 0, string OrderBy = "")
        {
            return this._Select(parametros, Limit, OrderBy, GroupBy);
        }

        public List<TerapiaConsultaObservacoes> SelectLoadAll(List<Type> Carregar, List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "")
        {
            throw new NotImplementedException();
        }

        public int Save(TerapiaConsultaObservacoes obj)
        {
            try
            {
                object o = (object)obj;
                Tools.PrepararDadosPBanco.Preparar(typeof(TerapiaConsultaObservacoes), ref o);
            }
            catch (Exception)
            {
                throw new Exception("Problemas ao preparar o registro para salvar!");
            }

            if (string.IsNullOrEmpty(obj.Id.ToString()) || obj.Id.ToString() == "0")
            {
                return this.Insert(obj);
            }
            else
            {
                return this.Update(obj);
            }
        }
        protected override int Insert(TerapiaConsultaObservacoes obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("INSERT INTO terapias_consultas_observacoes(")
                .AppendLine("terapias_consultas_id , ")
                .AppendLine("descricao  ) VALUES(")
                .AppendLine(" '" + obj.TerapiaConsultaId + "' ,  ")
                .AppendLine(" '" + obj.Descricao + "' )");

                return _db.Execute(query.ToString());
                //return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        protected override int Update(TerapiaConsultaObservacoes obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("UPDATE terapias_consultas_observacoes ")
                .AppendLine("SET ")
                .AppendLine("id = '" + obj.Id + "', ")
                .AppendLine("terapias_consultas_id = '" + obj.TerapiaConsultaId + "', ")
                .AppendLine("descricao = '" + obj.Descricao + "'")
                .AppendLine(" WHERE id = '" + obj.Id + "'");

                return _db.Execute(query.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public int Delete(TerapiaConsultaObservacoes obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("DELETE FROM terapias_consultas_observacoes WHERE id='" + obj.Id + "'");

                return _db.Execute(query.ToString());

                //return true;
            }
            catch (Exception e)
            {
                throw e;
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

    }
}

