using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Problema_do_Diamante.Devices {
    // Herda o ProcessDoc do Device, uma vez que Printer é um Device
    // Herda também de IPrinter o print, para que uma outra classe possa utilizar seu metodo proprio
    class Printer : Device, IPrinter {

        public override void ProcessDoc(string document) {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document) {
            Console.WriteLine("Printer print " + document);
        }

    }
}
