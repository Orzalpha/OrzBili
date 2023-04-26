using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrzBili.ApiModels.BangumiPlayurlModel;
using Windows.Media.Core;

namespace OrzBili.Contracts.Services;

/// <summary>
/// 用于取流
/// </summary>
public interface IGetStreamService
{
    public Task<MediaSource> CreateMediaSource(Video video, Audio audio);

    //public Task<Stream> CreateStream(string path);
}
