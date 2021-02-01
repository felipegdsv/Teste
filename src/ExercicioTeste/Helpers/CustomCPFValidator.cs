using System;
using System.ComponentModel.DataAnnotations;

namespace ExercicioTeste.Helpers
{
    public class CustomCPFValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string result = CustomFormat.RemoveFormat(value.ToString());

            if (String.IsNullOrEmpty(result) || (result?.Length < 11)) return false;
            else                                                       return true;
            
        }
    }
}
