using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        // declaração de atributos
        public int numero;
        public string titular;
        public double saldo;
        // declaração dos métodos (funções)
        public void MostrarAtributos()
        {
             Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo: {saldo:c}");
        }

        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            // saldo = saldo + valorDeposito
            saldo += valorDeposito;
        }
        public void Transferir(double valorTransferencia, Conta objContaDestino)
        {
            saldo = saldo - valorTransferencia;
            objContaDestino.saldo += valorTransferencia;
        }
    }
}