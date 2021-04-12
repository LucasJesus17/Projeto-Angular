using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Angular.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Foto { get; set; }

        public int RG { get; set; }

        public Departamento IdDepartamento { get; set; }

    }
}
