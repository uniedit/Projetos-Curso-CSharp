using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Problema_do_Diamante.Devices;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Problema_do_Diamante {
    class Program {
        public void Main(string[] args) {

            Printer p = new Printer() { 
                SerialNumber = 1080
            };

            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { 
                SerialNumber = 2003
            };

            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { 
                SerialNumber = 3921
            };

            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());

        }
    }
}
