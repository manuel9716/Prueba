using proyectoef;
using webapi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<TareasContext>("Data Source=MANUELRV\\SQLEXPRESS; Initial Catalog=TareasDb4; user id=sa;password=123456");
//builder.Services.AddScoped<IHelloWorldService, HelloworldServices>();
builder.Services.AddScoped<IHelloWorldService>(p=> new HelloWorldService());//esta inyeccion de despendencias es cuando se quiere pasar algo en especifico
builder.Services.AddScoped<IAlineacionService, AlineacionService>();
builder.Services.AddScoped<IFormulacionService, FormulacionService>();
//builder.Services.AddScoped<IAutenticacionService, AutenticacionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors(); permite poder configurar quien puede utilizar la api 
//Los middlewares personalizados deben de colocarse entre el middleware de **Autorizacion ** y el de endpoints.

app.UseAuthorization();

//app.UseWelcomePage();

//app.UseTimeMiddleware();

app.MapControllers();

app.Run();
