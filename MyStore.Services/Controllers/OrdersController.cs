using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyStore.Services.Controllers
{
    public class OrdersController : ApiController
    {
        private static readonly Dictionary<int, string> Orders = new Dictionary<int, string>();

        public IEnumerable<string> Get()
        {
            return Orders.Values;
        }

        // GET api/orders/5
        public string Get(int id)
        {
            Orders.TryGetValue(id, out var order);

            return order;
        }

        // POST api/orders
        public void Post([FromBody]string value)
        {
            Orders.Add(Orders.Count, value);
        }

        // PUT api/orders/5
        public void Put(int id, [FromBody]string value)
        {
            Orders[id] = value;
        }

        // DELETE api/orders/5
        public void Delete(int id)
        {
            Orders.Remove(id);
        }
    }
}
