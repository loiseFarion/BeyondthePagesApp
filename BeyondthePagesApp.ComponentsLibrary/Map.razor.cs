using BeyondthePagesApp.Library.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace BeyondthePagesApp.ComponentsLibrary
{
    public partial class Map
    {
        string elementId = $"map-{Guid.NewGuid():D}";

        [Parameter]
        public double Zoom { get; set; }

        [Parameter]
        public List<Marker> Markers { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync(
                "deliveryMap.showOrUpdate",
                elementId,
                Markers);
        }
    }
}
