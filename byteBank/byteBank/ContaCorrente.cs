﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo = 100;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
                return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
                return false;
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + titular);
            Console.WriteLine("Conta :" + conta);
            Console.WriteLine("Número Agência :" + numero_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}
