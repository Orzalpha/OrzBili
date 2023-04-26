namespace OrzBili.ApiModels.BangumiPlayurlModel;

/// <summary>
/// 番剧取流
/// </summary>
public class BangumiPlayurl
{
    public int? code { get; set; } = default;

    public string? message { get; set; } = default;

    public Result? result { get; set; } = default;
}

public class Result
{
    public string? accept_format { get; set; } = default;

    public string? type { get; set; } = default;

    public int? video_codecid { get; set; } = default;

    public string? format { get; set; } = default;

    public Support_Formats[]? support_formats { get; set; } = default;

    public int[]? accept_quality { get; set; } = default;

    public int? quality { get; set; } = default;

    public int? timelength { get; set; } = default;

    public Dash? dash { get; set; } = default;

    public string[]? accept_description { get; set; } = default;
}


public class Dash
{
    public int? duration { get; set; } = default;

    public float? minBufferTime { get; set; } = default;

    public float? min_buffer_time { get; set; } = default;

    public Video[]? video { get; set; } = default;

    public Audio[]? audio { get; set; } = default;

    public Dolby? dolby { get; set; } = default;
}

public class Dolby
{
    public object[]? audio { get; set; } = default;

    public int? type { get; set; } = default;
}

public class Video
{
    public int? start_with_sap { get; set; } = default;

    public int? bandwidth { get; set; } = default;

    public string? sar { get; set; } = default;

    public string[]? backupUrl { get; set; } = default;

    public string? codecs { get; set; } = default;

    public string? base_url { get; set; } = default;

    public string[]? backup_url { get; set; } = default;

    public Segment_Base? segment_base { get; set; } = default;

    public string? mimeType { get; set; } = default;

    public string? frame_rate { get; set; } = default;

    public Segmentbase? SegmentBase { get; set; } = default;

    public string? frameRate { get; set; } = default;

    public int? codecid { get; set; } = default;

    public string? baseUrl { get; set; } = default;

    public int? size { get; set; } = default;

    public string? mime_type { get; set; } = default;

    public int? width { get; set; } = default;

    public int? startWithSAP { get; set; } = default;

    public int? id { get; set; } = default;

    public int? height { get; set; } = default;

    public string? md5 { get; set; } = default;
}

public class Segment_Base
{
    public string? initialization { get; set; } = default;

    public string? index_range { get; set; } = default;
}

public class Segmentbase
{
    public string? Initialization { get; set; } = default;

    public string? indexRange { get; set; } = default;
}

public class Audio
{
    public int? start_with_sap { get; set; } = default;

    public int? bandwidth { get; set; } = default;

    public string? sar { get; set; } = default;

    public string[]? backupUrl { get; set; } = default;

    public string? codecs { get; set; } = default;

    public string? base_url { get; set; } = default;

    public string[]? backup_url { get; set; } = default;

    public Segment_Base1? segment_base { get; set; } = default;

    public string? mimeType { get; set; } = default;

    public string? frame_rate { get; set; } = default;

    public Segmentbase1? SegmentBase { get; set; } = default;

    public string? frameRate { get; set; } = default;

    public int? codecid { get; set; } = default;

    public string? baseUrl { get; set; } = default;

    public int? size { get; set; } = default;

    public string? mime_type { get; set; } = default;

    public int? width { get; set; } = default;

    public int? startWithSAP { get; set; } = default;

    public int? id { get; set; } = default;

    public int? height { get; set; } = default;

    public string? md5 { get; set; } = default;

}

public class Segment_Base1
{
    public string? initialization { get; set; } = default;

    public string? index_range { get; set; } = default;
}

public class Segmentbase1
{
    public string? Initialization { get; set; } = default;

    public string? indexRange { get; set; } = default;
}

public class Support_Formats
{
    public string? display_desc { get; set; } = default;

    public string? superscript { get; set; } = default;

    public bool? need_login { get; set; } = default;

    public string[]? codecs { get; set; } = default;

    public string? format { get; set; } = default;

    public string? description { get; set; } = default;

    public bool? need_vip { get; set; } = default;

    public int? quality { get; set; } = default;

    public string? new_description { get; set; } = default;
}