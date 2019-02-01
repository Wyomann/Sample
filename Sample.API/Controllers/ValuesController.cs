using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sample.Domain.Abstract;
using Sample.Infrastructure;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace WebApplication2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        private IMessageRepo repo;

        public ValuesController(IMessageRepo repo)
        {
            this.repo = repo;
        }
        
        // GET api/values
        public Task<String> Get()
        {
            return this.repo.GetData();
        }
    }
}
