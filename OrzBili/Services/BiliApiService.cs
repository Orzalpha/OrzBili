using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Documents;
using OrzBili.Contracts.Services;
using OrzBili.Models;
using OrzBili.ApiModels;
using OrzBili.ApiModels.AccountModel;
using OrzBili.ApiModels.SpaceInfoModel;
using OrzBili.ApiModels.BangumiListModell;
using OrzBili.Models.BangumiDetailModel;
using OrzBili.ApiModels.BangumiPlayurlModel;

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
        BangumiDetail,
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
        try
        {
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
                case Info.BangumiDetail:
                    {
                        result = await GetBangumiDetailAsync(parameters);
                        break;
                    }
                case Info.BangumiPlayurl:
                    {
                        result = await GetBangumiPlayurlAsync(parameters);
                        break;
                    }
            }
        }catch(Exception) { 

        }

        await Task.CompletedTask;
        return result!;
    }

    private async Task<Account> GetAccountInfoAsync()
    {
        try
        {
            var account = await _httpClient.GetFromJsonAsync<Account>("x/member/web/account");
            return account!;
        }
        catch
        {
            // TODO: to manage exception
        }

        await Task.CompletedTask;
        return null!;
    }

    private async Task<SpaceInfo> GetSpaceInfoAsync(object? parameters)
    {
        if (parameters is ApiParameterModel.SpacePara para)
        {
            try
            {
                var paraString = para.ToKeyValueURL();
                var result = await _httpClient.GetFromJsonAsync<SpaceInfo>("x/space/acc/info?" + paraString);
                return result!;

            }
            finally { }
        }
        else
        {
            throw new Exception("Parameter type wrong!");
        }

    }

    private async Task<BangumiList> GetBangumiListAsync(object? parameters)
    {
        if (parameters is ApiParameterModel.BangumiListPara para)
        {
            try
            {
                var paraString = para.ToKeyValueURL();
                var url = "x/space/bangumi/follow/list?" + paraString;
                var result = await _httpClient.GetFromJsonAsync<BangumiList>(url);
                return result!;

            }
            finally { }
        }
        else
        {
            throw new Exception("Parameter type wrong!");
        }
    }

    private async Task<BangumiDetail> GetBangumiDetailAsync(object? parameters)
    {
        if (parameters is ApiParameterModel.BangumiDetailPara para)
        {
            try
            {
                var paraString = para.ToKeyValueURL();
                var url = "pgc/view/web/season?" + paraString;
                var result = await _httpClient.GetFromJsonAsync<BangumiDetail>(url);
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Cannot get BangumiDetail!");
                }

            }
            finally { }
        }
        else
        {
            throw new Exception("Parameter type wrong!");
        }
    }

    private async Task<BangumiPlayurl> GetBangumiPlayurlAsync(object? parameters)
    {
        if (parameters is ApiParameterModel.BangumiPlayurlPara para)
        {
            try
            {
                var paraString = para.ToKeyValueURL();
                var url = "pgc/player/web/playurl?" + paraString;
                var result = await _httpClient.GetFromJsonAsync<BangumiPlayurl>(url);
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
