using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Myo.OO.Structs {
    struct Point {

        public double X, Y;
        public override string ToString() {
            return "(" + X + "," + Y + ")";
        }

        /*
                                                            Tipos referência vs. tipos valor
                    CLASSE                                                                     STRUCT
                    Vantagem: usufrui de todos recursos OO                                     Vantagem: é mais simples e mais performático
                    Variáveis são ponteiros                                                    Variáveis são caixas
                    Objetos precisam ser instanciadas usando new, ou
                    apontar para um objeto já existente.
                                                                                               Não é preciso instanciar usando new, mas é possível
                    Aceita valor null                                                          Não aceita valor null
                    Suporte a herança                                                          Não tem suporte a herança (mas pode implementar interfaces)
                    Y = X;
                    "Y passa a apontar para onde X aponta"
                                                                                               Y = X;
                                                                                               "Y recebe uma cópia de X"
                    Objetos instanciados no heap                                               Objetos instanciados no stack
                    Objetos não utilizados são desalocados em um
                    momento próximo pelo garbage collector
                                                                                               "Objetos" são desalocados imediatamente quando
                                                                                               seu escopo de execução é finalizado
        */

    }
}
