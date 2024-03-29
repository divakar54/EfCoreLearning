using EfCoreLearning;
using EfCoreLearning.Configurations;
using EfCoreLearning.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
    
builder.Services.AddControllers(options =>
{
    options.AllowEmptyInputInBodyModelBinding = true;
    options.Filters.Add(new EmptyBodyFilter());
    options.Filters.Add(new AllowEmptyJsonBodyAttribute());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<EmptyBodyFilter>();
builder.Services.AddDbContext<EfCoreDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("constring")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
