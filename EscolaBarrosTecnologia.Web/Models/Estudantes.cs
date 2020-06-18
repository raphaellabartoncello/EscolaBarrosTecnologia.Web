using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscolaBarrosTecnologia.Web.Models
{
    public class Estudantes
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataMatricula { get; set; }
    }
}