using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class SensorService : BaseService<SensorViewModel, ISensorRepository>, ISensorService
    {
        public SensorService(ISensorRepository repository) : base(repository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<SensorViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public SensorViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(SensorViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(SensorViewModel record)
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

        private SensorViewModel ConvertToViewModel(Sensor record)
        {
            throw new NotImplementedException();
        }

        private Sensor ConvertToModel(SensorViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<SensorViewModel> ConvertToViewModelList(IEnumerable<Sensor> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Sensor> ConvertToModelList(IEnumerable<SensorViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
