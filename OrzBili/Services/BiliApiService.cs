using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrzBili.Contracts.Services;

namespace OrzBili.Services;

public class BiliApiService : IBiliApiService
{
    private readonly HttpClient _httpClient;

    public BiliApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
