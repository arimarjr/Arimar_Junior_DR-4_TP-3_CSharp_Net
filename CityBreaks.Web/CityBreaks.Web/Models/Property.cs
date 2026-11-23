// Exercício: 4, 9, 11, 12
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CityBreaks.Web.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string Name { get; set; } = string.Empty;

        [Range(0.01, 1000000, ErrorMessage = "O preço deve ser maior que zero.")]
        [Display(Name = "Preço por noite")]
        public decimal PricePerNight { get; set; }

        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [ValidateNever]
        public City City { get; set; } = null!;

        public DateTime? DeletedAt { get; set; }
    }
}
