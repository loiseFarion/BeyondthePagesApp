using Microsoft.AspNetCore.Components;

namespace BeyondthePagesApp.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
