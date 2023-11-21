using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace BankingApp.Models
{
    public class IncomeSource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Display(Name = "Occupation")]
        [Required]
        public string Occupation { get; set; }

        [Display(Name = "Job Description")]
        [Required]
        public string Jdescription { get; set; }

        [Display(Name = "Salary Range")]
        [Required]
        public string Salary { get; set; }


        [Display(Name = "Pay-day date")]
        [Required]
        public DateOnly paydate { get; set; }

        [Display(Name = "Company Name")]
        [Required]
        public string CompanyName { get; set; }

        [Display(Name = "Employee Start date")]
        [Required]
        public DateOnly ESDATE { get; set; }


        [Display(Name = "Employee End date")]
        public DateOnly EEDATE { get; set; }

        [Display (Name = "Proof of income")]
        []
    }
}
