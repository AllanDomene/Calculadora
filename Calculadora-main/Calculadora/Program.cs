using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' }); 
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); ///Implementado o calculo de divisao///

            Calculadora calculadora = new Calculadora();
            Stack<long> resultados = new Stack<long>();///pilha  stack do tipo long
            
            while (filaOperacoes.Count > 0)///mudou a condição de que ser >= ia acarretar um looping////
            {
                Operacoes operacao = filaOperacoes.Dequeue();//// troca do .Peek para Dequeue(o primeiro a entrar é o primeiro a sair))
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                resultados.Push(operacao.resultado); // Inclusão da linha para o Stack
                ImprimirOperacoesRestantes(filaOperacoes);// Imprimir a lista de operações restantes
                 }
                 ImprimirResultados(resultados);
            }
            static void ImprimirOperacoesRestantes(Queue<Operacoes> filaOperacoes)
             {
            Console.WriteLine("Operações restantes na fila:"); ////// imprime as operações restantes na fila/////////
            foreach (var operacao in filaOperacoes)
            {
                Console.WriteLine("{0} {1} {2}", operacao.valorA, operacao.operador, operacao.valorB);
            }
            Console.WriteLine();
             }
        static void ImprimirResultados(Stack<long> resultados) //// imprime os resultados das somas do stack////////
        {
            Console.WriteLine("Resultados dos cálculos:");
            while (resultados.Count > 0)
            {
                Console.WriteLine(resultados.Pop());
            }
        }
    }
}
