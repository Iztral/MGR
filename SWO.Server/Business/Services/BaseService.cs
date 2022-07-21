using SWO.Shared.Abstractions.Interfaces;
using SWO.Shared.Abstractions.Models;

namespace SWO.Portal.Business.Services
{
    public class BaseService<T, I> where T : BaseViewModel
    {
        protected readonly I _repository;

        public BaseService(I repository)
        {
            _repository = repository;
        }
    }
}
