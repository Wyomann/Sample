using System;
using System.Threading.Tasks;

namespace Sample.Domain.Abstract
{
    public interface IMessageRepo
    {
        Task<String> GetData();
    }
}
