using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Amazon.Models
{
    public class EFBookRepository : IBookRepository
    {
        private ApplicationDbContext context;
        public EFBookRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
