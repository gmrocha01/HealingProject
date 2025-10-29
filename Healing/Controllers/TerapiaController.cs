using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Healing.Database;
using Healing.Models;
using Healing.Repositories;
using System.Linq;

namespace Healing.Controllers
{
    public class TerapiaController : ControllerAbs<TerapiaConsulta>, IController<TerapiaConsulta>
    {
        private readonly TerapiaConsultaRepository repository;
        public List<TerapiaConsulta> GetAll()
        { 
            List<TerapiaConsulta> listaRegistros = new List<TerapiaConsulta>();
            return listaRegistros = repository.Select(new List<string>());
        }

        public TerapiaConsulta GetById(int id)
        {
            List<string> param = new List<string>();
            param.Add($"id = '{id}'");

            return repository.Select(param).FirstOrDefault();
        }
    }
}
