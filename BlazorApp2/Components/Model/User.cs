using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Components.Model;

public class User
{
    [Required(ErrorMessage = "Fornavn er påkrævet")]
    [MinLength(2, ErrorMessage = "Fornavn skal mindst være 2 karakterer")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Efternavn er påkrævet")]
    [MaxLength(30, ErrorMessage = "Efternavn må maks være 30 karakterer")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email er påkrævet")]
    [EmailAddress(ErrorMessage = "Email skal være gyldig")]
    // [RegularExpression(@".+@.+\.(dk|com|net|org)$", ErrorMessage = "Email skal ende på .dk, .com, osv.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Telefonnummer er påkrævet")]
    // [RegularExpression(@"^\+\d{2}\s?\d{8}$", ErrorMessage = "Telefonnummer skal starte med landekode, fx +45 12345678")]
    public string PhoneNumber { get; set; }
}