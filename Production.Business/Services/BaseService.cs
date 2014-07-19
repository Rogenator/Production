using System;
using Production.Entity;

namespace Production.Business.Services
{
    public abstract class BaseService : IDisposable
    {
        protected readonly ProductionEntities context;

        public BaseService()
        {
            this.context = new ProductionEntities(DataBase.ConnectionString);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                    context.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
