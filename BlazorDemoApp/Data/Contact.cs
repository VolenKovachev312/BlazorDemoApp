using System.ComponentModel.DataAnnotations;

namespace BlazorDemoApp.Data
{
    public class Contact
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email  { get; set; }

    }
}
