using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EscolaBarrosTecnologia.Web.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EscolaBarrosTecnologia.Web.DAL
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() :  base("EscolaBarrosConexao")
        {

        }

        //Definição das classes que se tornarão tabelas no database
        public DbSet<Estudantes> Estudante { get; set; }
        public DbSet<Matriculas> Matricula { get; set; }
        public DbSet<Cursos> Curso { get; set; }


        //Método que define a propriedade que desabilita a convenção de pluralização do Entity Framework
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}