using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Extensions;

public static class JSRuntimeExtensions
{
    public static async Task ShowModal(this IJSRuntime js, ElementReference modalRef)
    {
        await js.InvokeVoidAsync("showModal", modalRef);
    }
    public static async Task HideModal(this IJSRuntime js, ElementReference modalRef)
    {
        await js.InvokeVoidAsync("hideModal", modalRef);
    }

    /// <summary>
    /// register event listeners for modal events. The <paramref name="dotnetObjectRef"/> should be a <see cref="DotNetObjectReference"/> holding a reference to the component class representing a modal.
    /// The parent contained in the referende should contain JSINvokable methods. Pass in the names of the JSInvokable methods which will be triggered on the  modals show and hide events respectively.
    /// </summary>
    /// <param name="js">an IJSRuntime reference from DI</param>
    /// <param name="modalRef">an element reference bound to the modal element</param>
    /// <param name="dotnetObjectRef">a DotnetObjectReference with JSInvokable methods</param>
    /// <param name="showMethodName">the name of the JSInvokable method to call ont he modal show event</param>
    /// <param name="hideMethodName">the name of the JSInvokable method to call ont he modal hide event</param>
    /// <returns></returns>
    public static async Task RegisterModalEvents(this IJSRuntime js, ElementReference modalRef, object dotnetObjectRef, string showMethodName, string hideMethodName)
    {
        await js.InvokeVoidAsync("registerModalEvents", modalRef, dotnetObjectRef, showMethodName, hideMethodName);
    }

    /// <summary>
    /// Save a serialized object or any string value to the browsers session storage. Any object Values must be serialized before passing it to this method.
    /// </summary>
    /// <param name="js">the apps IJSRuntime service from DI</param>
    /// <param name="key">the key to use when saving the and retrieving the value</param>
    /// <param name="jsonValue">a serialized object or string value to save</param>
    /// <returns>a task that resolves on completion</returns>
    public static async Task SaveToSessionAsync(this IJSRuntime js, string key, string jsonValue)
    {
        await js.InvokeVoidAsync("saveToSession", key, jsonValue);
    }

    /// <summary>
    /// Save a serialized object or any string value to the browsers local storage. This will persist beyond the lifecycle of the app and after the browser is completely closed.
    /// Any object Values must be serialized before passing it to this method.
    /// </summary>
    /// <param name="js">the apps IJSRuntime service from DI</param>
    /// <param name="key">the key to use when saving the and retrieving the value</param>
    /// <param name="jsonValue">a serialized object or string value to save</param>
    /// <returns>a task that resolves on completion</returns>
    public static async Task SaveToLocalStorageAsync(this IJSRuntime js, string key, string jsonValue)
    {
        await js.InvokeVoidAsync("saveToLocalStorage", key, jsonValue);
    }


    /// <summary>
    /// Get a string item from the browsers session storage using the specified key
    /// </summary>
    /// <param name="js">the apps IJSRuntime service from DI</param>
    /// <param name="key">the key to use to find the desired value</param>
    /// <returns>the string value belonging to the specified key</returns>
    public static async Task<string> GetFromSessionAsync(this IJSRuntime js, string key)
    {
        return await js.InvokeAsync<string>("getFromSession", key);
    }

    /// <summary>
    /// Get a string item from the browsers local storage using the specified key
    /// </summary>
    /// <param name="js">the apps IJSRuntime service from DI</param>
    /// <param name="key">the key to use to find the desired value</param>
    /// <returns>the string value belonging to the specified key</returns>
    public static async Task<string> GetFromLocalStorageAsync(this IJSRuntime js, string key)
    {
        return await js.InvokeAsync<string>("getFromLocalStorage", key);
    }

    /// <summary>
    /// Clear everything out of the browsers session storage
    /// </summary>
    /// <param name="js">the apps IJSRuntime service from DI</param>
    public static async Task ClearSession(this IJSRuntime js)
    {
        await js.InvokeVoidAsync("clearSession");
    }

    /// <summary>
    /// Clear everything out of the browsers local storage
    /// </summary>
    /// <param name="js">the apps IJSRuntime service from DI</param>
    public static async Task ClearLocalStorage(this IJSRuntime js)
    {
        await js.InvokeVoidAsync("clearLocalStorage");
    ;    }

    /// <summary>
    /// Remove a specific value from session storage
    /// </summary>
    /// <param name="js"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static async Task RemoveFromSession(this IJSRuntime js, string key)
    {
        await js.InvokeVoidAsync("removeFromSession", key);
    }

    /// <summary>
    /// Remove a specific value from local storage
    /// </summary>
    /// <param name="js"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static async Task RemoveFromLocalStorage(this IJSRuntime js, string key)
    {
        await js.InvokeVoidAsync("removeFromLocalStorage", key);
    }
}
