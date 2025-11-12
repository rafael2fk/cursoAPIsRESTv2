namespace ApiFuncional.Configuration
{
    public static class CorsConfig         //organização CORS
    {
        public static WebApplicationBuilder AddCorsConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options =>               //add cors com poli
            {
                options.AddPolicy("Development", builder =>
                             builder
                                 .AllowAnyOrigin()            // não importa de onde vem o request, vai aceitar
                                 .AllowAnyMethod()            // qualquer verbo http vai aceita
                                 .AllowAnyHeader());          // não importa o header na requisição vai aceitar

                options.AddPolicy("Production", builder =>
                             builder
                                  .WithOrigins("https://localhost:900")      //aceitando requisições somente do localhost passado
                                  .WithMethods("POST")                       // apenas do mtdo PSOT
                                  .AllowAnyHeader());                        // qualquer uma
            });

            return builder;
        }
    }
}
