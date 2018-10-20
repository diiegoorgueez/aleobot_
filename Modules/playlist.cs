using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class playlist : ModuleBase<SocketCommandContext>
    {
        [Command("playlist")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Playlist")
                .WithDescription("La playlist de Aleo estará pública siempre y cuando seamos más de 80 suscriptores. Aquí está : https://goo.gl/tVv8YW")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}