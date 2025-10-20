using System.Globalization;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Métodos_de_Extensão.Demo.Extensions {
    static class DateTimeExtensions {

        public static string ElapsedTime(this DateTime thisObj) {

            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0) {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            } else {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
            
        }

    }
}
