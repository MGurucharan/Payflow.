using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using payflowdotnet.Data;
using payflowdotnet.Dtos;
using payflowdotnet.Models;

namespace payflowdotnet.Services;

public class CustomerService:ICustomerService
{
  private readonly PayflowContext payflowContext;

  public CustomerService(PayflowContext payflowContext)
  {
    this.payflowContext=payflowContext;
  }
  public async Task<CreateCustomerDTO> Create(CreateCustomerDTO customerDTO)
  {
    // Bussiness logic to create a Customer Entity and store it in the Database using an instance of Payflow context

    // 1. Creation of the Entity 
    Customer customer = new Customer
    {
      Name=customerDTO.Name,
      Email=customerDTO.Email
    };

    // 2. Storing the Entity
    await payflowContext.Customers.AddAsync(customer);

    await payflowContext.SaveChangesAsync();

    CreateCustomerDTO createCustomerDTO=convertToCustomerDTO(customer);

    return createCustomerDTO;

  }

  public async Task<CreateCustomerDTO> GetCustomerById(long id)
  {
    Customer? customer=await payflowContext.Customers.FirstOrDefaultAsync(c=>c.Id==id);
    if(customer==null)
    {
      throw new Exception("Customer not found !");
    }

    return convertToCustomerDTO(customer);
  }

  public async Task<List<CreateCustomerDTO>> GetAllCustomers()
  {
    List<Customer> customers= await payflowContext.Customers.ToListAsync();

    List<CreateCustomerDTO> createCustomerDTOs=[];

    customers.ForEach((customer) =>
    {
      CreateCustomerDTO createCustomerDTO = convertToCustomerDTO(customer);
      createCustomerDTOs.Add(createCustomerDTO);
    });

    return createCustomerDTOs;
  }


  public async Task<string> DeleteCustomer(long id)
  {
    Customer? customer = await payflowContext.Customers.FirstOrDefaultAsync((c)=>(c.Id)==id);

    if(customer!=null)
    {
      payflowContext.Customers.Remove(customer);
      await payflowContext.SaveChangesAsync();
      return "Customer deleted successfully !";
    }
    else
    {
      return "Customer not found !";
    }
  }

  public async Task<CreateCustomerDTO> UpdateCustomer(CreateCustomerDTO createCustomerDTO, long id)
  {
    Customer? customer = await payflowContext.Customers.FirstOrDefaultAsync((c)=>(c.Id)==(id));

    if(customer==null)
    {
      throw new Exception("Customer not found");
    }
    else
    {
      if(createCustomerDTO.Email!=null)
      {
        customer.Email=createCustomerDTO.Email;
      }
      customer.Name=createCustomerDTO.Name;

      payflowContext.Customers.Update(customer);

      await payflowContext.SaveChangesAsync();

      return convertToCustomerDTO(customer);

    }

  }

  public CreateCustomerDTO convertToCustomerDTO(Customer customer)
  {
    CreateCustomerDTO createCustomerDTO=new CreateCustomerDTO
    {
      Name=customer.Name,
      Id=customer.Id,
      Email=customer.Email
    };

    return createCustomerDTO;
  }
}