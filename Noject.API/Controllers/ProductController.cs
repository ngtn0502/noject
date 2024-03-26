using MediatR;
using Microsoft.AspNetCore.Mvc;
using Noject.Application.Common.RequestModel;
using Noject.Application.WeatherForeCast.Queries;

namespace Noject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly ISender mediator;

        public ProductController(ILogger<ProductController> logger, ISender mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpGet(Name = "GetProduct")]
        public async Task<IEnumerable<Product>> Get()
        {
            var query = new ProductQuery();
            var result = await this.mediator.Send(query);

            return result;
        }

        [HttpPost]
        public async Task<ProductRequestModel> Post([FromBody] ProductRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                return requestModel;
            }
            return requestModel;
        }
    }
}
