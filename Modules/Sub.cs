using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Sub : ModuleBase<SocketCommandContext>
    {
        [Command("sub")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Sub")
                .WithDescription("Te puedes suscribir por tan solo 4.99$ para disfrutar de ventajas como emoticonos exclusivos, chat de discord privado o no ver anuncios en el stream. Si tienes TWITCH PRIME es GRATIS! ¿A que esperas?")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}