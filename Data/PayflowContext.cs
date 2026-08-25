using Microsoft.EntityFrameworkCore;
using payflowdotnet.Models;

namespace payflowdotnet.Data;

// Creates a Database Session with the Actual PostgreSQl Database.
// Now we define the entities that we will be dealing with.
public class PayflowContext:DbContext
{

  // Each DbSet will map to a table in the database
  public DbSet<Customer> Customers{get;set;}// Which is a collection of Customer Entities ( Table )

  public PayflowContext(DbContextOptions<PayflowContext> dbContextOptions):base(dbContextOptions)
  {
    
  }




  // Gets automatically converted to backing field syntax :

  /*

    private DbSet<Customer> _customers;

    public DbSet<Customer> Customers // get returns the DbSet<Customer> 
    {
       get { return _customers; }
       set {_customers = value; }
    }

    While creating the object of PayflowContext 

    PayflowContext pc = new PayflowContext(); // Since Payflowcontext is inheriting from DbContext class , additional methods like Add

    pc.Customers = ....
    ...
  */




}