using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Molde.Domain.Interfaces.Repository;
using WebApi.Molde.Domain.Interfaces.UnitOfWork;
using WebApi.Molde.Domain.Models;
using WebApi.Molde.Infra.Context;
using WebApi.Molde.Infra.Repository;

namespace WebApi.Molde.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WeatherForecastContext _context;

        public UnitOfWork(WeatherForecastContext context)
        {
            _context = context;
        }
       
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
