using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class SensorValueRepository : BaseRepository<SensorValue>, ISensorValueRepository
    {
        public SensorValueRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.SensorValues.Count();
            return count;
        }

        public IEnumerable<SensorValue> GetAll()
        {
            var records = _context.SensorValues.ToList();
            return records;
        }

        public SensorValue GetById(int id)
        {
            var record = _context.SensorValues.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(SensorValue record)
        {
            _context.SensorValues.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(SensorValue record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            SensorValue record = new() { Id = recordId };
            _context.SensorValues.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
