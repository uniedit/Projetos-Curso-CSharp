using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class Datetime {
        public void Method() {

            DateTime p1 = DateTime.Now;
            Console.WriteLine(p1); // Mostra o horario do Pc
            Console.WriteLine(p1.Ticks); // Mostra os ticks em MS desde o ano 1 


            DateTime d1 = new DateTime(2000, 8, 15); // Define ano, mes, dia
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58); // Define ano, mes, dia, hora, minuto, segundo
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275); // Define ano, mes, dia, hora, minuto, segundo, milisegundo
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            DateTime s2 = DateTime.UtcNow; // Mostra o horario de UTC
            DateTime s3 = DateTime.Today; // Mostra o horario de hoje as 0 horas
            Console.WriteLine(s2);
            Console.WriteLine(s3);


            DateTime x1 = DateTime.Parse("2000-08-15"); // Define ano - mes - dia
            DateTime x2 = DateTime.Parse("2000-08-15 13:05:58"); // Define ano - mes - dia | hora : minuto : segundo
            DateTime x3 = DateTime.Parse("15/08/2000"); // Define dia / mes / ano
            DateTime x4 = DateTime.Parse("15/08/2000 13:05:58"); // Define dia / mes / ano | hora : minuto : segundo
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);


            // DateTime y1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", C.I);
            DateTime y1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", // Define ano - mes - dia, porém com uma mascara -> "yyyy-MM-dd"
CultureInfo.InvariantCulture);

            // Define dia / mes / ano | hora : minuto : segundo, porém com uma mascara -> "dd/MM/yyyy HH:mm:ss"
            DateTime y2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(y1);
            Console.WriteLine(y2);

        }
    }
}
