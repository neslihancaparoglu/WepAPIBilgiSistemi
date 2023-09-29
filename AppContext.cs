using Microsoft.EntityFrameworkCore;
using Uygulama1.Models;

namespace Uygulama1
{
    public class AppContext: DbContext
    {
        public AppContext(DbContextOptions options ) :base(options) 
        {
            
        }
        
        public DbSet<Student> Students { get; set; } // Dbset nesnesi veritabanını tablosunu temsil eder.Bunu silersek erişim sağlayamaz.(_context.Student yapamayaız gelmez)
        protected override void OnModelCreating(ModelBuilder modelBuilder) // modelimizi oluşturuyor. Relationship'ı burda yapılır.
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
