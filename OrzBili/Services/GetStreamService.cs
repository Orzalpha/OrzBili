using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrzBili.Contracts.Services;
using OrzBili.Models;

namespace OrzBili.Services;


public class GetStreamService : IGetStreamService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public GetStreamService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
}
