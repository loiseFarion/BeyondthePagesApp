﻿using BeyondthePagesApp.State;
using Microsoft.AspNetCore.Components;

namespace BeyondthePagesApp.Components.Widgets
{
    public partial class InboxWidget
    {
        [Inject]
        public ApplicationState ApplicationState { get; set; }

        public int MessageCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            MessageCount = ApplicationState.NumberOfMessages;
        }
    }
}
