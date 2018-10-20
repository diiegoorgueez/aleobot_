using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace AleoBot2.Modules
{
    public class Horario : ModuleBase<SocketCommandContext>
    {
        [Command("horario")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Horario")
                .WithDescription("Aleo suele hacer directos de Lunes a Viernes a las 17:00 CEST y Sabados y Domingo a las 15:00 CEST (Si falla el horario ve al Twitter de Aleo: AleoGFX)")
                .WithColor(Color.Green);


            await ReplyAsync("", false, builder.Build());
        }
    }
}