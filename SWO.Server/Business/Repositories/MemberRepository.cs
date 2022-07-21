using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {
        public MemberRepository(ApplicationDbContext context) : base(context)
        {

        }

        public int GetCount()
        {
            var count = _context.Members.Count();
            return count;
        }

        public IEnumerable<Member> GetAll()
        {
            var records = _context.Members.ToList();
            return records;
        }

        public Member GetById(int id)
        {
            var record = _context.Members.Single(x => x.Id == id);
            return record;
        }

        public ResponseMessage Add(Member record)
        {
            _context.Members.Add(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Update(Member record)
        {
            _context.Update(record);
            return SaveAndValidate(record);
        }

        public ResponseMessage Remove(int recordId)
        {
            Member record = new() { Id = recordId };
            _context.Members.Remove(record);

            return SaveAndValidate(record);
        }
    }
}
