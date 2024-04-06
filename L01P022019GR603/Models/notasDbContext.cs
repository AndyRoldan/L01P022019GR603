using Microsoft.EntityFrameworkCore;
namespace L01P022019GR603.Models
{
    public class notasDbContext: DbContext
    {
        public notasDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
