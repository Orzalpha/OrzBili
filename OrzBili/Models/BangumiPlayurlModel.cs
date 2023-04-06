namespace OrzBili.Models;

/// <summary>
/// 番剧取流
/// </summary>
public record class BangumiPlayurlModel
{

    public class Rootobject
    {
        public int? code
        {
            get; set;
        }
        public string? message
        {
            get; set;
        }
        public Result? result
        {
            get; set;
        }
    }

    public class Result
    {
        public string? accept_format
        {
            get; set;
        }
        public int? code
        {
            get; set;
        }
        public string? seek_param
        {
            get; set;
        }
        public int? is_preview
        {
            get; set;
        }
        public int? fnval
        {
            get; set;
        }
        public bool video_project
        {
            get; set;
        }
        public int? fnver
        {
            get; set;
        }
        public string? type
        {
            get; set;
        }
        public int? bp
        {
            get; set;
        }
        public string? result
        {
            get; set;
        }
        public string? seek_type
        {
            get; set;
        }
        public int? vip_type
        {
            get; set;
        }
        public string? from
        {
            get; set;
        }
        public int? video_codecid
        {
            get; set;
        }
        public Record_Info? record_info
        {
            get; set;
        }
        public bool is_drm
        {
            get; set;
        }
        public int? no_rexcode
        {
            get; set;
        }
        public string? format
        {
            get; set;
        }
        public Support_Formats[]? support_formats
        {
            get; set;
        }
        public string? message
        {
            get; set;
        }
        public int[]? accept_quality
        {
            get; set;
        }
        public int? quality
        {
            get; set;
        }
        public int? timelength
        {
            get; set;
        }
        public bool has_paid
        {
            get; set;
        }
        public int? vip_status
        {
            get; set;
        }
        public Dash? dash
        {
            get; set;
        }
        public Clip_Info_List[]? clip_info_list
        {
            get; set;
        }
        public string[]? accept_description
        {
            get; set;
        }
        public int? status
        {
            get; set;
        }
    }

    public class Record_Info
    {
        public string? record_icon
        {
            get; set;
        }
        public string? record
        {
            get; set;
        }
    }

    public class Dash
    {
        public int? duration
        {
            get; set;
        }
        public float? minBufferTime
        {
            get; set;
        }
        public float? min_buffer_time
        {
            get; set;
        }
        public Video[]? video
        {
            get; set;
        }
        public Audio[]? audio
        {
            get; set;
        }
        public Dolby? dolby
        {
            get; set;
        }
    }

    public class Dolby
    {
        public object[]? audio
        {
            get; set;
        }
        public int? type
        {
            get; set;
        }
    }

    public class Video
    {
        public int? start_with_sap
        {
            get; set;
        }
        public int? bandwidth
        {
            get; set;
        }
        public string? sar
        {
            get; set;
        }
        public string[]? backupUrl
        {
            get; set;
        }
        public string? codecs
        {
            get; set;
        }
        public string? base_url
        {
            get; set;
        }
        public string[]? backup_url
        {
            get; set;
        }
        public Segment_Base? segment_base
        {
            get; set;
        }
        public string? mimeType
        {
            get; set;
        }
        public string? frame_rate
        {
            get; set;
        }
        public Segmentbase? SegmentBase
        {
            get; set;
        }
        public string? frameRate
        {
            get; set;
        }
        public int? codecid
        {
            get; set;
        }
        public string? baseUrl
        {
            get; set;
        }
        public int? size
        {
            get; set;
        }
        public string? mime_type
        {
            get; set;
        }
        public int? width
        {
            get; set;
        }
        public int? startWithSAP
        {
            get; set;
        }
        public int? id
        {
            get; set;
        }
        public int? height
        {
            get; set;
        }
        public string? md5
        {
            get; set;
        }
    }

    public class Segment_Base
    {
        public string? initialization
        {
            get; set;
        }
        public string? index_range
        {
            get; set;
        }
    }

    public class Segmentbase
    {
        public string? Initialization
        {
            get; set;
        }
        public string? indexRange
        {
            get; set;
        }
    }

    public class Audio
    {
        public int? start_with_sap
        {
            get; set;
        }
        public int? bandwidth
        {
            get; set;
        }
        public string? sar
        {
            get; set;
        }
        public string[]? backupUrl
        {
            get; set;
        }
        public string? codecs
        {
            get; set;
        }
        public string? base_url
        {
            get; set;
        }
        public string[]? backup_url
        {
            get; set;
        }
        public Segment_Base1? segment_base
        {
            get; set;
        }
        public string? mimeType
        {
            get; set;
        }
        public string? frame_rate
        {
            get; set;
        }
        public Segmentbase1? SegmentBase
        {
            get; set;
        }
        public string? frameRate
        {
            get; set;
        }
        public int? codecid
        {
            get; set;
        }
        public string? baseUrl
        {
            get; set;
        }
        public int? size
        {
            get; set;
        }
        public string? mime_type
        {
            get; set;
        }
        public int? width
        {
            get; set;
        }
        public int? startWithSAP
        {
            get; set;
        }
        public int? id
        {
            get; set;
        }
        public int? height
        {
            get; set;
        }
        public string? md5
        {
            get; set;
        }
    }

    public class Segment_Base1
    {
        public string? initialization
        {
            get; set;
        }
        public string? index_range
        {
            get; set;
        }
    }

    public class Segmentbase1
    {
        public string? Initialization
        {
            get; set;
        }
        public string? indexRange
        {
            get; set;
        }
    }

    public class Support_Formats
    {
        public string? display_desc
        {
            get; set;
        }
        public string? superscript
        {
            get; set;
        }
        public bool need_login
        {
            get; set;
        }
        public string[]? codecs
        {
            get; set;
        }
        public string? format
        {
            get; set;
        }
        public string? description
        {
            get; set;
        }
        public bool need_vip
        {
            get; set;
        }
        public int? quality
        {
            get; set;
        }
        public string? new_description
        {
            get; set;
        }
    }

    public class Clip_Info_List
    {
        public int? materialNo
        {
            get; set;
        }
        public int? start
        {
            get; set;
        }
        public int? end
        {
            get; set;
        }
        public string? toastText
        {
            get; set;
        }
        public string? clipType
        {
            get; set;
        }
    }

}
