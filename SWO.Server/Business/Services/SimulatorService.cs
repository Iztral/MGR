using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class SimulatorService : BaseService<SimulatorViewModel, ISimulatorRepository>, ISimulatorService
    {
        public SimulatorService(ISimulatorRepository repository) : base(repository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<SimulatorViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public SimulatorViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(SimulatorViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(SimulatorViewModel record)
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

        private SimulatorViewModel ConvertToViewModel(Simulator record)
        {
            throw new NotImplementedException();
        }

        private Simulator ConvertToModel(SimulatorViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<SimulatorViewModel> ConvertToViewModelList(IEnumerable<Simulator> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Simulator> ConvertToModelList(IEnumerable<SimulatorViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
