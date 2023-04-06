using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrzBili.Services;

public class UniversalNetService
{
    private readonly HttpClient _httpClient;

    public UniversalNetService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
