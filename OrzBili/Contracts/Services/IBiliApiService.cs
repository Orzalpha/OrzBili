using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrzBili.Models;

using static OrzBili.Services.BiliApiService;

namespace OrzBili.Contracts.Services;

/// <summary>
/// 用于一般的网络请求
/// </summary>
public interface IBiliApiService
{
    public void SetCookie(string cookie);
    public Task<object> GetInfoAsync(Info info);
}
