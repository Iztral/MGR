using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class SimulatorRepository : BaseRepository<Simulator>, ISimulatorRepository
    {
        public SimulatorRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.Locations.Count();
            return count;
        }

        public IEnumerable<Simulator> GetAll()
        {
            var records = _context.Simulators.ToList();
            return records;
        }

        public Simulator GetById(int id)
        {
            var record = _context.Simulators.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(Simulator record)
        {
            _context.Simulators.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(Simulator record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            Simulator record = new() { Id = recordId };
            _context.Simulators.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
