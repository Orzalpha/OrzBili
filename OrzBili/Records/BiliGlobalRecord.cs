using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrzBili.Models;

namespace OrzBili.Records;
public class BiliGlobalRecord
{
    public long? mid
    {
        get; set;
    } = null;

    public string? media_id
    {
        get;
        set;
    } = null;

    public AccountModel? Account
    {
        get; set;
    }

}
