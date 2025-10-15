using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Problema_do_Diamante.Devices {
    // Herda o ProcessDoc do Device, uma vez que Scanner é um Device
    // Herda também de IScanner o Scan, para que uma outra classe possa utilizar seu metodo proprio
    class Scanner : Device, IScanner {

        public override void ProcessDoc(string document) {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan() {
            return "Scanner scan result";
        }

    }
}
