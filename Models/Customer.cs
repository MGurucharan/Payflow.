using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace payflowdotnet.Models;

[Table("Customer")]
public class Customer
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public long Id {get;set;}

  public required string Name {get;set;}

  public required string Email {get;set;}

  public  string? StripeCustomerId {get;set;}

  public string? StripePaymentMethodId {get;set;}

}
