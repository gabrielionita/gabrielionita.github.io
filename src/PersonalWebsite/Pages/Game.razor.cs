using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace PersonalWebsite.Pages
{
    public partial class Game : IAsyncDisposable
    {
        [Parameter]
        public string Name { get; set; }

        [Inject]
        private IJSRuntime JsRuntime { get; set; }

        private IJSObjectReference module;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        { 
            module = await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./Pages/Game.razor.js");
            await module.InvokeVoidAsync("initGame", Name);      
        }

        public async ValueTask DisposeAsync()
        {
            await module.InvokeVoidAsync("clearScripts", Name);
            await module.DisposeAsync();
        }
    }
}
