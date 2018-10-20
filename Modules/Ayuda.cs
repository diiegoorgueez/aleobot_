using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Ayuda : ModuleBase<SocketCommandContext>
    {
        [Command("soporte")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Soporte")
                .WithDescription("Si necesitas ayuda o tienes una duda, puedes ir a #soporte, crear un ticket con -new y los moderadores intentaremos ayudarte en todo lo que nos sea posible")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}

