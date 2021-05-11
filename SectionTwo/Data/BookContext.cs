using SectionTwo.Models;
using Microsoft.EntityFrameworkCore;

namespace SectionTwo.Data
{
    public class BookContext :DbContext
    {

        public BookContext(DbContextOptions options) :base(options){
        
        }
        public DbSet<Book> Books {get;set;}
    }
    
}