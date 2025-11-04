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
    public class TerapiaConsultaRepository : RepositoryAbs<TerapiaConsulta>, IRepository<TerapiaConsulta>
    {
        private Connection _db;

        public TerapiaConsultaRepository()
        {
            _db = new Connection();
        }

        protected override List<TerapiaConsulta> _Select(List<string> parametros = null, int limit = 0, string orderBy = "", string groupBy = "")
        {
            List<TerapiaConsulta> listaObjeto = new List<TerapiaConsulta>();

            if (parametros == null)
            {
                parametros = new List<string>();
            }

            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT * FROM terapias_consultas ");

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
                TerapiaConsulta registro = new TerapiaConsulta();
                registro.Id = dt.Rows[i]["id"].ToString().GetInteiro();
                registro.IdPessoa = dt.Rows[i]["id_pessoa"].ToString().GetInteiro();
                registro.DataAbertura = dt.Rows[i]["data_abertura"].ToString().GetData();
                registro.DataConsulta = dt.Rows[i]["data_consulta"].ToString().GetData();
                registro.TipoTerapia = dt.Rows[i]["tipo_terapia"].ToString();
                registro.Observacoes = dt.Rows[i]["observacoes"].ToString(); 
                registro.Status = dt.Rows[i]["status"].ToString();
                registro.PessoaNome = dt.Rows[i]["pessoa_nome"].ToString();
                registro.PessoaTelefone = dt.Rows[i]["pessoa_telefone"].ToString();
                registro.PessoaEmail = dt.Rows[i]["pessoa_email"].ToString();
                registro.PessoaIdade = dt.Rows[i]["pessoa_idade"].ToString();
                registro.PessoaCpfCnpj = dt.Rows[i]["pessoa_cpf_cnpj"].ToString();
                registro.TerapiaValor = dt.Rows[i]["terapia_valor"].ToString().GetDecimal();
                registro.TerapiaValorDesconto = dt.Rows[i]["terapia_valor_desconto"].ToString().GetDecimal();
                registro.TerapiaValorTotal = dt.Rows[i]["terapia_valor_total"].ToString().GetDecimal();
                registro.UsuarioResponsavel = dt.Rows[i]["usuario_responsavel"].ToString();
                registro.Pago = dt.Rows[i]["pago"].ToString();
                listaObjeto.Add(registro);
            }

            return listaObjeto;
        }

        public TerapiaConsulta Select(string id)
        {
            List<string> parametros = new List<string>();
            parametros.Add("id = '" + id + "'");
            return this._Select(parametros, 1).FirstOrDefault();
        }

        public List<TerapiaConsulta> Select(List<string> parametros)
        {
            return this._Select(parametros);
        }

        public List<TerapiaConsulta> Select(List<string> parametros, int Limit)
        {
            return this._Select(parametros, Limit);
        }

        public List<TerapiaConsulta> Select(List<string> parametros, string OrderBy, bool Order, int Limit = 0)
        {
            return this._Select(parametros, Limit, OrderBy);
        }

        public List<TerapiaConsulta> Select(List<string> parametros, string GroupBy, int Limit = 0, string OrderBy = "")
        {
            return this._Select(parametros, Limit, OrderBy, GroupBy);
        }

        public List<TerapiaConsulta> SelectLoadAll(List<Type> Carregar, List<string> Parametros, int Limit = 0, string OrderBy = "", string GroupBy = "")
        {
            throw new NotImplementedException();
        }

        protected override int Insert(TerapiaConsulta obj)
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("INSERT INTO terapias_consultas(")
            .AppendLine("id_pessoa , ")
            .AppendLine("data_abertura , ")
            .AppendLine("data_consulta , ")
            .AppendLine("tipo_terapia , ")
            .AppendLine("observacoes, ")
            .AppendLine("status , ")
            .AppendLine("pessoa_nome , ")
            .AppendLine("pessoa_telefone , ")
            .AppendLine("pessoa_email , ")
            .AppendLine("pessoa_idade , ")
            .AppendLine("pessoa_cpf_cnpj , ")
            .AppendLine("terapia_valor , ")
            .AppendLine("terapia_valor_desconto , ")
            .AppendLine("terapia_valor_total , ")
            .AppendLine("usuario_responsavel , ")
            .AppendLine("pago ) VALUES(")
            .AppendLine(" '" + obj.IdPessoa + "' ,  ")
            .AppendLine(" '" + obj.DataAbertura.GetFormatDateTime() + "' ,  ")
            .AppendLine(" '" + obj.DataConsulta.GetFormatDateTime() + "' ,  ")
            .AppendLine(" '" + obj.TipoTerapia + "' ,  ")
            .AppendLine(" '" + obj.Observacoes + "' ,  ")
            .AppendLine(" '" + obj.Status + "' ,  ")
            .AppendLine(" '" + obj.PessoaNome + "' ,  ")
            .AppendLine(" '" + obj.PessoaTelefone + "' ,  ")
            .AppendLine(" '" + obj.PessoaEmail + "' ,  ")
            .AppendLine(" '" + obj.PessoaIdade + "' ,  ")
            .AppendLine(" '" + obj.PessoaCpfCnpj + "' ,  ")
            .AppendLine(" '" + obj.TerapiaValor.GetStringDB() + "' ,  ")
            .AppendLine(" '" + obj.TerapiaValorDesconto.GetStringDB() + "' ,  ")
            .AppendLine(" '" + obj.TerapiaValorTotal.GetStringDB() + "' ,  ")
            .AppendLine(" '" + obj.UsuarioResponsavel + "' ,  ")
            .AppendLine(" '" + obj.Pago + "' )");

            return _db.Execute(query.ToString());
        }

        protected override int Update(TerapiaConsulta obj)
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("UPDATE terapias_consultas ")
            .AppendLine("SET ")
            .AppendLine("id_pessoa = '" + obj.IdPessoa + "', ")
            .AppendLine("data_abertura = '" + obj.DataAbertura.GetFormatDateTime() + "', ")
            .AppendLine("data_consulta = '" + obj.DataConsulta.GetFormatDateTime() + "', ")
            .AppendLine("tipo_terapia = '" + obj.TipoTerapia + "', ")
            .AppendLine("observacoes = '" + obj.Observacoes + "', ")
            .AppendLine("status = '" + obj.Status + "', ")
            .AppendLine("pessoa_nome = '" + obj.PessoaNome + "', ")
            .AppendLine("pessoa_telefone = '" + obj.PessoaTelefone + "', ")
            .AppendLine("pessoa_email = '" + obj.PessoaEmail + "', ")
            .AppendLine("pessoa_idade = '" + obj.PessoaIdade + "', ")
            .AppendLine("pessoa_cpf_cnpj = '" + obj.PessoaCpfCnpj + "', ")
            .AppendLine("terapia_valor = '" + obj.TerapiaValor.GetStringDB() + "', ")
            .AppendLine("terapia_valor_desconto = '" + obj.TerapiaValorDesconto.GetStringDB() + "', ")
            .AppendLine("terapia_valor_total = '" + obj.TerapiaValorTotal.GetStringDB() + "', ")
            .AppendLine("usuario_responsavel = '" + obj.UsuarioResponsavel + "', ")
            .AppendLine("pago = '" + obj.Pago + "'")
            .AppendLine(" WHERE id = '" + obj.Id + "'");

            return _db.Execute(query.ToString());
        }

        public int Delete(TerapiaConsulta obj)
        {
            string query = $"DELETE FROM terapias_consultas WHERE id = {obj.Id}";
            return _db.Execute(query);
        }

        public int Save(TerapiaConsulta obj)
        {
            try
            {
                object o = (object)obj;
                PrepararDadosPBanco.Preparar(typeof(TerapiaConsulta), ref o);

                if (string.IsNullOrEmpty(obj.Id.ToString()) || obj.Id.ToString() == "0")
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
