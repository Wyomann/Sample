using System;
using System.Threading.Tasks;
using Sample.Domain.Entities;

using Sample.Domain.Abstract;

namespace Sample.Infrastructure
{
    public class MessageRepo : IMessageRepo
    {
        public async Task<String> GetData()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            HelloWorld m = new HelloWorld();
            return m.GetText();
        }
    }
}
