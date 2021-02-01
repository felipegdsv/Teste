using ExercicioTeste.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExercicioTeste.Models
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Invalid Format")]
        [CustomCPFValidator(ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 8, ErrorMessage= "Invalid Format")]
        public string CEP { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Complemento  { get; set; }

        [Required]
        public string Cidade  { get; set; }

        [Required]
        public string Estado { get; set; }

    }
 
 
 
 
 
 
 
 
 
 
}
