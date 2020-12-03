using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mall.Validaciones
{
    public class EdadValidacion : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int cantidad = Convert.ToInt32(value);

                if (cantidad >= 1)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("La Edad debe ser mayor o igual a 1");

            }
            return new ValidationResult("Debes poner una Edad");
        }
    }
}
