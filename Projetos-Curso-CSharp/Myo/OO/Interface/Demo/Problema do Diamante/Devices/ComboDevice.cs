using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Problema_do_Diamante.Devices {

    /*
        Para que ComboDevice possa ser tanto um Scanner tanto um Printer,
        ele precisa herdar somente de Interfaces, para que assim o problema do diamante
        não aconteça (Também por que a linguagem não deixaria herdar de duas SuperClasses)
    */

    class ComboDevice : Device, IScanner, IPrinter {

        public void Print(string document) {
            Console.WriteLine("Combodevice print " + document);
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Combodevice processing " + document);
        }

        public string Scan() {
            return "Combodevice scan result";
        }

    }
}
