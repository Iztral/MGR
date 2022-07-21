using SWO.Shared.Abstractions.Communication;

namespace SWO.Shared.Abstractions.Interfaces
{
    public interface IRepository<T>
    {
        public int GetCount();

        public IEnumerable<T> GetAll();

        public T GetById(int id);

        public ResponseMessage Add(T record);

        public ResponseMessage Update(T record);

        public ResponseMessage Remove(int recordId);
    }
}
