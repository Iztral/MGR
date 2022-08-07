using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class ScenarioService : BaseService<ScenarioViewModel, IScenarioRepository>, IScenarioService
    {
        public ScenarioService(IScenarioRepository repository) : base(repository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<ScenarioViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public ScenarioViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(ScenarioViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(ScenarioViewModel record)
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

        private ScenarioViewModel ConvertToViewModel(Scenario record)
        {
            throw new NotImplementedException();
        }

        private Scenario ConvertToModel(ScenarioViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<ScenarioViewModel> ConvertToViewModelList(IEnumerable<Scenario> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Scenario> ConvertToModelList(IEnumerable<ScenarioViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
