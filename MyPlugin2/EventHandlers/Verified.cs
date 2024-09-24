using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlugin2.EventHandlers
{
    public static class Verified
    {
        public static void OnVerified(VerifiedEventArgs ev) 
        {
            ev.Player.ShowHint("You joined my epic server thank u :)", 8);
        }
    }
}
