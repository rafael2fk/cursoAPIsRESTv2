using ApiFuncional.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncional.Configuration
{
    public static class DbContextConfig        // organização DbContext
    {      
        public static WebApplicationBuilder AddDbContextConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApiDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            return builder;
        }
    }
}
