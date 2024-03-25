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
            static Stack<double> PilhaM()
            {

                Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
                filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
                filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
                filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
                filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 0, operador = '/' }); //Implemente o calculo de divisao

                Calculadora calculadora = new Calculadora();
                var pilha = new Stack<double>();

                for (int indice = 0; indice <= 3; indice++)
                {
                    Operacoes operacao = filaOperacoes.Dequeue();
                    calculadora.calcular(operacao);
                    Console.WriteLine("\n{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
                    //Console.WriteLine("Proxima operacao: {0}" , filaOperacoes.Peek().operador);
                    pilha.Push(operacao.resultado);
                }

                Console.WriteLine("\nResultado de cada calculo efetuado e imprima a pilha ao final:");
                return pilha;

            }
                var pilha = PilhaM();
                foreach (double i in pilha)
                Console.WriteLine(i) ;
                }
            }

        }
    

