using System;
using System.Collections.Generic;

namespace Tarefa_Salario_POO_180042
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public void incrementarSalario(double porcentagem)
        {
            Salario *= porcentagem;
        }
    }
}
