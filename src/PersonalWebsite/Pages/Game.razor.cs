using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace PersonalWebsite.Pages
{
    public partial class Game
    {
        [Parameter]
        public string Name { get; set; }

        [Inject]
        private IJSRuntime JsRuntime { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var module = await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./Pages/Game.razor.js");
            await module.InvokeVoidAsync("initGame", "Pong");      
        }
    }
}
