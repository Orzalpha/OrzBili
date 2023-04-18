namespace OrzBili.ApiModels.BangumiListModell;

/// <summary>
/// 查询用户追番（追剧）明细
/// </summary>

public class BangumiList
{
    public int? code { get; set; } = default;

    public string? message { get; set; } = default;

    public int? ttl { get; set; } = default;

    public Data? data { get; set; } = default;
}

public class Data
{
    public BangumiListItem[]? list { get; set; } = default;

    public int? pn { get; set; } = default;

    public int? ps { get; set; } = default;

    public int? total { get; set; } = default;
}

public class BangumiListItem
{
    public int? season_id { get; set; } = default;

    public int? media_id { get; set; } = default;

    public string? title { get; set; } = default;

    public string? cover { get; set; } = default;
    /// <summary>
    /// 总话数
    /// </summary>
    public int? total_count { get; set; } = default;

    public string? square_cover { get; set; } = default;

    public string? evaluate { get; set; } = default;
    /// <summary>
    /// 第一话的 epid
    /// </summary>
    public int? first_ep { get; set; } = default;

    /// <summary>
    /// 当前话数
    /// </summary>
    public int? formal_ep_count { get; set; } = default;

    public string? summary { get; set; } = default;

    public int? follow_status { get; set; } = default;

    public string? progress { get; set; } = default;
}

