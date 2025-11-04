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
    public class PessoaRepository : RepositoryAbs<Pessoa>, IRepository<Pessoa>
    {
        private Connection _db;

        public PessoaRepository()
        {
            _db = new Connection();
        }

        protected override List<Pessoa> _Select(List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "")
        {
            List<Pessoa> listaRegistros = new List<Pessoa>();

            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM pessoas");

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
                    Pessoa registro = new Pessoa();
                    registro.Id = dt.Rows[i]["id"].ToString().GetInteiro();
                    registro.Nome = dt.Rows[i]["nome"].ToString();
                    registro.Telefone = dt.Rows[i]["telefone"].ToString();
                    registro.Email = dt.Rows[i]["email"].ToString();
                    registro.DataNascimento = dt.Rows[i]["data_nascimento"].ToString().GetData();
                    //registro.Observacoes = dt.Rows[i]["observacoes"].ToString();
                    listaRegistros.Add(registro);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaRegistros;
        }
        public Pessoa Select(string id)
        {
            List<string> parametros = new List<string>();
            parametros.Add("id = '" + id + "'");
            return this.Select(parametros, 1).FirstOrDefault();
        }

        public List<Pessoa> Select(List<string> parametros)
        {
            return this._Select(parametros);
        }

        public List<Pessoa> Select(List<string> parametros, int Limit)
        {
            return this._Select(parametros, Limit);
        }

        public List<Pessoa> Select(List<string> parametros, string OrderBy, bool Order, int Limit = 0)
        {
            return this._Select(parametros, Limit, OrderBy);
        }

        public List<Pessoa> Select(List<string> parametros, string GroupBy, int Limit = 0, string OrderBy = "")
        {
            return this._Select(parametros, Limit, OrderBy, GroupBy);
        }

        public List<Pessoa> SelectLoadAll(List<Type> Carregar, List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "")
        {
            throw new NotImplementedException();
        }

        public int Save(Pessoa obj)
        {
            try
            {
                object o = (object)obj;
                Tools.PrepararDadosPBanco.Preparar(typeof(Pessoa), ref o);
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
        protected override int Insert(Pessoa obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("INSERT INTO pessoas(")
                .AppendLine("nome , ")
                .AppendLine("telefone , ")
                .AppendLine("email , ")
                .AppendLine("data_nascimento , ")
                .AppendLine("observacoes  ) VALUES(").AppendLine(" '" + obj.Id + "' ,  ")
                .AppendLine(" '" + obj.Nome + "' ,  ")
                .AppendLine(" '" + obj.Telefone + "' ,  ")
                .AppendLine(" '" + obj.Email + "' ,  ")
                .AppendLine(" '" + obj.DataNascimento.GetFormatDate() + "' ,  ")
                .AppendLine(" '" + obj.Observacoes + "' )");

                return _db.Execute(query.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        protected override int Update(Pessoa obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("UPDATE pessoas ")
                .AppendLine("SET ")
                .AppendLine("nome = '" + obj.Nome + "', ")
                .AppendLine("telefone = '" + obj.Telefone + "', ")
                .AppendLine("email = '" + obj.Email + "', ")
                .AppendLine("data_nascimento = '" + obj.DataNascimento.GetFormatDate() + "', ")
                .AppendLine("observacoes = '" + obj.Observacoes + "'")
                .AppendLine(" WHERE id = '" + obj.Id + "'");

                return _db.Execute(query.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public int Delete(Pessoa obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("DELETE FROM pessoas WHERE id='" + obj.Id + "'");

                return _db.Execute(query.ToString());
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

        public bool IniciarTransaction()
        {
            throw new NotImplementedException();
        }

        public bool ComitTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
