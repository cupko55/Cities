using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cities.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Cities.Api.Controllers
{
    
    [ApiController]
    public class BaseController : ControllerBase
    {
        private IServiceWrapper _serviceWrapper;

        protected IServiceWrapper ServiceWrapper => _serviceWrapper ??
                                                    (_serviceWrapper = HttpContext.RequestServices
                                                        .GetService<IServiceWrapper>());
    }
}