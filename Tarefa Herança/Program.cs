using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados Cadastrais
            Conta acc= new Conta(1001, "Goku", 0.0);
            ContaJuridicabacc= new ContaJuridica(1002, "Goten", 0.0, 500.0); 
            //UPCASTING
            Conta acc1 = bacc;
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
            Conta acc3 = new ContaPoupanca(1004, "Vegeta", 0.0, 0.01);
            //DOWNCASTING
            ContaJuridicaacc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);
            if(acc3 isContaJuridica) {
	        //ContaPoupancaacc5 = (ContaPoupanca)acc3 
	        ContaJuridicaacc5 = (ContaJuridica)acc3;
	        acc5.Emprestimo(200.0);
	        Console.WriteLine("Emprestimo!");
	        }
	   if(acc3 isContaPoupanca){
		//ContaPoupancaacc5 = (ContaPoupanca)acc3 
		ContaPoupancaacc5 = acc3 as ContaPoupanca;
		acc5.atualizaSaldo();
		Console.WriteLine("Atualizado!");
        }
    }
}
