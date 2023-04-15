namespace OrzBili.Models;

/// <summary>
/// 个人中心 - 获取我的基本信息
/// </summary>
public record class AccountModel
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
        public Data? data
        {
            get; set;
        }
    }

    public class Data
    {
        public long? mid
        {
            get; set;
        }
        public string? uname
        {
            get; set;
        }
        public string? userid
        {
            get; set;
        }
        public string? sign
        {
            get; set;
        }
        public string? birthday
        {
            get; set;
        }
        public string? sex
        {
            get; set;
        }
    }

}
