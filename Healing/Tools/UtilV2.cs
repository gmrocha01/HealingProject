using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healing.Tools
{
    public static class UtilV2
    {
        public static int GetInteiro(this string texto)
        {
            int inteiro = 0;
            int.TryParse(texto, out inteiro);

            return inteiro;
        }

        public static long GetLong(this string texto)
        {
            long valor = 0;
            long.TryParse(texto, out valor);

            return valor;
        }

        public static DateTime GetData(this string texto)
        {
            DateTime data = DateTime.Now;
            DateTime.TryParse(texto, out data);

            return data;
        }

        public static decimal GetDecimal(this string texto)
        {
            decimal valor = 0;
            decimal.TryParse(texto, out valor);

            return valor;
        }

        public static string GetStringDB(this decimal valor)
        {
            return valor.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }


        /// <summary>
        /// Transforma um DateTime em uma String com a Data (yyyy-MM-dd)
        /// </summary>
        /// <returns></returns>
        public static string GetFormatDate(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }


        /// <summary>
        /// Transforma um DateTime em uma string data e hora (yyyy-MM-dd HH:mm:ss)
        /// </summary>
        /// <returns></returns>
        public static string GetFormatDateTime(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }


        /// <summary>
        /// Transforma um DateTime em uma String com a Data sem Hifen (yyyyMMdd)
        /// </summary>
        /// <returns></returns>
        public static string GetFormatDateSemHifen(this DateTime date)
        {
            return date.ToString("yyyyMMdd");
        }


        /// <summary>
        /// Transforma um DateTime em uma string hora (HH:mm:ss)
        /// </summary>
        /// <returns></returns>
        public static string GetFormatTime(this DateTime time)
        {
            return time.ToString("HH:mm:ss");
        }


        /// <summary>
        /// Transforma um DateTime em uma string data (dd/MM/yyyy)
        /// </summary>
        /// <returns></returns>
        public static string GetFormatDateUI(this DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Transforma um DateTime em uma string data e hora (dd/MM/yyyy HH:mm)
        /// </summary>
        /// <returns></returns>
        public static string GetFormatDateTimeUI(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy HH:mm");
        }

        /// <summary>
        /// Transforma um DateTime em uma string data e hora (HH:mm)
        /// </summary>
        /// <returns></returns>
        public static string GetFormatTimeUI(this DateTime dateTime)
        {
            return dateTime.ToString("HH:mm");
        }
    }
}
