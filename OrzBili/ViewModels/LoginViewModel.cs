﻿using System.Windows.Input;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Microsoft.Web.WebView2.Core;

using OrzBili.Contracts.Services;
using OrzBili.Contracts.ViewModels;

namespace OrzBili.ViewModels;

// TODO: Review best practices and distribution guidelines for WebView2.
// https://docs.microsoft.com/microsoft-edge/webview2/get-started/winui
// https://docs.microsoft.com/microsoft-edge/webview2/concepts/developer-guide
// https://docs.microsoft.com/microsoft-edge/webview2/concepts/distribution
public partial class LoginViewModel : ObservableRecipient, INavigationAware
{
    // TODO: Set the default URL to display.
    private Uri _source = new("https://passport.bilibili.com/ajax/miniLogin/minilogin");
    private bool _isLoading = true;
    private bool _hasFailures;

    public IWebViewService WebViewService
    {
        get;
    }

    public Uri Source
    {
        get => _source;
        set => SetProperty(ref _source, value);
    }

    public bool IsLoading
    {
        get => _isLoading;
        set => SetProperty(ref _isLoading, value);
    }

    public bool HasFailures
    {
        get => _hasFailures;
        set => SetProperty(ref _hasFailures, value);
    }

    public ICommand BrowserBackCommand
    {
        get;
    }

    public ICommand BrowserForwardCommand
    {
        get;
    }

    public ICommand ReloadCommand
    {
        get;
    }

    public ICommand RetryCommand
    {
        get;
    }

    public ICommand OpenInBrowserCommand
    {
        get;
    }

    [RelayCommand]
    public async void LoginOK()
    {
        try
        {
            var cookie = await WebViewService.GetBiliCookieAsync("https://www.bilibili.com/");
            _biliapiService.SetCookie(cookie);
            var account = await _biliapiService.GetInfoAsync(Services.BiliApiService.Info.Account);
            
        }
        catch (Exception ex)
        {
            //  之后设置一个 Flyout 报错
        }

        await Task.CompletedTask;
    }

    private readonly IBiliApiService _biliapiService;
    private readonly INavigationService _navigationService;

    public LoginViewModel(
        IWebViewService webViewService, 
        IBiliApiService biliApiService, 
        INavigationService navigationService)
    {
        WebViewService = webViewService;
        _biliapiService = biliApiService;
        _navigationService = navigationService;

        BrowserBackCommand = new RelayCommand(() => WebViewService.GoBack(), () => WebViewService.CanGoBack);
        BrowserForwardCommand = new RelayCommand(() => WebViewService.GoForward(), () => WebViewService.CanGoForward);
        ReloadCommand = new RelayCommand(() => WebViewService.Reload());
        RetryCommand = new RelayCommand(OnRetry);
        OpenInBrowserCommand = new RelayCommand(async () => await Windows.System.Launcher.LaunchUriAsync(WebViewService.Source), () => WebViewService.Source != null);
        
    }

    public void OnNavigatedTo(object parameter)
    {
        WebViewService.NavigationCompleted += OnNavigationCompleted;
    }

    public void OnNavigatedFrom()
    {
        WebViewService.UnregisterEvents();
        WebViewService.NavigationCompleted -= OnNavigationCompleted;
    }

    private void OnNavigationCompleted(object? sender, CoreWebView2WebErrorStatus webErrorStatus)
    {
        IsLoading = false;
        OnPropertyChanged(nameof(BrowserBackCommand));
        OnPropertyChanged(nameof(BrowserForwardCommand));
        if (webErrorStatus != default)
        {
            HasFailures = true;
        }
    }

    private void OnRetry()
    {
        HasFailures = false;
        IsLoading = true;
        WebViewService?.Reload();
    }
}
