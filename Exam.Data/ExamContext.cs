using Microsoft.EntityFrameworkCore;

namespace Exam.Data
{
    public class ExamContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog = BDD 
                                        Integrated Security = true");
        }

    }
}