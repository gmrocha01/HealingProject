﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healing.Models
{
    public class TerapiaConsultaObservacoes
    {
        public int Id { get; set; }
        public int TerapiaConsultaId { get; set; }
        public string Descricao { get; set; }

        public TerapiaConsultaObservacoes()
        {

        }
    }
}
