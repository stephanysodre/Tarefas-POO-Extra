using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{

      class ContaPoupanca: Conta 
      { 
      
            public double TaxaJuros{ get; set; } 
      
            public ContaPoupanca() {    } 
      
            public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros)
            : base(numero, titular, saldo)
                       {
                       TaxaJuros = taxaJuros; 
                       } 
    public void atualizacaoSaldo()
                      { 
                      Saldo += Saldo * taxaJuros; 
                      } 
     } 
}  
