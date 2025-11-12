using ApiFuncional.Configuration;

var builder = WebApplication.CreateBuilder(args);


builder                             // Chamando as configs 
        .AddApiConfig()             // pendurando todos os mtds em um só
        .AddCorsConfig()            // obs : todos devem ter o return
        .AddSwaggerConfig()
        .AddDbContextConfig()
        .AddIndetityConfig();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("Development");
}
else
{
    app.UseCors("Production");
}

    app.UseHttpsRedirection();

app.UseAuthentication();   //Sempre em 1

app.UseAuthorization();    //Sempre em 2

app.MapControllers();

app.Run();
