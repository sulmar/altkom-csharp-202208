using ProcessFile.IServices;
using Altkom.Models;

namespace ProcessFile.Services
{
    internal class XmlItemService : IItemService
    {
        public Item[] Get()
        {
            return GetItems();
        }

        public Item[] GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
