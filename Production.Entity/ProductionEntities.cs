using System;
using System.Data.Entity;

namespace Production.Entity
{
    public partial class ProductionEntities : DbContext
    {
        public ProductionEntities(string connectionString) : base(connectionString) { }
    }
}
