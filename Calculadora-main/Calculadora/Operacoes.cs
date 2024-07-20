using System;
namespace Calculadora
{
    public class Operacoes
    {
        public long valorA {get;set;}// mudança da variavel tipo INT (Valor maximo de 2147483647) para Long Inteiro assinado de 64 bits
        public char operador { get; set; }
        public int valorB { get; set; }
        public long resultado { get; set; } // mudança da variavel tipo decimal para Long de 64 bits

    }
}
