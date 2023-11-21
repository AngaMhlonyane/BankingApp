using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class AccountDetails
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [Required]
        public string Surname { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        public DateOnly DOB { get; set; }

        [Display(Name = "Countryofbirth")]
        [Required]
        public string CountryOB { get; set; }

        [Display(Name = "SA ID No / Passport")]
        [Required]
        public string IdentityNo { get; set; }

        [Display(Name ="Gender")]
        [Required]  
        public string Gender { get; set; }

        [Display(Name = "Race")]
        [Required]
        public string Race { get; set; }


        [Display(Name = "Province")]
        [Required]
        public string Province { get; set; }

        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

        [Display(Name = "Area Code")]
        [Required]
        public int AreaCode { get; set; }

        

    }
}
