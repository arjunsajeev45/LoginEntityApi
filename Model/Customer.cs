using System.ComponentModel.DataAnnotations;

namespace LoginEntityApi.Model
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
