using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.Locations.Count();
            return count;
        }

        public IEnumerable<Location> GetAll()
        {
            var records = _context.Locations.ToList();
            return records;
        }

        public Location GetById(int id)
        {
            var record = _context.Locations.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(Location record)
        {
            _context.Locations.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(Location record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            Location record = new() { Id = recordId };
            _context.Locations.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
