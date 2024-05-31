using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage="Cost of meal is requried!")]
        // ensure input is greater than 0
        [Range(1, double.MaxValue, ErrorMessage="Cost of meal must be greater than 0")]
        public decimal CostOfMeal { get; set; }

        // add method to calculate tip
        public decimal CalculateTip(decimal percentage)
        {
            return CostOfMeal * (percentage / 100);
        }
    }


}
