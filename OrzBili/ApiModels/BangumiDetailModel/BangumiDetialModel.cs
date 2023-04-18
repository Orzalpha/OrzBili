namespace OrzBili.Models.BangumiDetailModel;

public class BangumiDetail
{
    public int? code { get; set; } = default;

    public string? message { get; set; } = default;

    public Result? result { get; set; } = default;
}

public class Result
{
    public string? actors { get; set; } = default;

    public string? cover { get; set; } = default;

    public Episode[]? episodes { get; set; } = default;

    public string? evaluate { get; set; } = default;

    public int? media_id { get; set; } = default;

    public New_Ep? new_ep { get; set; } = default;

    public Rating? rating { get; set; } = default;

    public int? season_id { get; set; } = default;

    public string? season_title { get; set; } = default;

    public string? staff { get; set; } = default;

    public int? total { get; set; } = default;

    public int? type { get; set; } = default;

    public User_Status? user_status { get; set; } = default;
}

public class New_Ep
{
    public string? desc { get; set; } = default;

    public int? id { get; set; } = default;

    public int? is_new { get; set; } = default;

    public string? title { get; set; } = default;
}

public class Rating
{
    public int? count { get; set; } = default;

    public float? score { get; set; } = default;
}


public class User_Status
{
    public int? area_limit { get; set; } = default;

    public int? ban_area_show { get; set; } = default;

    public int? follow { get; set; } = default;

    public int? follow_status { get; set; } = default;

    public int? login { get; set; } = default;

    public int? pay { get; set; } = default;

    public int? pay_pack_paid { get; set; } = default;

    public Progress? progress { get; set; } = default;

    public int? sponsor { get; set; } = default;

    public Vip_Info? vip_info { get; set; } = default;

}

public class Progress
{
    public int? last_ep_id { get; set; } = default;

    public string? last_ep_index { get; set; } = default;

    public int? last_time { get; set; } = default;
}

public class Vip_Info
{
    public int? due_date { get; set; } = default;

    public int? status { get; set; } = default;

    public int? type { get; set; } = default;

}


public class Episode
{
    public int? aid { get; set; } = default;

    public string? bvid { get; set; } = default;

    public int? cid { get; set; } = default;

    public string? cover { get; set; } = default;

    public int? duration { get; set; } = default;
    /// <summary>
    /// 单集epid
    /// </summary>
    public int? id { get; set; } = default;

    public string? long_title { get; set; } = default;

    public int? pub_time { get; set; } = default;

    public int? pv { get; set; } = default;

    public Skip? skip { get; set; } = default;

    public string? title { get; set; } = default;
}


public class Skip
{
    public Ed? ed { get; set; } = default;

    public Op? op { get; set; } = default;
}

public class Ed
{
    public int? end { get; set; } = default;

    public int? start { get; set; } = default;
}

public class Op
{
    public int? end { get; set; } = default;

    public int? start { get; set; } = default;
}