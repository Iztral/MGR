using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class GradeTemplateService : BaseService<GradeTemplateViewModel, IGradeTemplateRepository>, IGradeTemplateService
    {
        public GradeTemplateService(IGradeTemplateRepository gradeTemplateRepository) : base(gradeTemplateRepository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<GradeTemplateViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public GradeTemplateViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(GradeTemplateViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(GradeTemplateViewModel record)
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

        private GradeTemplateViewModel ConvertToViewModel(GradeTemplate record)
        {
            throw new NotImplementedException();
        }

        private GradeTemplate ConvertToModel(GradeTemplateViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<GradeTemplateViewModel> ConvertToViewModelList(IEnumerable<GradeTemplate> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<GradeTemplate> ConvertToModelList(IEnumerable<GradeTemplateViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
