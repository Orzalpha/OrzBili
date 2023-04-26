using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrzBili.Models;
public class NavigateParaModel
{
    public class UserpagePara
    {
        public long mid
        {
            get;
            set;
        }

        public UserpagePara(long mid)
        {
            this.mid = mid;
        }
    }
    
    public class PlayerpagePara
    {
        public int season_id
        {
            get;
            set;
        }
        public int media_id
        {
            get;
            set;
        }

        public PlayerpagePara(int season_id, int media_id)
        {
            this.season_id = season_id;
            this.media_id = media_id;
        }
    }
}
