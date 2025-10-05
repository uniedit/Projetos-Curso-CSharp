using System;
using System.Globalization;

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



            // Propriedades com DateTime 
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            // Formatação(DateTime-> string)
            DateTime e = new DateTime(2001, 8, 15, 13, 45, 58);
            string e1 = e.ToLongDateString();
            string e2 = e.ToLongTimeString();
            string e3 = e.ToShortDateString();
            string e4 = e.ToShortTimeString();
            string e5 = e.ToString();
            string e6 = e.ToString("yyyy-MM-dd HH:mm:ss");
            string e7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
            Console.WriteLine(e5);
            Console.WriteLine(e6);
            Console.WriteLine(e7);

            DateTime x = new DateTime(2028);
            DateTime y = x.AddDays(1);
            DateTime h1 = x.AddHours(2);
            DateTime h2 = x.AddMilliseconds(500);
            DateTime h3 = x.AddMinutes(2);
            DateTime h4 = x.AddMonths(1);
            DateTime h5 = x.AddSeconds(25);
            DateTime h6 = x.AddTicks(20000L);
            DateTime h7 = x.AddYears(2);
            TimeSpan t = x.Subtract(x);

        }
    }
}
