using SWO.Portal.Data;
using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        protected ResponseMessage SaveAndValidate(T record)
        {
            try
            {
                _context.SaveChanges();

                return new ResponseMessage
                {
                    Successful = true,
                    AffectedId = record.Id
                };
            }
            catch (Exception ex)
            {
                return new ResponseMessage
                {
                    Successful = false,
                    Error = ex.Message
                };
            };
        }
    }
}
