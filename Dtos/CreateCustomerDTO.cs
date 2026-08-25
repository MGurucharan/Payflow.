using System.ComponentModel.DataAnnotations;

namespace payflowdotnet.Dtos;

public class CreateCustomerDTO
{
  public required string  Name{get;set;}
  public long Id {get;set;}

  [EmailAddress(ErrorMessage = "Bad e-mail")]
  public string? Email{get;set;}
}
