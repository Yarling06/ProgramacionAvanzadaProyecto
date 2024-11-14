using Microsoft.EntityFrameworkCore;

namespace ProgramacionAvanzadaProyecto.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        //ACA IRÁ EL CONTEXTO
    }
}
