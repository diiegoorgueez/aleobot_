using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Tienda : ModuleBase<SocketCommandContext>
    {
        [Command("tienda")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Tienda")
                .WithDescription("Aqui esta la tienda de Aleo, encontrarás packs y recursos que te ayududarán a mejorar diseñando: https://sellfy.com/aleo")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}

