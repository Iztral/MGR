using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class MemberService : BaseService<MemberViewModel, IMemberRepository>, IMemberService
    {
        public MemberService(IMemberRepository repository) : base(repository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<MemberViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public MemberViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(MemberViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(MemberViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Update(viewModel);
            return message;
        }

        public ResponseMessage Remove(int recordId)
        {
            var message = _repository.Remove(recordId);
            return message;
        }

        private MemberViewModel ConvertToViewModel(Member record)
        {
            throw new NotImplementedException();
        }

        private Member ConvertToModel(MemberViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<MemberViewModel> ConvertToViewModelList(IEnumerable<Member> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Member> ConvertToModelList(IEnumerable<MemberViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
