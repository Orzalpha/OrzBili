namespace OrzBili.ApiModels.AccountModel;

/// <summary>
/// 个人中心 - 获取我的基本信息
/// </summary>
public class Account
{
    public int? code { get; set; } = null;

    public string? message { get; set; } = null;

    public Data? data { get; set; } = null;
}

public class Data
{
    public long? mid { get; set; } = null;

    public string? uname { get; set; } = null;

    public string? userid { get; set; } = null;

    public string? sign { get; set; } = null;

    public string? birthday { get; set; } = null;

    public string? sex { get; set; } = null;
}

