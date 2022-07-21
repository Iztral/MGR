using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class GradeService : BaseService<GradeViewModel, IGradeRepository>, IGradeService
    {
        public GradeService(IGradeRepository gradeRepository) : base(gradeRepository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<GradeViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public GradeViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(GradeViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(GradeViewModel record)
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

        private GradeViewModel ConvertToViewModel(Grade record)
        {
            throw new NotImplementedException();
        }

        private Grade ConvertToModel(GradeViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<GradeViewModel> ConvertToViewModelList(IEnumerable<Grade> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Grade> ConvertToModelList(IEnumerable<GradeViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
