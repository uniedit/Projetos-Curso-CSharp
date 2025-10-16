using System;

namespace Projetos_Curso_CSharp.Myo.OO.Generics.Demo.Sem_Restrição {

    // Parametriza a classe com algum tipo Generic -> class PrintService<NomeDoGeneric>
    class PrintService<Generic> {
        private Generic[] _values = new Generic[10];
        private int _count = 0;

        public void AddValue(Generic value) {
            if (_count == 10) {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public Generic First() {
            if (_count == 0) {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print() {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++) {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0) {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }

    }
}
