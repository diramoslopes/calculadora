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
                case '/': operacao.resultado = divisao(operacao); break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public double soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public double subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public double multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public double divisao(Operacoes operacao)
        {
            if (operacao.valorB == 0){
                Console.WriteLine("valor B não pode ser zero.");
                return 0;
            }
            return operacao.valorA / operacao.valorB;
        }

    }
}
