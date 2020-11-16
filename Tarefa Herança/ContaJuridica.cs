using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Herança
class ContaJuridica: Conta {
		public double EmprestimoLimite{ get; set; }
		public ContaJuridica() {}
		public ContaJuridica
		(int numero, string titular, double saldo, double emprestimoLimite)
		: base(numero, titular, saldo){
			EmprestimoLimite = emprestimoLimite;
			}
			public void Emprestimo(doublesaldoTotal){
				if (saldoTotal<= EmprestimoLimite){
					Saldo += saldoTotal;
				}
			}
		}
}
