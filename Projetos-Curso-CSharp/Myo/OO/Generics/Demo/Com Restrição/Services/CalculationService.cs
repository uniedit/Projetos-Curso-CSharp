using System.Collections.Generic;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Generics.Demo.Com_Restrição.Services {
    class CalculationService {

        /*
            Criando um metodo Generico e também uma lista do tipo Generico 
            (já que tanto o metodo e seu tipo tem que ser Generico), além
            de colocar uma restrição em qual tipo de dado que esse metodo 
            pode receber -> where Generic : IComparable (IComparable compara).
        */

        public Generic Max<Generic>(List<Generic> list) where Generic : IComparable {

            // Programação defensiva para verificar se a lista não é vazia
            if (list.Count == 0) {
                throw new ArgumentException("The list can not be empty");
            }
            
            // Criando uma variavel Generica "max" recebendo a list na posição 0
            Generic max = list[0];

            // Enquanto não chegar no fim
            for (int i = 1; i < list.Count; i++) {
                // .CompareTo para que possa ser possivel usar o "maior que" em tipos genericos
                if (list[i].CompareTo(max) > 0) {
                    max = list[i];
                }
            }
            return max;
        }

    }
}
