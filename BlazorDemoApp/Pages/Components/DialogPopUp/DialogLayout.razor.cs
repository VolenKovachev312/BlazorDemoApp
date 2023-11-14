using Microsoft.AspNetCore.Components;

namespace BlazorDemoApp.Pages.Components.DialogPopUp
{
    public partial class DialogLayout
    {
        [Parameter]
        public RenderFragment Header { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }
    }
}
