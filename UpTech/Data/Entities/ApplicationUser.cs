namespace UpTech.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

    using static DataConstants;
    public class ApplicationUser : IdentityUser
    {
        [StringLength(User.FirstNameMaxLength)]
        public string FirstName { get; set; }
        
        [StringLength(User.LastNameMaxLength)]
        public string LastName { get; set; }
        
        [StringLength(User.FirstAddressMaxLength)]
        public string FirstAddress { get; set; }
        
        [StringLength(User.SecondAddressMaxLength)]
        public string SecondAddress { get; set; }
        
        [StringLength(User.PostCodeMaxLength)]
        public string PostCode { get; set; }
        
        [ForeignKey("UserId")]
        public virtual ICollection<UserCategory> UserCategories { get; set; }
        
    }
}