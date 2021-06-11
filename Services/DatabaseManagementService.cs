using BookManagement.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookManagement.Services
{
    public static class DatabaseManagementService
    {
        public static void MigrationInitialization (IApplicationBuilder app) {
            using (var serviceScop = app.ApplicationServices.CreateScope()) 
            {
                serviceScop.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            }
        }
    }
}