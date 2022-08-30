using ProcessFile.IServices;
using Altkom.Models;

namespace ProcessFile.Services
{
    public class DbItemService : IItemService
    {
        // snippet: ctor + 2 x Tab

        string connectionString;

        public DbItemService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Item[] Get()
        {
            throw new NotImplementedException();

            // TODO: SQL select * from dbo.Items
        }
    }
}
