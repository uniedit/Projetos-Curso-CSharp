using Projetos_Curso_CSharp.Myo.OO.Delegates.Demo.Services;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Delegates.Demo {
    
    // Sintaxe para declarar um delegate que recebe 2 parametros
    delegate double BinaryNumbericOperation(double x, double y);
    // Sintaxe para declarar um delegate void com 2 parametros
    delegate void BinaryNumericOperationShow(double x, double y);

    class Program {
        public void Main(string[] args) {

            double a = 34;
            double b = 2;

            // Declaração do delegate + nome do var = NomeClasse.Função
            BinaryNumbericOperation sum = CalculationService.Sum;
            BinaryNumbericOperation max = CalculationService.Max;

            //sum.Invoke(a, b); <- Sintaxe alternativa para chamar a função
            double resultSum = sum(a, b);
            double resultMax = max(a, b);

            BinaryNumericOperationShow showAll = CalculationService.ShowSum;
            // Sintaxe para chamar dois metodos para o delegate <- Multicast
            showAll += CalculationService.ShowMax;

            Console.WriteLine(resultSum);
            Console.WriteLine(resultMax);

            Console.WriteLine("-------------");

            //showAll.Invoke(a, b);
            showAll(a, b);
        }
    }
}
