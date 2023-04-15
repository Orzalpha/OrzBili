namespace OrzBili.Models;

/// <summary>
/// 查询用户追番（追剧）明细
/// </summary>
public record class BangumiListModel
{
    public class Rootobject
    {
        public int? code { get; set; } = null;
        public string? message { get; set; } = null;
        public int? ttl { get; set; } = null;
        public Data? data { get; set; } = null;
    }

    public class Data
    {
        public List[]? list
        {
            get; set;
        }
        public int? pn
        {
            get; set;
        }
        public int? ps
        {
            get; set;
        }
        public int? total
        {
            get; set;
        }
    }

    public class List
    {
        public int? season_id
        {
            get; set;
        }
        public int? media_id
        {
            get; set;
        }
        public int? season_type
        {
            get; set;
        }
        public string? season_type_name
        {
            get; set;
        }
        public string? title
        {
            get; set;
        }
        public string? cover
        {
            get; set;
        }
        public int? total_count
        {
            get; set;
        }
        public int? is_finish
        {
            get; set;
        }
        public int? is_started
        {
            get; set;
        }
        public int? is_play
        {
            get; set;
        }
        public string? badge
        {
            get; set;
        }
        public int? badge_type
        {
            get; set;
        }
        public Rights? rights
        {
            get; set;
        }
        public Stat? stat
        {
            get; set;
        }
        public New_Ep? new_ep
        {
            get; set;
        }
        public string? square_cover
        {
            get; set;
        }
        public int? season_status
        {
            get; set;
        }
        public string? season_title
        {
            get; set;
        }
        public string? badge_ep
        {
            get; set;
        }
        public int? media_attr
        {
            get; set;
        }
        public int? season_attr
        {
            get; set;
        }
        public string? evaluate
        {
            get; set;
        }
        public string? subtitle
        {
            get; set;
        }
        public int? first_ep
        {
            get; set;
        }
        public int? can_watch
        {
            get; set;
        }
        public Series? series
        {
            get; set;
        }
        public Publish? publish
        {
            get; set;
        }
        public int? mode
        {
            get; set;
        }
        public Section[]? section
        {
            get; set;
        }
        public string? url
        {
            get; set;
        }
        public Badge_Info? badge_info
        {
            get; set;
        }
        public First_Ep_Info? first_ep_info
        {
            get; set;
        }
        public int? formal_ep_count
        {
            get; set;
        }
        public string? short_url
        {
            get; set;
        }
        public Badge_Infos? badge_infos
        {
            get; set;
        }
        public string? season_version
        {
            get; set;
        }
        public string? horizontal_cover_16_9
        {
            get; set;
        }
        public string? horizontal_cover_16_10
        {
            get; set;
        }
        public string? subtitle_14
        {
            get; set;
        }
        public int? viewable_crowd_type
        {
            get; set;
        }
        public Producer[]? producers
        {
            get; set;
        }
        public string? summary
        {
            get; set;
        }
        public string?[]? styles
        {
            get; set;
        }
        public Config_Attrs? config_attrs
        {
            get; set;
        }
        public int? follow_status
        {
            get; set;
        }
        public int? is_new
        {
            get; set;
        }
        public string? progress
        {
            get; set;
        }
        public bool both_follow
        {
            get; set;
        }
        public Rating? rating
        {
            get; set;
        }
        public Area[]? areas
        {
            get; set;
        }
        public string? renewal_time
        {
            get; set;
        }
        public string? release_date_show
        {
            get; set;
        }
    }

    public class Rights
    {
        public int? is_selection
        {
            get; set;
        }
        public int? selection_style
        {
            get; set;
        }
        public Demand_End_Time? demand_end_time
        {
            get; set;
        }
        public int? allow_review
        {
            get; set;
        }
        public int? allow_preview
        {
            get; set;
        }
        public int? is_rcmd
        {
            get; set;
        }
        public int? allow_bp
        {
            get; set;
        }
    }

    public class Demand_End_Time
    {
    }

    public class Stat
    {
        public int? follow
        {
            get; set;
        }
        public int? view
        {
            get; set;
        }
        public int? danmaku
        {
            get; set;
        }
        public int? reply
        {
            get; set;
        }
        public int? coin
        {
            get; set;
        }
        public int? series_follow
        {
            get; set;
        }
        public int? series_view
        {
            get; set;
        }
        public int? likes
        {
            get; set;
        }
        public int? favorite
        {
            get; set;
        }
        public int? vt
        {
            get; set;
        }
    }

