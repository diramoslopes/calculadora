using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            for (int indice = 1; indice <= 4; indice++)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);                
            }

            Console.WriteLine("\nResultado de cada calculo efetuado e imprima a pilha ao final");

            static Stack<long> PilhaM()
            {
                var pilha = new Stack<long>();
                pilha.Push(18 / 3);
                pilha.Push(2147483647L + 2);
                pilha.Push(5 * 6);
                pilha.Push(14 - 8);
                return pilha;
            }

            var pilha = PilhaM();
            foreach (long i in pilha) {
                Console.WriteLine(i);
            }

        }
    }
}
