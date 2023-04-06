using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using OrzBili.Contracts.Services;

using OrzBili.Models;

namespace OrzBili.Services;
internal class GetpgcService : IGetpgcService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _httpClient;

    public GetpgcService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _httpClient = _httpClientFactory.CreateClient("OrzClient");
    }

    public async Task<List<Todo>> Testtask()
    {
        var todos = await _httpClient.GetFromJsonAsync<List<Todo>>(
        "todos?userId=1&completed=false");
        return todos;
    }

    public record class Todo(
    int? UserId = null,
    //int? Id = null,
    //string? Title = null,
    bool? Completed = null);


}
