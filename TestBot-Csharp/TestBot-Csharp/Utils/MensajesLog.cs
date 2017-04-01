using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBot_Csharp.Utils
{
    public static class MensajesLog
    {
        public enum Soporte
        {
            consola,
            baseDeDatos
        }

        public static async Task<Boolean> LogEntradaServidor(string usuario, Soporte soporte)
        {
            await Task.Run(() =>
            {
                switch (soporte)
                {
                    case Soporte.consola:
                        Console.Write(usuario + " ha entrado en el servidor\n");
                        break;
                    case Soporte.baseDeDatos:
                        break;
                }
            });

            return true;
        }

        public static async Task<Boolean> LogSalidaServidor(string usuario, Soporte soporte)
        {
            await Task.Run(() =>
            {
                switch (soporte)
                {
                    case Soporte.consola:
                        Console.Write(usuario + " ha salido del servidor\n");
                        break;
                    case Soporte.baseDeDatos:
                        break;
                }
            });

            return true;
        }

        public static async Task<Boolean> LogUsrConectado(string usuario, Soporte soporte)
        {
            await Task.Run(() =>
            {
                switch (soporte)
                {
                    case Soporte.consola:
                        Console.Write(usuario + " se ha conectado\n");
                        break;
                    case Soporte.baseDeDatos:
                        break;
                }
            });

            return true;
        }

        public static async Task<Boolean> LogUsrDesconectado(string usuario, Soporte soporte)
        {
            await Task.Run(() =>
            {
                switch (soporte)
                {
                    case Soporte.consola:
                        Console.Write(usuario + " se ha desconectado\n");
                        break;
                    case Soporte.baseDeDatos:
                        break;
                }
            });

            return true;
        }

        public static async Task<Boolean> LogStatusUsr(string estado, string usuario, Soporte soporte)
        {
            await Task.Run(() =>
                {
                    switch (soporte)
                    {
                        case Soporte.consola:
                            Console.Write("El usuario " + usuario + " tiene como estado '" + estado + "'\n");
                            break;
                        case Soporte.baseDeDatos:
                            break;
                    }
                });
            return true;
        }

        public static async Task<Boolean> LogJoinChannelUsr(string canal, string usuario, Soporte soporte)
        {
            await Task.Run(() =>
            {
                switch (soporte)
                {
                    case Soporte.consola:
                        Console.Write("El usuario " + usuario + " ha entrado en el canal '" + canal + "'\n");
                        break;
                    case Soporte.baseDeDatos:
                        break;
                }
            });
            return true;
        }

        public static async Task<Boolean> LogLeftChannelUsr(string canal, string usuario, Soporte soporte)
        {
            await Task.Run(() =>
            {
                switch (soporte)
                {
                    case Soporte.consola:
                        Console.Write("El usuario " + usuario + " ha dejado el canal '" + canal + "'\n");
                        break;
                    case Soporte.baseDeDatos:
                        break;
                }
            });
            return true;
        }

        public static async Task<Boolean> LogChangeChannelUsr(string canalAntes, string canalDespues, string usuario, Soporte soporte)
        {
            await Task.Run(() =>
            {
                switch (soporte)
                {
                    case Soporte.consola:
                        Console.Write("El usuario " + usuario + " ha cambiado de canal '" + canalAntes + "->" + canalDespues + "'\n");
                        break;
                    case Soporte.baseDeDatos:
                        break;
                }
            });
            return true;
        }
    }
}