    public class New_Ep
    {
        public int? id
        {
            get; set;
        }
        public string? index_show
        {
            get; set;
        }
        public string? cover
        {
            get; set;
        }
        public string? title
        {
            get; set;
        }
        public string? long_title
        {
            get; set;
        }
        public string? pub_time
        {
            get; set;
        }
        public int? duration
        {
            get; set;
        }
    }

    public class Series
    {
        public int? series_id
        {
            get; set;
        }
        public string? title
        {
            get; set;
        }
        public int? season_count
        {
            get; set;
        }
        public int? new_season_id
        {
            get; set;
        }
        public int? series_ord
        {
            get; set;
        }
    }

    public class Publish
    {
        public string? pub_time
        {
            get; set;
        }
        public string? pub_time_show
        {
            get; set;
        }
        public string? release_date
        {
            get; set;
        }
        public string? release_date_show
        {
            get; set;
        }
        public string? pub_time_show_db
        {
            get; set;
        }
    }

    public class Badge_Info
    {
        public string? text
        {
            get; set;
        }
        public string? bg_color
        {
            get; set;
        }
        public string? bg_color_night
        {
            get; set;
        }
        public string? img
        {
            get; set;
        }
        public Multi_Img? multi_img
        {
            get; set;
        }
    }

    public class Multi_Img
    {
        public string? color
        {
            get; set;
        }
        public string? medium_remind
        {
            get; set;
        }
    }

    public class First_Ep_Info
    {
        public int? id
        {
            get; set;
        }
        public string? cover
        {
            get; set;
        }
        public string? title
        {
            get; set;
        }
        public string? long_title
        {
            get; set;
        }
        public string? pub_time
        {
            get; set;
        }
        public int? duration
        {
            get; set;
        }
    }

    public class Badge_Infos
    {
        public Vip_Or_Pay? vip_or_pay
        {
            get; set;
        }
        public Content_Attr? content_attr
        {
            get; set;
        }
    }

    public class Vip_Or_Pay
    {
        public string? text
        {
            get; set;
        }
        public string? bg_color
        {
            get; set;
        }
        public string? bg_color_night
        {
            get; set;
        }
        public string? img
        {
            get; set;
        }
        public Multi_Img1? multi_img
        {
            get; set;
        }
    }

    public class Multi_Img1
    {
        public string? color
        {
            get; set;
        }
        public string? medium_remind
        {
            get; set;
        }
    }

    public class Content_Attr
    {
        public string? text
        {
            get; set;
        }
        public string? bg_color
        {
            get; set;
        }
        public string? bg_color_night
        {
            get; set;
        }
        public string? img
        {
            get; set;
        }
        public Multi_Img2? multi_img
        {
            get; set;
        }
    }

    public class Multi_Img2
    {
        public string? color
        {
            get; set;
        }
        public string? medium_remind
        {
            get; set;
        }
    }

    public class Config_Attrs
    {
        public Highlight_Ineffective_Hd? highlight_ineffective_hd
        {
            get; set;
        }
        public Highlight_Ineffective_Ott? highlight_ineffective_ott
        {
            get; set;
        }
        public Highlight_Ineffective_Pink? highlight_ineffective_pink
        {
            get; set;
        }
    }

    public class Highlight_Ineffective_Hd
    {
        public string? type_url
        {
            get; set;
        }
    }

    public class Highlight_Ineffective_Ott
    {
        public string? type_url
        {
            get; set;
        }
    }

    public class Highlight_Ineffective_Pink
    {
        public string? type_url
        {
            get; set;
        }
    }

    public class Rating
    {
        public float score
        {
            get; set;
        }
        public int? count
        {
            get; set;
        }
    }

    public class Section
    {
        public int? section_id
        {
            get; set;
        }
        public int? season_id
        {
            get; set;
        }
        public int? limit_group
        {
            get; set;
        }
        public int? watch_platform
        {
            get; set;
        }
        public string? copyright
        {
            get; set;
        }
        public int? ban_area_show
        {
            get; set;
        }
        public int[]? episode_ids
        {
            get; set;
        }
        public int? type
        {
            get; set;
        }
        public string? title
        {
            get; set;
        }
        public int? attr
        {
            get; set;
        }
    }

    public class Producer
    {
        public int? mid
        {
            get; set;
        }
        public int? type
        {
            get; set;
        }
        public int? is_contribute
        {
            get; set;
        }
    }

    public class Area
    {
        public int? id
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
    }

}
