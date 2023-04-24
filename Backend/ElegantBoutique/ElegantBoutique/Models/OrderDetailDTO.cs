using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElegantBoutique.Models
{
    public class OrderDetailDTO : IValidatableObject
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        [Required]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemUnitPrice { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Quantity <= 0)
            {
                yield return new ValidationResult(
                    $"Quantity must be > 0",
                    new[] { nameof(Quantity) });
            }
        }
    }
}
