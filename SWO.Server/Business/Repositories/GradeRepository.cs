using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class GradeRepository : BaseRepository<Grade>,IGradeRepository
    {
        public GradeRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.Grades.Count();
            return count;
        }

        public IEnumerable<Grade> GetAll()
        {
            var records = _context.Grades.ToList();
            return records;
        }

        public Grade GetById(int id)
        {
            var record = _context.Grades.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(Grade record)
        {
            _context.Grades.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(Grade record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            Grade record = new() { Id = recordId };
            _context.Grades.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
