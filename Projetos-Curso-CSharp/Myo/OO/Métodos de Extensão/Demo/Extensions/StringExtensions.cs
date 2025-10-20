namespace Projetos_Curso_CSharp.Myo.OO.Métodos_de_Extensão.Demo.Extensions {
    static class StringExtensions {

        public static string Cut(this string thisObj, int value) {
            if (thisObj.Length <= value) {
                return thisObj;
            } else {
                return thisObj.Substring(0, value) + "...";
            }
        }

    }
}
