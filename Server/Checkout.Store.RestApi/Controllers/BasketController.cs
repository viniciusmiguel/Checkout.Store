using System;
using Microsoft.AspNetCore.Mvc;

namespace Checkout.Store.RestApi.Controllers
{
    /// <summary>
    /// Store Basket REST Controller
    /// </summary>
    [Route("api/[controller]")]
    public class BasketController : Controller
    {
        /// <summary>
        /// Without a basket UUID assume that is the first access and generate a new basket
        /// </summary>
        /// <returns>A new empty basket</returns>
        // GET api/basket
        [HttpGet]
        public string GetBasket()
        {
            return "basket";
        }
        /// <summary>
        /// Return a preexisting basket
        /// </summary>
        /// <param name="id">The basket UUID</param>
        /// <returns>A basket with previous content</returns>
        // GET api/basket/UUID
        [HttpGet("{id:Guid}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // PUT api/basket/UUID
        [HttpPut("{id:Guid}")]
        public void Put(Guid id, [FromBody]string value)
        {
        }
        // DELETE api/values/UUID
        [HttpDelete("{id:Guid}")]
        public void Delete(Guid id)
        {
        }
        // DELETE api/values/UUID/UUID
        [HttpDelete("{id:Guid, productId:Guid}")]
        public void Delete(Guid id, Guid productId)
        {
        }
    }
}
