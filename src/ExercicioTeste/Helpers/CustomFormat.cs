using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExercicioTeste.Helpers
{
    public static class CustomFormat
    {
        public static string CNPJ(string CNPJ)
        {
            return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
        }

        public static string CPF(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
        }
        
        public static string RemoveFormat(string formatedText)
        {
            return Regex.Replace(formatedText, @"\D", "");
            
        }
    }
}
