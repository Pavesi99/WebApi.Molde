using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Molde.Domain.Interfaces.Repository;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public void Save();
    }
}
