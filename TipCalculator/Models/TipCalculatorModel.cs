using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage="Cost of meal is requried!")]
        [Range(1, double.MaxValue, ErrorMessage="Cost of meal must be greater than 0")]
        public decimal CostOfMeal { get; set; }

        public decimal CalculateTip(decimal percentage)
        {
            return CostOfMeal * (percentage / 100);
        }
    }


}
