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

    public async Task<object> GetInfoAsync(Info info, object? parameters)
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
                    result = await GetSpaceInfoAsync(parameters);
                    break;
                }
            case Info.BangumiList:
                {
                    result = await GetBangumiListAsync(parameters);
                    break;
                }
            case Info.BangumiPlayurl:
                {
                    result = await GetBangumiPlayurlAsync(parameters);
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

    private async Task<SpaceInfoModel.Rootobject> GetSpaceInfoAsync(object? parameters)
    {
        if (parameters is ApiParameterModel.SpacePara para)
        {
            try
            {
                var paraString = para.ToKeyValueURL();
                var result = await _httpClient.GetFromJsonAsync<SpaceInfoModel.Rootobject>("x/space/acc/info?" + paraString);
                return result;

            }
            finally { }
        }
        else
        {
            throw new Exception("Parameter type wrong!");
        }

    }

    private async Task<BangumiListModel.Rootobject> GetBangumiListAsync(object? parameters)
    {
        if (parameters is ApiParameterModel.BangumiListPara para)
        {
            try
            {
                var paraString = para.ToKeyValueURL();
                var url = "x/space/bangumi/follow/list?" + paraString;
                var result = await _httpClient.GetFromJsonAsync<BangumiListModel.Rootobject>(url);
                return result!;

            }
            finally { }
        }
        else
        {
            throw new Exception("Parameter type wrong!");
        }
    }

    private async Task<BangumiPlayurlModel.Rootobject> GetBangumiPlayurlAsync(object? parameters)
    {
        if (parameters is ApiParameterModel.BangumiPlayurlPara para)
        {
            try
            {
                var paraString = para.ToKeyValueURL();
                var url = "pgc/player/web/playurl?" + paraString;
                var result = await _httpClient.GetFromJsonAsync<BangumiPlayurlModel.Rootobject>(url);
                return result!;

            }
            finally { }
        }
        else
        {
            throw new Exception("Parameter type wrong!");
        }
    }
}
