namespace OrzBili.Models;

/// <summary>
/// 用户空间详细信息
/// </summary>
public record class SpaceInfoModel
{

    public class Rootobject
    {
        public int? code { get; set; } = default;

        public string? message { get; set; } = default;

        public int? ttl { get; set; } = default;

        public Data? data { get; set; } = default;
    }

    public class Data
    {
        public long? mid { get; set; } = default;

        public string? name { get; set; } = default;

        public string? sex { get; set; } = default;

        public string? face { get; set; } = default;

        public string? sign { get; set; } = default;

        public int? level { get; set; } = default;

        public float coins { get; set; } = default;

        public Vip? vip { get; set; } = default;

        public string? birthday { get; set; } = default;

        public School? school { get; set; } = default;

    }

    public class Vip
    {
        public int? type { get; set; } = default;

        public int? status { get; set; } = default;

        public long due_date { get; set; } = default;

        public int? role { get; set; } = default;

    }

    public class School
    {
        public string? name { get; set; } = default;
    }


}
