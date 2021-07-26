namespace UpTech.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class UserCategory
    {
        [Key]
        public int Id { get; set; }
        
        public string UserId { get; set; }
        
        public int CategoryId { get; set; }
    }
}