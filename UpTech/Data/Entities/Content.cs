namespace UpTech.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    
    using static DataConstants;
    
    public class Content
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(ContentConstraint.TitleMaxLength, MinimumLength = CategoryConstraint.TitleMinLength)]
        public string Title { get; set; }
        
        public string HtmlContent { get; set; }
        
        public string VideoLink { get; set; }
        
        public CategoryItem CategoryItem { get; set; }
    }
}