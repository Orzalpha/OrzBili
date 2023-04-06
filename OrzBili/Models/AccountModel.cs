namespace OrzBili.Models;

/// <summary>
/// 个人中心 - 获取我的基本信息
/// </summary>
public record class AccountModel
{
    public class RootObject
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
        public bool nick_free
        {
            get; set;
        }
        public string? rank
        {
            get; set;
        }
    }

}
