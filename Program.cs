using Microsoft.EntityFrameworkCore;
using payflowdotnet.Data;
using payflowdotnet.Services;

namespace payflowdotnet;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connString=builder.Configuration.GetSection("ConnectionStrings")["DatabaseConnectionString"];

        Console.WriteLine($"The connection string is {connString} !\n");

        builder.Services.AddValidation();
        builder.Services.AddSwaggerGen();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddControllers();
        //That is saying whenever a ICustomerService is required, create a CustomerService and pass that in.
        builder.Services.AddScoped<ICustomerService,CustomerService>();
        // This passes the configured options to the Payflowcontext constructor and then again to the DbContext constructor to initialize the Database with the configured options
        builder.Services.AddDbContext<PayflowContext>(option=>option.UseNpgsql(connectionString:connString).LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information));
        var app = builder.Build();

        // Only redirect HTTPS outside of Docker/container environments
        if (!app.Environment.IsDevelopment())
        {
            app.UseHttpsRedirection();
        }

        using (var scope=app.Services.CreateScope())
        {
            var context=scope.ServiceProvider.GetRequiredService<PayflowContext>(); // Getting the Bean out of the container
        
            await context.Database.MigrateAsync();
        }

        

        app.UseAuthorization();
        app.UseSwagger();
        app.UseSwaggerUI();
        // Conventional Routing :  uses a predefined route pattern
        app.MapControllers();
        app.Run();
             
    }
}


