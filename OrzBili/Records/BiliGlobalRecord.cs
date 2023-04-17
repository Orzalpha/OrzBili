using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrzBili.Contracts.Records;
using OrzBili.Models;

namespace OrzBili.Records;
public class BiliGlobalRecord : IBiliGlobalRecord
{
    public long? Mid { get; set; } = default;

    public string? CsrfToken { get; set; } = default;


}
