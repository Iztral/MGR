using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class ScenarioRepository : BaseRepository<Scenario>, IScenarioRepository
    {
        public ScenarioRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.Scenarios.Count();
            return count;
        }

        public IEnumerable<Scenario> GetAll()
        {
            var records = _context.Scenarios.ToList();
            return records;
        }

        public Scenario GetById(int id)
        {
            var grade = _context.Scenarios.Single(x => x.Id == id);
            return grade;
        }

        public ResponseMessage Add(Scenario record)
        {
            _context.Scenarios.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(Scenario record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            Scenario record = new() { Id = recordId };
            _context.Scenarios.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
