using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OurHeroApiWithCodeFirstApproach.Model
{
    [Table("tblOurHero")]
    public class OurHero
    {
        [Key]
        public int Id {  get; set; }     
        [Required]
        public string FirstName { get; set; }   
        [Required]  
        public string LastName { get; set; }    

        public bool isActive { get; set; }  
    }
}
g