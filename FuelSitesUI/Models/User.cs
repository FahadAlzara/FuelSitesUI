using System.ComponentModel.DataAnnotations;

namespace FuelSitesUI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
