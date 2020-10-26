using System;
using System.Collections.Generic;

namespace Tarefa-Salario
{
    class Funcionario
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionario { Id = id, Nome = nome, Salario = salario });
            }

            Console.WriteLine("Digite o id do funcionário: ");
            int idFunc = int.Parse(Console.ReadLine());

            var func = funcionarios.Find(x => x.Id == idFunc);

            if (func != null)
            {
                Console.WriteLine("Digite a porcentagem: ");
                double porc = double.Parse(Console.ReadLine());
                func.incrementarSalario(porc);
            }
            else
            {
                Console.WriteLine("Id inexistente!");
            }

            Console.WriteLine();
            Console.WriteLine("Atualização:");
            foreach (var item in funcionarios)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Salario);
                Console.WriteLine("--------------");
            }
        }
    }
}