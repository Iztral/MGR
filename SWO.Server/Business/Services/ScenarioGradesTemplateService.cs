using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class ScenarioGradesTemplateService : BaseService<ScenarioGradesTemplatesViewModel, IScenarioGradesTemplateRepository>, IScenarioGradesTemplateService
    {
        public ScenarioGradesTemplateService(IScenarioGradesTemplateRepository repository) : base(repository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<ScenarioGradesTemplatesViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public ScenarioGradesTemplatesViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(ScenarioGradesTemplatesViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(ScenarioGradesTemplatesViewModel record)
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

        private ScenarioGradesTemplatesViewModel ConvertToViewModel(ScenarioGradesTemplates record)
        {
            throw new NotImplementedException();
        }

        private ScenarioGradesTemplates ConvertToModel(ScenarioGradesTemplatesViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<ScenarioGradesTemplatesViewModel> ConvertToViewModelList(IEnumerable<ScenarioGradesTemplates> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<ScenarioGradesTemplates> ConvertToModelList(IEnumerable<ScenarioGradesTemplatesViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
