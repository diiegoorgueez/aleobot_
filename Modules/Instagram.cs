using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Instagram : ModuleBase<SocketCommandContext>
    {
        [Command("instagram")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Instagram")
                .WithDescription("Este es el Instagram de Aleo: https://instagram.com/gfxale")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}