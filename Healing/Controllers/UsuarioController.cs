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
    public class UsuarioController : ControllerAbs<Usuario>, IController<Usuario>
    {
        private UsuarioRepository repository;
        public UsuarioController()
        {
            this.repository = new UsuarioRepository();
            this.Repositorio = repository;
        }

        public Usuario Authenticate(string usuarioLogin, string senha)
        {
            try
            {
                List<string> param = new List<string>();
                param.Add($"usuario = '{usuarioLogin}'");
                param.Add($"senha = '{senha}'");

                var usuarios = repository.Select(param);

                if (usuarios.Count == 0)
                    return null;

                var usuario = usuarios.FirstOrDefault();
                return usuario;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
