using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao);break; // inclusão da linha de divisão
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public long soma(Operacoes operacao) // mudando de int para long para não estourar a variavel
        {
            return operacao.valorA + operacao.valorB;
        }
        public long subtracao(Operacoes operacao)// mudando de int para long para não estourar a variavel
        {
            return operacao.valorA - operacao.valorB;
        }
        public long multiplicacao(Operacoes operacao)// mudando de int para long para não estourar a variavel
        {
            return operacao.valorA * operacao.valorB;
        }
       public long divisao(Operacoes operacao)// Inclusão da Divisão
        {
            return operacao.valorA / operacao.valorB;
        }
    }
}
