using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Witaju.Serwis;

namespace Witaju
{
    public class Class1 : RocketPlugin<Config>
    {
        public static Class1 Instance {  get; set; }
        protected override void Load()
        {
            Instance = this;
            UnturnedPermissions.OnJoinRequested += Connecting.OnConnecting;
            U.Events.OnPlayerConnected += Join.Joining;
        }
        protected override void Unload()
        {
            UnturnedPermissions.OnJoinRequested -= Connecting.OnConnecting;
            U.Events.OnPlayerConnected -= Join.Joining;
        }
        
    }
}
