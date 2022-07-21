using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class GradeTemplateRepository : BaseRepository<GradeTemplate>, IGradeTemplateRepository
    {
        public GradeTemplateRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.GradeTemplates.Count();
            return count;
        }

        public IEnumerable<GradeTemplate> GetAll()
        {
            var records = _context.GradeTemplates.ToList();
            return records;
        }

        public GradeTemplate GetById(int id)
        {
            var record = _context.GradeTemplates.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(GradeTemplate record)
        {
            _context.GradeTemplates.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(GradeTemplate record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            GradeTemplate record = new() { Id = recordId };
            _context.GradeTemplates.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
