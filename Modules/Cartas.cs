using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Cartas : ModuleBase<SocketCommandContext>
    {
        [Command("cartas")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Cartas")
                .WithDescription("Las cartas son una manera de interactuar con el directo, comprando cofres os daran 3 cartas por cofres que podeis usar cuando querais mientras esté en directo. https://www.streamloots.com/aleogfx")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}
