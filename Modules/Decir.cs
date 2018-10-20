using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Decir : ModuleBase<SocketCommandContext>
    {
        [Command("decir"), RequireBotPermission(GuildPermission.ManageChannels)]
        public async Task PingAsync([Remainder] string stuffToSay)
        {

            await ReplyAsync(stuffToSay);
        }
    }
}