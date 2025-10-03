using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
    }
}
