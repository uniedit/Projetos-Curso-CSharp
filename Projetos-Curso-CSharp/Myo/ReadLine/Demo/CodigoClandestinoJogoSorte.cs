using System;
using C = Projetos_Curso_CSharp.Global.Global;
using System.Collections.Generic;
using System.Diagnostics;

namespace Projetos_Curso_CSharp.Myo.ReadLine.Demo {
    class CodigoClandestinoJogoSorte {
        public void Main(string[] args) {

            int continuar = 1, i = 1, tentativas = 0;
            List<int> list = new List<int>();
            var tempo = new Stopwatch();
            bool looping = true;
            double mark = 0;

            Console.WriteLine("Jogo da Sorte");
            Console.WriteLine("Você tem que advinhar um número entre 1 e 100");
            Console.WriteLine("O tempo começa a partir do 1º chute. Se divirta!");

            Random random = new Random();
            int resp = random.Next(1, 101);
            //Console.WriteLine(resp);

            do {
                Console.Write($"Seu {i}º chute é: ");
                int chute = int.Parse(Console.ReadLine());

                if (i == 1) {
                    tempo.Start();
                }

                if (chute > resp) {
                    Console.WriteLine("O número é menor. Tente novamente.");
                    i++;
                } else if (chute < resp) {
                    Console.WriteLine("O número é maior. Tente novamente.");
                    i++;
                } else if (chute == resp) {
                    tempo.Stop();
                    tentativas = tentativas + i;
                    Console.WriteLine($"Parabens!! Você demorou {i} tentativas!!");
                    Console.WriteLine($"E demorou {tempo.Elapsed.TotalSeconds.ToString("F2")} segundos!!");
                    mark += tempo.Elapsed.TotalSeconds;
                    Console.WriteLine("");
                    list.Add(resp);

                    Console.Write("Você quer continuar (s/n)? ");
                    char cont = char.Parse(Console.ReadLine());
                    string lowerCont = cont.ToString().ToLower();

                    if (lowerCont == "s") {
                        Console.Clear();
                        i = 1;
                        resp = random.Next(1, 101);
                        //Console.WriteLine(resp);
                    } else if (lowerCont == "n") {
                        Console.Clear();
                        Console.WriteLine($"Tempo total para acertos: {mark.ToString("F2", C.I)} segundos!!");
                        Console.WriteLine($"Tentativas usadas: {tentativas}");
                        Console.Write("Números que foram acertados: ");
                        int n1 = 0;
                        foreach (int conta in list) {
                            int n2 = list.Count;
                            n1++;
                            Console.Write(conta);
                            if (n1 != n2) {
                                Console.Write(", ");
                            }
                        }
                        Console.WriteLine("");
                        looping = false;
                    }
                } else {
                    Console.WriteLine("Chute errado. Tente novamente.");
                    continuar++;
                }

            } while (looping == true);

        }
    }
}
