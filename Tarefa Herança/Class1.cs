using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Herança
//Criado dentro do projeto uma pasta entidades para separar classes do programa principal
{
	//Criação da classe Conta
	class Conta
	{
		//Declarações das variáveis e uso do encapsulamento
		public int Numero { get; privateset; }
		public string Titular { get; privateset; }
		//Utilização do protected para alteração de valores entre classes
		public double Saldo { get; protectedset; }
		//Criação do construtor padrão e construtor com parâmetros
		public Conta() { }
		public Conta(intnumero, stringtitular, doublesaldo)
		{
			Numero = numero; Titular = titular; Saldo = saldo;
		}
		//Método de Saque
		public void Saque(doublesaldoTotal)
		{
			Saldo -= saldoTotal;
		}
		//Método de Deposito
		public void Deposito(doublesaldoTotal)
		{
			Saldo += saldoTotal;
		}
	}
}
