using System;

namespace OneToOneRelationships
{
    class Program
    {
        static void Main()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            dbContext.Database.EnsureCreated();
        }
    }
}
