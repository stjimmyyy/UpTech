namespace UpTech.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static DataConstants;

    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(CategoryConstraint.TitleMaxLength, MinimumLength = CategoryConstraint.TitleMinLength)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        [Required]
        public string ThumbnailImagePath { get; set; }
        
        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
        
        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategories { get; set; }
    }
}