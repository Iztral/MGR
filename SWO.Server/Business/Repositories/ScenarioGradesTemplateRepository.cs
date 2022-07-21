using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class ScenarioGradesTemplateRepository : BaseRepository<ScenarioGradesTemplates>, IScenarioGradesTemplateRepository
    {
        public ScenarioGradesTemplateRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.ScenarioGradesTemplates.Count();
            return count;
        }

        public IEnumerable<ScenarioGradesTemplates> GetAll()
        {
            var records = _context.ScenarioGradesTemplates.ToList();
            return records;
        }

        public ScenarioGradesTemplates GetById(int id)
        {
            var record = _context.ScenarioGradesTemplates.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(ScenarioGradesTemplates record)
        {
            _context.ScenarioGradesTemplates.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(ScenarioGradesTemplates record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            ScenarioGradesTemplates record = new() { Id = recordId };
            _context.ScenarioGradesTemplates.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
