using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Twitter : ModuleBase<SocketCommandContext>
    {
        [Command("twitter")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Twitter")
                .WithDescription("Este es el twitter de Aleo: https://twitter.com/AleoGFX")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}
