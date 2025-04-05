namespace Blibrary.Shared.Services.KeyboardListener;

public interface IKeyboardListener
{
    event EventHandler<string>? OnKeyPressed;

    void KeyPressed(string pressedKey);
}