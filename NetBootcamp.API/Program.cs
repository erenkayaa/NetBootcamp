using NetBootcamp.API.Users;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.


// DI(Dependency Injection) Container framework
// IoC ( Inversion Of Container)  framework
//  - Dependency Inversion / Inversion Of Control Principles
//  - Dependency Injection Design Pattern


// 1. AddSingleton
// 2. AddScoped (*)
// 3. AddTransient

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();