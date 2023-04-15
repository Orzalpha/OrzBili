using System.Diagnostics.CodeAnalysis;

using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;

using OrzBili.Contracts.Services;

namespace OrzBili.Services;

public class WebViewService : IWebViewService
{
    private WebView2? _webView;

    public Uri? Source => _webView?.Source;

    [MemberNotNullWhen(true, nameof(_webView))]
    public bool CanGoBack => _webView != null && _webView.CanGoBack;

    [MemberNotNullWhen(true, nameof(_webView))]
    public bool CanGoForward => _webView != null && _webView.CanGoForward;

    public event EventHandler<CoreWebView2WebErrorStatus>? NavigationCompleted;

    public WebViewService()
    {
    }

    [MemberNotNull(nameof(_webView))]
    public void Initialize(WebView2 webView)
    {
        _webView = webView;
        _webView.NavigationCompleted += OnWebViewNavigationCompleted;
    }

    public void GoBack() => _webView?.GoBack();

    public void GoForward() => _webView?.GoForward();

    public void Reload() => _webView?.Reload();

    /// <summary>
    /// 用于获取 cookie，获取不到时会抛出一个异常
    /// </summary>
    /// <returns></returns>
    public async Task<string> GetBiliCookieAsync(string domain)
    {
        var cookies = await _webView!.CoreWebView2.CookieManager.GetCookiesAsync(domain);
        if (cookies == null)
        {
            throw new Exception("Can't get cookie!");
        }
        else
        {
            var result = string.Empty;
            foreach (var cookie in cookies)
            {
                result += cookie.Name + '=' + cookie.Value + ';';
            }
            return result;
        } 
    }

    public void UnregisterEvents()
    {
        if (_webView != null)
        {
            _webView.NavigationCompleted -= OnWebViewNavigationCompleted;
        }
    }

    private void OnWebViewNavigationCompleted(WebView2 sender, CoreWebView2NavigationCompletedEventArgs args) => NavigationCompleted?.Invoke(this, args.WebErrorStatus);
}
