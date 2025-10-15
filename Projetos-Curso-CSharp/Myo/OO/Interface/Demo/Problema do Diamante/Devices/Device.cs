namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Problema_do_Diamante.Devices {
    // Classe abstrata Device para que, tanto scanner, tanto printer possam herdar dele
    abstract class Device {

        public int SerialNumber { get; set; }

        // Modo de criar um metodo abstrato que vai ser herdado por IScanner e IPrinter 
        // (Problema do diamante já resolvido com as duas Interfaces)
        public abstract void ProcessDoc(string document);

    }
}
