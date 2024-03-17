using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witaju
{
    internal class Connecting
    {
        internal static void OnConnecting(CSteamID player, ref ESteamRejection? rejectionReason)
        {
            SteamPending steam = Provider.pending.FirstOrDefault((SteamPending p) => p.playerID.steamID.m_SteamID == player.m_SteamID);

            int Name = Provider.clients.Count+1;
            foreach (SteamPlayer argplayer in Provider.clients)
            {
                if(argplayer.playerID.characterName == Name.ToString())
                {
                    Name++;
                    break;
                }
            }
            steam.playerID.characterName = "#Name" + Name.ToString();
            steam.playerID.nickName = "#Name" + Name.ToString();
        }
    }
}
