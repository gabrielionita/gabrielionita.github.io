using System.Collections.Generic;

namespace PersonalWebsite.Pages
{
    public partial class Games
    {
        public IEnumerable<string> GameList { get; set; }

        protected override void OnInitialized()
        {
            GameList = new List<string>
            {
                "Pong"
            };
        }
    }
}
