using Microsoft.AspNetCore.Mvc;
using payflowdotnet.Dtos;
using payflowdotnet.Models;
using payflowdotnet.Services;

//URL → Routing Engine → Controller → Action → Response

namespace payflowdotnet.Controllers;

[ApiController]
[Route("api/customer")]
public class CustomerController:Controller
{
  private readonly ICustomerService _customerService; // Interface reference variable is assigned the object of the class that implements the Interface
  public CustomerController(ICustomerService customerService)
  {
    _customerService=customerService;
  }
  [HttpPost]
  public Task<CreateCustomerDTO> CreateCustomer(CreateCustomerDTO createCustomerDTO)
  {
    return _customerService.Create(createCustomerDTO);
  }

  [HttpGet("{id:long}")]
  public Task<CreateCustomerDTO> GetCustomerById(long id)
  {
    return _customerService.GetCustomerById(id);
  }

  [HttpGet]
  public Task<List<CreateCustomerDTO>> GetAllCustomers()
  {
    return _customerService.GetAllCustomers();
  }

  [HttpDelete("{id:long}")]
  public  Task<string> DeleteCustomer(long id)
  {
    return _customerService.DeleteCustomer(id);
  }

  [HttpPut("{id:long}")]
  public Task<CreateCustomerDTO> UpdateCustomer(CreateCustomerDTO createCustomerDTO,long id)
  {
    return _customerService.UpdateCustomer(createCustomerDTO,id);
  }
}