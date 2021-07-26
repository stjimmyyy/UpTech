namespace UpTech.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    
    using Microsoft.AspNetCore.Mvc.Rendering;
    
    using static DataConstants;
    public class CategoryItem
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(CategoryItemConstraint.TitleMaxLength, MinimumLength = CategoryItemConstraint.TitleMinLength)]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public int CategoryId { get; set; }
        
        public int MediaTypeId { get; set; }
        
        [NotMapped]
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }
        
        public DateTime DateTimeItemReleased { get; set; }
    }
}