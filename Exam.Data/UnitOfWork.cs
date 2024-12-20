using Exam.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ExamContext context;

        public UnitOfWork(ExamContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
