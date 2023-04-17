using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrzBili.Contracts.Records;
public interface IBiliGlobalRecord
{
    public long? Mid
    {
        get;
        set;
    }

    public string? CsrfToken
    {
        get;
        set;
    }

}
