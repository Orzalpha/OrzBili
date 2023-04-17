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
        /// <summary>
        /// 查询类型，1 为追番，2 为追剧
        /// </summary>
        public int type
        {
            get; set;
        }

        public BangumiListPara(long vmid, int type)
        {
            this.vmid = vmid;
            this.type = type;
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

        public BangumiPlayurlPara(long? avid, string? bvid, long? cid, long? ep_id)
        {
            this.avid = avid;
            this.bvid = bvid;
            this.cid = cid;
            this.ep_id = ep_id;
        }
    }
}
