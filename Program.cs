
using Microsoft.EntityFrameworkCore;
using payflowdotnet.Data;
using payflowdotnet.Services;

var builder = WebApplication.CreateBuilder(args);

var connString=builder.Configuration.GetSection("ConnectionStrings")["DefaultConnection"];

Console.WriteLine(connString);


builder.Services.AddValidation();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
//That is saying whenever a ICustomerService is required, create a CustomerService and pass that in.
builder.Services.AddScoped<ICustomerService,CustomerService>();
// This passes the configured options to the Payflowcontext constructor and then again to the DbContext constructor to initialize the Database with the configured options
builder.Services.AddDbContext<PayflowContext>(option=>option.UseNpgsql(connectionString:connString).LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information));
var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI();
// Conventional Routing :  uses a predefined route pattern
app.MapControllers();
app.Run();
