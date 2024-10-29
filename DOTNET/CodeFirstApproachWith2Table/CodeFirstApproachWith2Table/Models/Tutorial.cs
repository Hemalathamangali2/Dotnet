using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CodeFirstApproachWith2Table.Models
{
    [Table("tblTutorial")]
    public class Tutorial
    {
        public int TutorialId { get; set; }
        [RegularExpression(pattern: @"^[a-zA-Z-_]*$", ErrorMessage = "please enter text")]
        [Required]
        [Display(Name = "Tutorial Name")]
        public string? TutorialName { get; set; }
        [Required]
        [Display(Name = "Tutorial Description")]
        public string? Description { get; set; }
        //Relationship
        //public List<Article> Articles ( get; set; )
        //public int ArticleId { get; set; }
        public virtual ICollection<Article> Articles{get; set; } = new List<Article>();
        public int ArticleId { get; internal set; }
        public string TutorialTitle { get; internal set; }
        public string TutorialContent { get; internal set; }
    }
}
