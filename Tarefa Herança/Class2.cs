using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criado dentro do projeto uma pasta entidades para separar classes do programa principal
namespace Tarefa_Herança
{
    //Criação da classe Conta
    class ContaJuridica: Conta {
        //Declarações das variáveis e uso do encapsulamento
        public double EmprestimoLimite{ get; set; }
//Criação do construtor padrão
        public ContaJuridica() {}
        //Criação do construtor com parâmetros utilizando o da Classe Conta
        public ContaJuridica(intnumero, stringtitular, doublesaldo, doubleemprestimoLimite)
        : base(numero, titular, saldo){
EmprestimoLimite= emprestimoLimite;
}
public void Emprestimo(doublesaldoTotal){
    if (saldoTotal <= EmprestimoLimite)
    {
        Saldo += saldoTotal;
    }
}
}
}