using SWO.Shared.Abstractions.Communication;
using SWO.Shared.Abstractions.Repositories;
using SWO.Shared.Abstractions.Services;
using SWO.Shared.Models;

namespace SWO.Portal.Business.Services
{
    public class LocationService : BaseService<LocationViewModel, ILocationRepository>, ILocationService
    {
        public LocationService(ILocationRepository repository) : base(repository)
        {

        }

        public int GetCount()
        {
            var count = _repository.GetCount();
            return count;
        }

        public IEnumerable<LocationViewModel> GetAll()
        {
            var models = _repository.GetAll();
            var viewModels = ConvertToViewModelList(models);
            return viewModels;
        }

        public LocationViewModel GetById(int id)
        {
            var model = _repository.GetById(id);
            var viewModel = ConvertToViewModel(model);
            return viewModel;
        }

        public ResponseMessage Add(LocationViewModel record)
        {
            var viewModel = ConvertToModel(record);
            var message = _repository.Add(viewModel);
            return message;
        }

        public ResponseMessage Update(LocationViewModel record)
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

        private LocationViewModel ConvertToViewModel(Location record)
        {
            throw new NotImplementedException();
        }

        private Location ConvertToModel(LocationViewModel record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<LocationViewModel> ConvertToViewModelList(IEnumerable<Location> record)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Location> ConvertToModelList(IEnumerable<LocationViewModel> record)
        {
            throw new NotImplementedException();
        }
    }
}
