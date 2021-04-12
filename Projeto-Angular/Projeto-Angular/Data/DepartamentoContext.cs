using Microsoft.EntityFrameworkCore;
using Projeto_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Angular.Data
{
    public class DepartamentoContext : DbContext
    {

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;User ID=DESKTOP-6JIGCVA\kinha;Initial Catalog=HeroApp;Data Source=DESKTOP-6JIGCVA");
        }
    }
}
