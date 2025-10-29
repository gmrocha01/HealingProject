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
    public class UsuarioRepository : RepositoryAbs<Usuario>, IRepository<Usuario>
    {
        private readonly Connection _db;

        public UsuarioRepository(Connection db)
        {
            _db = db;
        }

        protected override List<Usuario> _Select(List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "")
        {
            List<Usuario> listaRegistros = new List<Usuario>();

            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM usuarios");

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
                    Usuario registro = new Usuario();
                    registro.Id = dt.Rows[i]["id"].ToString().GetInteiro();
                    registro.Nome = dt.Rows[i]["nome"].ToString();
                    registro.UsuarioLogin = dt.Rows[i]["usuario"].ToString();
                    registro.Senha = dt.Rows[i]["senha"].ToString();
                    listaRegistros.Add(registro);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listaRegistros;
        }
        public Usuario Select(string id)
        {
            List<string> parametros = new List<string>();
            parametros.Add("id = '" + id + "'");
            return this.Select(parametros, 1).FirstOrDefault();
        }

        public List<Usuario> Select(List<string> parametros)
        {
            return this._Select(parametros);
        }

        public List<Usuario> Select(List<string> parametros, int Limit)
        {
            return this._Select(parametros, Limit);
        }

        public List<Usuario> Select(List<string> parametros, string OrderBy, bool Order, int Limit = 0)
        {
            return this._Select(parametros, Limit, OrderBy);
        }

        public List<Usuario> Select(List<string> parametros, string GroupBy, int Limit = 0, string OrderBy = "")
        {
            return this._Select(parametros, Limit, OrderBy, GroupBy);
        }

        public List<Usuario> SelectLoadAll(List<Type> Carregar, List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "")
        {
            throw new NotImplementedException();
        }

        public int Save(Usuario obj)
        {
            try
            {
                object o = (object)obj;
                Tools.PrepararDadosPBanco.Preparar(typeof(Usuario), ref o);
            }
            catch (Exception)
            {
                throw new Exception("Problemas ao preparar o registro para salvar!");
            }

            if (string.IsNullOrEmpty(obj.Id.ToString()))
            {
                return this.Insert(obj);
            }
            else
            {
                return this.Update(obj);
            }
        }
        protected override int Insert(Usuario obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("INSERT INTO usuarios(")
                .AppendLine("id , ")
                .AppendLine("nome , ")
                .AppendLine("usuario , ")
                .AppendLine("senha  ) VALUES(").AppendLine()
                .AppendLine(" '" + obj.Nome + "' ,  ")
                .AppendLine(" '" + obj.UsuarioLogin + "' ,  ")
                .AppendLine(" '" + obj.Senha + "' )");

                return _db.Execute(query.ToString());

                //return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        protected override int Update(Usuario obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("UPDATE usuarios ")
                .AppendLine("SET ")
                .AppendLine("id = '" + obj.Id + "', ")
                .AppendLine("nome = '" + obj.Nome + "', ")
                .AppendLine("usuario = '" + obj.UsuarioLogin + "', ")
                .AppendLine("senha = '" + obj.Senha + "'")
                .AppendLine(" WHERE id = '" + obj.Id + "'");

                return _db.Execute(query.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public int Delete(Usuario obj)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("DELETE FROM usuarios WHERE id='" + obj.Id + "'");

                return this._db.Execute(query.ToString());
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
