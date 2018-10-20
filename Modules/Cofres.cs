using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Cofres : ModuleBase<SocketCommandContext>
    {
        [Command("cofres")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Cofres")
                .WithDescription("Los cofres son una manera de interactuar con el directo, comprando cofres os daran 3 cartas por cofres que podeis usar cuando querais mientras esté en directo. https://www.streamloots.com/aleogfx")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}