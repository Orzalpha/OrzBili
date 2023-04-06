namespace OrzBili.Models;

/// <summary>
/// 用户空间详细信息
/// </summary>
public record class SpaceInfoModel
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
        public int? ttl
        {
            get; set;
        }
        public Data? data
        {
            get; set;
        }
    }

    public class Data
    {
        public int? mid
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
        public string? sex
        {
            get; set;
        }
        public string? face
        {
            get; set;
        }
        public int? face_nft
        {
            get; set;
        }
        public int? face_nft_type
        {
            get; set;
        }
        public string? sign
        {
            get; set;
        }
        public int? rank
        {
            get; set;
        }
        public int? level
        {
            get; set;
        }
        public int? jointime
        {
            get; set;
        }
        public int? moral
        {
            get; set;
        }
        public int? silence
        {
            get; set;
        }
        public float coins
        {
            get; set;
        }
        public bool? fans_badge
        {
            get; set;
        }
        public Fans_Medal? fans_medal
        {
            get; set;
        }
        public Official? official
        {
            get; set;
        }
        public Vip? vip
        {
            get; set;
        }
        public Pendant? pendant
        {
            get; set;
        }
        public Nameplate? nameplate
        {
            get; set;
        }
        public User_Honour_Info? user_honour_info
        {
            get; set;
        }
        public bool? is_followed
        {
            get; set;
        }
        public string? top_photo
        {
            get; set;
        }
        public Theme? theme
        {
            get; set;
        }
        public Sys_Notice? sys_notice
        {
            get; set;
        }
        public Live_Room? live_room
        {
            get; set;
        }
        public string? birthday
        {
            get; set;
        }
        public School? school
        {
            get; set;
        }
        public Profession? profession
        {
            get; set;
        }
        public object? tags
        {
            get; set;
        }
        public Series? series
        {
            get; set;
        }
        public int? is_senior_member
        {
            get; set;
        }
        public object? mcn_info
        {
            get; set;
        }
        public int? gaia_res_type
        {
            get; set;
        }
        public object? gaia_data
        {
            get; set;
        }
        public bool? is_risk
        {
            get; set;
        }
        public Elec? elec
        {
            get; set;
        }
        public Contract? contract
        {
            get; set;
        }
    }

    public class Fans_Medal
    {
        public bool? show
        {
            get; set;
        }
        public bool? wear
        {
            get; set;
        }
        public Medal? medal
        {
            get; set;
        }
    }

    public class Medal
    {
        public int? uid
        {
            get; set;
        }
        public int? target_id
        {
            get; set;
        }
        public int? medal_id
        {
            get; set;
        }
        public int? level
        {
            get; set;
        }
        public string? medal_name
        {
            get; set;
        }
        public int? medal_color
        {
            get; set;
        }
        public int? intimacy
        {
            get; set;
        }
        public int? next_intimacy
        {
            get; set;
        }
        public int? day_limit
        {
            get; set;
        }
        public int? medal_color_start
        {
            get; set;
        }
        public int? medal_color_end
        {
            get; set;
        }
        public int? medal_color_border
        {
            get; set;
        }
        public int? is_lighted
        {
            get; set;
        }
        public int? guard_level
        {
            get; set;
        }
        public int? light_status
        {
            get; set;
        }
        public int? wearing_status
        {
            get; set;
        }
        public int? score
        {
            get; set;
        }
    }

    public class Official
    {
        public int? role
        {
            get; set;
        }
        public string? title
        {
            get; set;
        }
        public string? desc
        {
            get; set;
        }
        public int? type
        {
            get; set;
        }
    }

    public class Vip
    {
        public int? type
        {
            get; set;
        }
        public int? status
        {
            get; set;
        }
        public long due_date
        {
            get; set;
        }
        public int? vip_pay_type
        {
            get; set;
        }
        public int? theme_type
        {
            get; set;
        }
        public Label? label
        {
            get; set;
        }
        public int? avatar_subscript
        {
            get; set;
        }
        public string? nickname_color
        {
            get; set;
        }
        public int? role
        {
            get; set;
        }
        public string? avatar_subscript_url
        {
            get; set;
        }
        public int? tv_vip_status
        {
            get; set;
        }
        public int? tv_vip_pay_type
        {
            get; set;
        }
    }

    public class Label
    {
        public string? path
        {
            get; set;
        }
        public string? text
        {
            get; set;
        }
        public string? label_theme
        {
            get; set;
        }
        public string? text_color
        {
            get; set;
        }
        public int? bg_style
        {
            get; set;
        }
        public string? bg_color
        {
            get; set;
        }
        public string? border_color
        {
            get; set;
        }
        public bool? use_img_label
        {
            get; set;
        }
        public string? img_label_uri_hans
        {
            get; set;
        }
        public string? img_label_uri_hant
        {
            get; set;
        }
        public string? img_label_uri_hans_static
        {
            get; set;
        }
        public string? img_label_uri_hant_static
        {
            get; set;
        }
    }

    public class Pendant
    {
        public int? pid
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
        public string? image
        {
            get; set;
        }
        public int? expire
        {
            get; set;
        }
        public string? image_enhance
        {
            get; set;
        }
        public string? image_enhance_frame
        {
            get; set;
        }
    }

    public class Nameplate
    {
        public int? nid
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
        public string? image
        {
            get; set;
        }
        public string? image_small
        {
            get; set;
        }
        public string? level
        {
            get; set;
        }
        public string? condition
        {
            get; set;
        }
    }

    public class User_Honour_Info
    {
        public int? mid
        {
            get; set;
        }
        public object? colour
        {
            get; set;
        }
        public object[]? tags
        {
            get; set;
        }
    }

    public class Theme
    {
    }

    public class Sys_Notice
    {
    }

    public class Live_Room
    {
        public int? roomStatus
        {
            get; set;
        }
        public int? liveStatus
        {
            get; set;
        }
        public string? url
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
        public int? roomid
        {
            get; set;
        }
        public int? roundStatus
        {
            get; set;
        }
        public int? broadcast_type
        {
            get; set;
        }
        public Watched_Show? watched_show
        {
            get; set;
        }
    }

    public class Watched_Show
    {
        public bool? _switch
        {
            get; set;
        }
        public int? num
        {
            get; set;
        }
        public string? text_small
        {
            get; set;
        }
        public string? text_large
        {
            get; set;
        }
        public string? icon
        {
            get; set;
        }
        public string? icon_location
        {
            get; set;
        }
        public string? icon_web
        {
            get; set;
        }
    }

    public class School
    {
        public string? name
        {
            get; set;
        }
    }

    public class Profession
    {
        public string? name
        {
            get; set;
        }
        public string? department
        {
            get; set;
        }
        public string? title
        {
            get; set;
        }
        public int? is_show
        {
            get; set;
        }
    }

    public class Series
    {
        public int? user_upgrade_status
        {
            get; set;
        }
        public bool? show_upgrade_window
        {
            get; set;
        }
    }

    public class Elec
    {
        public Show_Info? show_info
        {
            get; set;
        }
    }

    public class Show_Info
    {
        public bool? show
        {
            get; set;
        }
        public int? state
        {
            get; set;
        }
        public string? title
        {
            get; set;
        }
        public string? icon
        {
            get; set;
        }
        public string? jump_url
        {
            get; set;
        }
    }

    public class Contract
    {
        public bool? is_display
        {
            get; set;
        }
        public bool? is_follow_display
        {
            get; set;
        }
    }

}
