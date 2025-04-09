using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzAmnform.Models
{
	public class TenDigitStartsWithSevenAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value is long number)
			{
				string numberString = number.ToString();
				if (numberString.Length == 10 && numberString.StartsWith("7"))
				{
					return ValidationResult.Success;
				}
				else
				{
					return new ValidationResult("رقم الهاتف يجب ان يكون 10 مراتب بدون صفر");
				}
			}
			else
			{
				return new ValidationResult("Invalid phone number format.");
			}
		}
	}
}
