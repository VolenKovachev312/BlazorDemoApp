using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorDemoApp.Pages.Components.DialogPopUp
{
    public partial class Dialog : ComponentBase, IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;
        private ElementReference dialogElement;
        private bool visible = false;

        public Dialog()
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                identifier: "import",
                args: "./js/addContactErrorPopUp.js")
            .AsTask());
        }

        [Inject]
        private IJSRuntime jsRuntime { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> CapturedAttributes { get; set; }

        public async ValueTask ShowDialogAsync()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("showDialog", dialogElement);
            visible = true;
        }

        public async ValueTask CloseDialogAsync()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("closeDialog", dialogElement);
            visible = false;
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
