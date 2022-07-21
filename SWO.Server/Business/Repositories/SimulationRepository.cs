using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class SimulationRepository : BaseRepository<Simulation>, ISimulationRepository
    {
        public SimulationRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.Simulations.Count();
            return count;
        }

        public IEnumerable<Simulation> GetAll()
        {
            var records = _context.Simulations.ToList();
            return records;
        }

        public Simulation GetById(int id)
        {
            var record = _context.Simulations.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(Simulation record)
        {
            _context.Simulations.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(Simulation record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            Simulation record = new() { Id = recordId };
            _context.Simulations.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
