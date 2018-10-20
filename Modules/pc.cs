using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class pc : ModuleBase<SocketCommandContext>
    {
        [Command("pc")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("PC")
                .WithDescription("Procesador: i5 4400 / Gráfica : GTX 960 / RAM: 16GB DDR4")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}