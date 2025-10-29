using System;
using MySql.Data.MySqlClient;
using Healing.Database;
using Healing.Models;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Healing.Repositories;
using System.Linq;
using Healing.Tools;

namespace Healing.Controllers
{
    public class TerapiaConsultaObservacoesController : ControllerAbs<TerapiaConsultaObservacoes>, IController<TerapiaConsultaObservacoes>
    {
        private readonly TerapiaConsultaObservacoesRepositorio repository;
        public TerapiaConsultaObservacoesController()
        {
            this.Repositorio = repository;
        }

        public List<TerapiaConsultaObservacoes> GetAllByTerapiaConsultaId(int id)
        {
            //Teste
            List<string> param = new List<string>();
            param.Add($"terapias_consultas_id = '{id}'");

            return repository.Select(param);            
        }
    }
}
