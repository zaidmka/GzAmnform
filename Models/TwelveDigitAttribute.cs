using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzAmnform.Models
{
	public class TwelveDigitAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value is long number)
			{
				// Check if the number is exactly 12 digits
				if (number >= 100000000000 && number <= 999999999999)
				{
					return ValidationResult.Success;
				}
				else
				{
					return new ValidationResult("The id number must be exactly 12 digits.");
				}
			}
			else
			{
				return new ValidationResult("Invalid number format.");
			}
		}
	}
}
