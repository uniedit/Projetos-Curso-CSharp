using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class Timespan {
        public void Method() {

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan c1 = TimeSpan.FromDays(1.5);
            TimeSpan c2 = TimeSpan.FromHours(1.5);
            TimeSpan c3 = TimeSpan.FromMinutes(1.5);
            TimeSpan c4 = TimeSpan.FromSeconds(1.5);
            TimeSpan c5 = TimeSpan.FromMilliseconds(1);
            TimeSpan c6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);

            TimeSpan d1 = TimeSpan.MaxValue;
            TimeSpan d2 = TimeSpan.MinValue;
            TimeSpan d3 = TimeSpan.Zero;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //Propriedades
            TimeSpan g = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(g);
            Console.WriteLine("Days: " + g.Days);
            Console.WriteLine("Hours: " + g.Hours);
            Console.WriteLine("Minutes: " + g.Minutes);
            Console.WriteLine("Milliseconds: " + g.Milliseconds);
            Console.WriteLine("Seconds: " + g.Seconds);
            Console.WriteLine("Ticks: " + g.Ticks);
            Console.WriteLine("TotalDays: " + g.TotalDays);
            Console.WriteLine("TotalHours: " + g.TotalHours);
            Console.WriteLine("TotalMinutes: " + g.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + g.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + g.TotalMilliseconds);

            //Operações
            TimeSpan b1 = new TimeSpan(1, 30, 10);
            TimeSpan b2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = b1.Add(b2);
            TimeSpan dif = b1.Subtract(b2);
            //TimeSpan mult = b2.Multiply(2.0);
            //TimeSpan div = b2.Divide(2.0);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

        }
    }
}
