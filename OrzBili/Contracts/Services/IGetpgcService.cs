using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrzBili.Services.GetpgcService;

namespace OrzBili.Contracts.Services;
internal interface IGetpgcService
{
    public Task<List<Todo>> Testtask();
}
