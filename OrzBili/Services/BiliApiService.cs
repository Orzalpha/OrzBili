using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using OrzBili.Contracts.Services;
using OrzBili.Models;

namespace OrzBili.Services;

public class BiliApiService : IBiliApiService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _httpClient;

    public enum Info
    {
        Account,
        Space,
        BangumiList,
        BangumiPlayurl
    };

    public void SetCookie(string cookie)
    {
        _httpClient.DefaultRequestHeaders.Add("Cookie", cookie);
    }

    public BiliApiService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _httpClient = _httpClientFactory.CreateClient("ApiClient");
        
    }

    public async Task<object> GetInfoAsync(Info info)
    {
        object? result = null;
        switch (info)
        {
            case Info.Account:
                {
                    result = await GetAccountInfoAsync();
                    break;
                }
            case Info.Space:
                {
                    result = await GetSpaceInfoAsync();
                    break;
                }
            case Info.BangumiList:
                {
                    result = await GetBangumiListAsync();
                    break;
                }
            case Info.BangumiPlayurl:
                {
                    result = await GetBangumiPlayurlAsync();
                    break;
                }

        }

        await Task.CompletedTask;
        if (result == null)
        {
            throw new Exception("BiliService return null!");
        }
        return result;
    }

    private async Task<AccountModel.Rootobject> GetAccountInfoAsync()
    {
        try
        {
            var account = await _httpClient.GetFromJsonAsync<AccountModel.Rootobject>("x/member/web/account");
            return account!;
        }
        catch
        {
            // TODO: to manage exception
        }

        await Task.CompletedTask;
        return null!;
    }

    private async Task<SpaceInfoModel.Rootobject> GetSpaceInfoAsync()
    {
        try
        {
            var space = await _httpClient.GetFromJsonAsync<SpaceInfoModel.Rootobject>("x/member/web/account");
            return space!;
        }
        catch
        {
            // TODO: to manage exception
        }

        await Task.CompletedTask;
        return null!;
    }

    private async Task<BangumiListModel.Rootobject> GetBangumiListAsync()
    {
        try
        {
            var bangumiList = await _httpClient.GetFromJsonAsync<BangumiListModel.Rootobject>("x/member/web/account");
            return bangumiList!;
        }
        catch
        {
            // TODO: to manage exception
        }

        await Task.CompletedTask;
        return null!;
    }

    private async Task<BangumiPlayurlModel.Rootobject> GetBangumiPlayurlAsync()
    {
        try
        {
            var bangumiPlayurl = await _httpClient.GetFromJsonAsync<BangumiPlayurlModel.Rootobject>("x/member/web/account");
            return bangumiPlayurl!;
        }
        catch
        {
            // TODO: to manage exception
        }

        await Task.CompletedTask;
        return null!;
    }
}
