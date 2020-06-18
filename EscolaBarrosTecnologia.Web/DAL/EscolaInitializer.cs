using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EscolaBarrosTecnologia.Web.Models;

namespace EscolaBarrosTecnologia.Web.DAL
{
    //Instrução para que o banco de dados seja criado, caso já tenha será dropado. Além disso carrega automaticamente os dados de teste no novo banco de dados - Este método e esta classe de inicialização são opcionais, tem como objetivo ser a "semente" de inicialização do no BD
    public class EscolaInitializer : DropCreateDatabaseIfModelChanges<EscolaContext>
    {
        protected override void Seed(EscolaContext context)
        {
            //Popular a tabela de Estudantes
            var estudantes = new List<Estudantes>
            {
                new Estudantes{Nome="Bruno", Sobrenome="dos Reis Costa", DataMatricula=DateTime.Parse("2019-06-01")},
                new Estudantes{Nome="Luigi", Sobrenome="Comenale", DataMatricula=DateTime.Parse("2020-01-01")},
                new Estudantes{Nome="Tatiana", Sobrenome="Barros", DataMatricula=DateTime.Parse("2020-05-02")}
            };

            //Percorre os itens de dentro da lista e informa ao Entity Framework
            //Adiciona na tabela Estudantes do nosso contexto, nosso contexto é a referência do banco de dados dentro da aplicação, quando criei a lista determinei que ela vai receber objetos do tipo Estudantes, então todos os novos objetos que criei serão armazenados pra quando chamar o SaveChanges gerar o insert na tabela
            estudantes.ForEach(x => context.Estudante.Add(x));

            //Quando é executado o SaveChanges o Entity gera o insert para a tabela Estudantes
            //A variável result armazena a quantidade de linhas afetadas (neste caso retornaria 3 linhas afetadas)
            var result = context.SaveChanges();

            var lstCurso = new List<Cursos>
            {
                new Cursos{CursoId=1, NomeCurso="Arquitetura de Software", Credito=5000},
                new Cursos{CursoId=2, NomeCurso="Desenvolvimento .NET", Credito=2000},
                new Cursos{CursoId=3, NomeCurso="Fortran for .NET", Credito=1000},
            };

            lstCurso.ForEach(s => context.Curso.Add(s));

            context.SaveChanges();

            //Matrículas

            var lstMatriculas = new List<Matriculas>
            {
                new Matriculas{EstudanteId=1, CursoId=1, Grade=Grade.A },
                new Matriculas{EstudanteId=2, CursoId=2, Grade=Grade.B },
                new Matriculas{EstudanteId=3, CursoId=3, Grade=Grade.C },
            };

            lstMatriculas.ForEach(x => context.Matricula.Add(x));
            context.SaveChanges();
        }
    }
}