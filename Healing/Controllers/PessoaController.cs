using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Healing.Database;
using Healing.Models;
using Healing.Repositories;
using System.Linq;

namespace Healing.Controllers
{
    public class PessoaController : ControllerAbs<Pessoa>, IController<Pessoa>
    {
        private readonly PessoaRepository repository;
        public PessoaController()
        {
            this.Repositorio = repository;
        }
        public List<Pessoa> GetAll()
        {
            List<Pessoa> listaRegistros = new List<Pessoa>();
            return listaRegistros = repository.Select(new List<string>());
        }

        public Pessoa GetById(int id)
        {
            List<string> param = new List<string>();
            param.Add($"id = '{id}'");

            return repository.Select(param).FirstOrDefault();
        }
    }
}
