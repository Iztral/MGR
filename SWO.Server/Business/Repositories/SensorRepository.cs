using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class SensorRepository : BaseRepository<Sensor>, ISensorRepository
    {
        public SensorRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.Sensors.Count();
            return count;
        }

        public IEnumerable<Sensor> GetAll()
        {
            var records = _context.Sensors.ToList();
            return records;
        }

        public Sensor GetById(int id)
        {
            var record = _context.Sensors.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(Sensor record)
        {
            _context.Sensors.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(Sensor record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            Sensor record = new() { Id = recordId };
            _context.Sensors.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
