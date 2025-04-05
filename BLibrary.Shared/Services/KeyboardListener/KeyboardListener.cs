using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Blibrary.Shared.Services.KeyboardListener;

[method: DynamicDependency(nameof(KeyboardListener))]
public class KeyboardListener() : IDisposable, IKeyboardListener
{
    public event EventHandler<string>? OnKeyPressed;

    [JSInvokable]
    public void KeyPressed(string pressedKey)
    {
        OnKeyPressed?.Invoke(this, pressedKey);
    }

    public void Dispose()
    {
        OnKeyPressed = null;
        GC.SuppressFinalize(this);
    }
}

