using System.ComponentModel.DataAnnotations;


namespace KIEUTHIHIEN227.Models
{
    public class CompanyKTH227

    {
        [Key]
        [MaxLength(20)]
      
        public  string CompanyID {get; set; }
        [MaxLength(50)]
        public string CompanyName{get; set; }
        
    }
}