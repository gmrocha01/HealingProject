using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Healing.Database;
using Healing.Models;
using Healing.Repositories;
using System.Linq;

namespace Healing.Controllers
{
    public class TerapiaTipoController : ControllerAbs<TerapiaTipo>, IController<TerapiaTipo>
    {
        private TerapiaTipoRepository repository;

        public TerapiaTipoController()
        {
            this.repository = new TerapiaTipoRepository();
            this.Repositorio = repository;
        }
        public List<TerapiaTipo> GetAll()
        { 
            List<TerapiaTipo> listaRegistros = new List<TerapiaTipo>();
            return listaRegistros = repository.Select(new List<string>());
        }

        public TerapiaTipo GetById(int id)
        {
            List<string> param = new List<string>();
            param.Add($"id = '{id}'");

            return repository.Select(param).FirstOrDefault();
        }
    }
}
