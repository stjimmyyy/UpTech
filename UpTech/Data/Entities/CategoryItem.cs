namespace UpTech.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;
    public class CategoryItem
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(CategoryItemConstraint.TitleMaxLength, MinimumLength = CategoryItemConstraint.TitleMinLength)]
        public string Title { get; set; }
        
        public int CategoryId { get; set; }
        
        public int MediaTypeId { get; set; }
        
        public DateTime DateTimeItemReleased { get; set; }
    }
}