using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscolaBarrosTecnologia.Web.Models
{
    //Enumerador
    public enum Grade
    {
        A,
        B,
        C,
        D,
        E

    }

    public class Matriculas
    {
        public int MatriculaId { get; set; }
        public int CursoId { get; set; }
        public int EstudanteId { get; set; }
        public Grade? Grade { get; set; }

        //Propriedades de navegação - Também utilizadas pelo Entity Framework para criar relacionamento entre as tabelas
        public Cursos Curso { get; set; }
        public Estudantes Estudante { get; set; }
    }
}