using KIEUTHIHIEN227.Models;
using Microsoft.EntityFrameworkCore;

namespace KIEUTHIHIEN_1408.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {
        }
        
    }
}