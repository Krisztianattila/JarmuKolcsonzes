using System.ComponentModel.DataAnnotations;

namespace JarmuKolcsonzes.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
