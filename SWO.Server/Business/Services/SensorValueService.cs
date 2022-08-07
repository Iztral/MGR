using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class SensorValueService : BaseService<SensorValueViewModel, ISensorValueRepository>, ISensorValueService
    {
        public SensorValueService(ISensorValueRepository repository) : base(repository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<SensorValueViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public SensorValueViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(SensorValueViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(SensorValueViewModel record)
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

        private SensorValueViewModel ConvertToViewModel(SensorValue record)
        {
            throw new NotImplementedException();
        }

        private SensorValue ConvertToModel(SensorValueViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<SensorValueViewModel> ConvertToViewModelList(IEnumerable<SensorValue> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<SensorValue> ConvertToModelList(IEnumerable<SensorValueViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
