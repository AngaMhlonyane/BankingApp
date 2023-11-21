using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Models
{
    public class AccountType
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Account Name")]
        [Required]  
        public string AccountName { get; set; }

        [Display(Name =" Account Number")]
        [Required]
        public long AccountNumber { get; set; }

        [Display(Name ="Account Type")]
        [Required]
        public string  TypeofAccount { get; set; }

        [Display(Name ="Limit")]
        [Required]
        public string DailyLimit { get; set; }

        
    }
}
