using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrzBili.Models;
public class ApiParameterModel
{
    public class SpacePara
    {
        public long mid
        {
            get;
            set;
        }
        /// <summary>
        /// 获取个人空间信息时使用的参数
        /// </summary>
        /// <param name="mid">用户mid</param>
        public SpacePara(long mid)
        {
            this.mid = mid;
        }
    }

    public class BangumiListPara
    {
        public long vmid
        {
            get; set;
        }
        public int pn { get; set; } = 1;

        public int ps { get; set; } = 30;

        public int type
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vmid">用户mid</param>
        /// <param name="type">查询类型，1 为追番，2 为追剧</param>
        public BangumiListPara(long vmid, int type)
        {
            this.vmid = vmid;
            this.type = type;
        }
    }

    public class BangumiDetailPara
    {
        public int? season_id { get; set; } = default;

        public int? ep_id { get; set; } = default;
        /// <summary>
        /// 用于获取剧集信息时使用的参数
        /// </summary>
        /// <param name="season_id">番剧ssid</param>
        /// <param name="ep_id">剧集epid</param>
        public BangumiDetailPara(int? season_id, int? ep_id)
        {
            this.season_id = season_id;
            this.ep_id = ep_id;
        }
    }

    public class BangumiPlayurlPara
    {
        public long? avid { get; set; } = default;

        public string? bvid { get; set; } = default;

        public long? cid { get; set; } = default;

        public long? ep_id { get; set; } = default;

        public int fnval { get; set; } = 4048;

        public int fourk { get; set; } = 1;

        public string from_client { get; set; } = "BROWSER";

        public int drm_tec_type { get; set; } = 2;

        /// <summary>
        /// 获取视频流url时使用的参数
        /// </summary>
        /// <param name="avid">avid</param>
        /// <param name="bvid">bvid</param>
        /// <param name="cid">cid</param>
        /// <param name="ep_id">ep_id</param>
        public BangumiPlayurlPara(long? avid, string? bvid, long? cid, long? ep_id)
        {
            this.avid = avid;
            this.bvid = bvid;
            this.cid = cid;
            this.ep_id = ep_id;
        }
    }
}
