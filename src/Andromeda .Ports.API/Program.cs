using Andromeda.Adapters.DAL.SQLContext;
using Andromeda.Adapters.IoC.DALNativeInjector;
using Andromeda.Adapters.IoC.DomainNativeInjector;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterDALServices(builder.Configuration);
builder.Services.RegisterDomainServices(builder.Configuration);

builder.Services.AddSingleton<ISQLConnectionFactory, SQLConnectionFactory>
    (services => new SQLConnectionFactory(@"Server=localhost,1433;Initial Catalog=AndromedaDB;Persist Security Info=True;User Id=sa;Password=adminSenha123#"));

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
