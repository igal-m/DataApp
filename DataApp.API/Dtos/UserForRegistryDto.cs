using System.ComponentModel.DataAnnotations;

namespace DataApp.API.Dtos

{
    public class UserForRegistryDto
    {
        [Required]
        public string Username { get; set; }

        [Required] 
        [StringLength(8, MinimumLength=4, ErrorMessage = "tou must specify pasword between 4 and 8 characters ")]
        public string password { get; set; }
        
    }
}