using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactRoastDotnet.Data.Entities;

public class Cart
{
    // Has one user.
    [Required] [Key] public int UserId { get; set; }
    public virtual User? User { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime DateCreated { get; set; }

    // Has many cart items.
    public virtual List<CartItem>? CartItems { get; set; }
}