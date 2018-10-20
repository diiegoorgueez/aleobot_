using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Donaciones : ModuleBase<SocketCommandContext>
    {
        [Command("donaciones")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Donaciones")
                .WithDescription("	Si quieres apoyar a Aleo, puedes hacerlo donando mediante este link https://streamlabs.com/aleogfx , las donaciones saldrán en pantalla y asustarán a Aleo cuando esté en directo! EJEJEJEEEEEEEEEEEEEEEEEEEEEE juasjuas")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}