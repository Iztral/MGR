using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class SimulationService : BaseService<SimulationViewModel, ISimulationRepository>, ISimulationService
    {
        public SimulationService(ISimulationRepository repository) : base(repository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<SimulationViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public SimulationViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(SimulationViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(SimulationViewModel record)
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

        private SimulationViewModel ConvertToViewModel(Simulation record)
        {
            throw new NotImplementedException();
        }

        private Simulation ConvertToModel(SimulationViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<SimulationViewModel> ConvertToViewModelList(IEnumerable<Simulation> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Simulation> ConvertToModelList(IEnumerable<SimulationViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
