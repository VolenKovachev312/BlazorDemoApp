using Microsoft.AspNetCore.Components;

namespace BlazorDemoApp.Pages.Components.DialogPopUp
{
    public partial class DialogCloseButton : ComponentBase
    {
        [CascadingParameter]
        public Dialog Dialog { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> CapturedAttributes { get; set; } = new Dictionary<string, object>
    {
        { "class", "btn btn-close" }
    };

        private async Task CloseDialog() => await Dialog.CloseDialogAsync();
    }
}
