using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Herança
namespaceCourse.Entities{
class ContaJuridica: Conta {
		public double EmprestimoLimite{ get; set; }
		public ContaJuridica() {}
		public ContaJuridica
		(intnumero, stringtitular, doublesaldo, doubleemprestimoLimite)
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
