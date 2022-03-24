using Microsoft.EntityFrameworkCore;
using Portafolio_805.Models;

namespace Portafolio_805.DTO
{
    public class ApplicationDB : DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {

        }

        public DbSet<Empleado> empleados { set; get; }

    }
}
