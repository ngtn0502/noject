﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Noject.Application.WeatherForeCast.Queries
{
    public class ProductQuery : IRequest<IEnumerable<Product>>
    {
    }
}
