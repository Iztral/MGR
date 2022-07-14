using SWO.Shared.Abstractions.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWO.Shared.Abstractions.Interfaces
{
    public interface IService<T>
    {
        public int GetCount();

        public IEnumerable<T> GetAll();

        public T Get(T record);

        public T GetById(int id);

        public ResponseMessage Add(T record);

        public ResponseMessage Update(T record);

        public ResponseMessage Remove(int recordId);
    }
}
