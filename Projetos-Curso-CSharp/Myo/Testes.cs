using System;
using System.Diagnostics;
using System.IO;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp {
    class Testes {
        static void Main(string[] args) {

            //double insano = 1.69;
            //Console.WriteLine($"Hi\nTyler!! {insano.ToString("F", C.I)}");

            string sourcePath = @"C:\Users\unial\Videos\OBS\Replay 2025-08-27 16-08-01.mp4";
            string targetPath = @"C:\Users\unial\Videos\OBS\Copy2.mp4";

            var stopwatch = new Stopwatch();

            try {
                Console.WriteLine("Copiando de forma otimizada (versão compatível)...");
                stopwatch.Start();

                const int bufferSize = 1024 * 1024; // 1MB

                // 1. Usando o bloco 'using' tradicional, compatível com C# 7.3
                using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize, FileOptions.Asynchronous)) {
                    using (FileStream destinationStream = new FileStream(targetPath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize, FileOptions.Asynchronous)) {
                        // 2. Chamando o método async e esperando o resultado de forma síncrona
                        sourceStream.CopyToAsync(destinationStream, bufferSize).GetAwaiter().GetResult();
                    }
                }
            } catch (IOException err) {
                Console.WriteLine($"Error: {err.Message}");
            } finally {
                stopwatch.Stop();
                Console.WriteLine($"Concluído em {stopwatch.Elapsed.TotalSeconds:F2} segundos.");
                Console.WriteLine($"Ou {stopwatch.Elapsed.TotalMinutes:F2} minutos.");
            }

        }
    }
}