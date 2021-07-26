namespace UpTech.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    using static DataConstants;
    
    public class MediaType
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(MediaTypeConstraint.TitleMaxLength, MinimumLength = MediaTypeConstraint.TitleMinLength)]
        public string Title { get; set; }
        
        [Required]
        public string ThumbnailImagePath { get; set; }
        
        [ForeignKey("MediaTypeId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
    }
}