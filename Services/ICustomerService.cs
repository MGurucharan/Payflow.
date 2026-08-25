using payflowdotnet.Dtos;

namespace payflowdotnet.Services;

public interface ICustomerService
{
  Task<CreateCustomerDTO> Create(CreateCustomerDTO customerDTO);

  Task<CreateCustomerDTO> GetCustomerById(long id);

  Task<List<CreateCustomerDTO>> GetAllCustomers();

  Task<string> DeleteCustomer(long id);

  Task<CreateCustomerDTO> UpdateCustomer(CreateCustomerDTO createCustomerDTO, long id);
}