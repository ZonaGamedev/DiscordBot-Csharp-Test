using System;
using System.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord;
using Discord.Modules;
using TestBot_Csharp.Utils;

namespace TestBot_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscordClient _client;
            _client = new DiscordClient();

            // Eventos básicos de ingreso y despedida del servidor
            _client.UserJoined += async (s, e) =>
            {
                await Utils.MensajesLog.LogEntradaServidor(e.User.Name, Utils.MensajesLog.Soporte.consola);
            };
            _client.UserLeft += async (s, e) =>
            {
                await Utils.MensajesLog.LogSalidaServidor(e.User.Name, Utils.MensajesLog.Soporte.consola);
            };

            // Eventos básicos de login y logout en el servidor
            _client.UserUpdated += async (s, e) =>
                {
                    // Cambio de estado
                    if (e.Before.Status != e.After.Status)
                    {
                        await Utils.MensajesLog.LogStatusUsr(e.Before.Status + "->" +  e.After.Status, e.Before.Name, MensajesLog.Soporte.consola);
                    }
                };

            //_client.MessageReceived += async (s, e) =>
            //{
            //    if (!e.Message.IsAuthor)
            //        await e.Channel.sendmessage(e.message.text);
            //};

            _client.ExecuteAndWait(async () =>
            {
                await _client.Connect(ConfigurationManager.AppSettings["tokenBot"], TokenType.Bot);
            });
        }
    }
}
