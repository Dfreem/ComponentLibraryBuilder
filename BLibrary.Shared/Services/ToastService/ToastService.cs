using System.Collections.Concurrent;

using Microsoft.Extensions.DependencyInjection;

namespace Blibrary.Shared.Services.ToastService;
public class ToastService(ToastOptions? options = null) : IToastService
{
    ConcurrentQueue<ToastEventArgs> _queue = new();

    public event EventHandler<ToastEventArgs> ToastEvent = default!;

    bool _isToasting = false;

    public void Success(string message)
    {

        ToastEventArgs args = new(message, "toast-success", options);
        AddToQ(args);
    }

    public void Error(string message)
    {
        ToastEventArgs args = new(message, "toast-error", options);
        AddToQ(args);
    }


    public void Warning(string message)
    {
        ToastEventArgs args = new(message, "toast-warning", options);
        AddToQ(args);
    }

    public void Info(string message)
    {
        ToastEventArgs args = new(message, "toast-info", options);
        AddToQ(args);
    }

    private void AddToQ(ToastEventArgs args)
    {
        _queue.Enqueue(args);
        if (!_isToasting)
            _ = ProcessToastEventsAsync();

    }

    protected virtual Task RaiseToastEvent(ToastEventArgs args)
    {
        return Task.Run(() => ToastEvent?.Invoke(this, args));
    }

    private async Task ProcessToastEventsAsync()
    {
        _isToasting = true;
        while (_queue.Count > 0)
        {
            if (_queue.TryDequeue(out var args))
            {
                await RaiseToastEvent(args);
            }
        }
        _isToasting = false;
    }

}

[Flags]
public enum ToastPosition
{
    None = 0,
    Top = 1,
    Bottom = 2,
    Left = 4,
    Right = 8,
}

public static class ToastExtensions
{
    public static string ToString(this ToastPosition position)
    {
        return position.ToString().Replace(",", "");
    }

    public static IServiceCollection AddToast(this IServiceCollection collection, Action<ToastOptions>? configure)
    {
        ToastOptions options = new();
        if (configure is not null)
        {
            configure(options);
        }
        ToastService toast = new(options);
        collection.AddScoped<IToastService, ToastService>(sp =>
        {
            return toast;
        });

        return collection;
    }

}

public class ToastOptions
{
    public int Duration { get; set; }

    public ToastPosition Position { get; set; }
}

public class ToastEventArgs(string message = "", string cssClass = "", ToastOptions? options = null) : EventArgs
{
    public string Message { get; set; } = message;

    // TODO upgrade to Enum
    public string CssClass { get; set; } = cssClass;
    public int? Duration { get; set; } = options?.Duration;
    public ToastPosition Position { get; set; } = options?.Position ?? ToastPosition.Top;
}