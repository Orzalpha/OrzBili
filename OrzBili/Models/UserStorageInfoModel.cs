using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrzBili.Models;
public class UserStorageInfoModel
{
    public UserStorageInfoModel(long mid, string cookie)
    {
        Mid = mid;
        Cookie = cookie;
    }

    public long Mid
    {
        get;
        set;
    }
    public string Cookie
    {
        get; set;
    }

}
