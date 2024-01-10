using System;
using System.Text;
using MinecraftClient;
using MinecraftClient.Scripting;
using System.Collections.Generic;
using Tomlet.Attributes;

namespace MinecraftClient.ChatBots
{
    /// <summary>
    /// This bot sends a /list command every X seconds and save the result.
    /// </summary>

    public class PlayerListLogger : ChatBot
    {
        public static Configs Config = new();

        [TomlDoNotInlineObject]
        public class Configs
        {
            [NonSerialized]
            private const string BotName = "PlayerListLogger";
            
            [TomlInlineComment("FIZ_xingchen " +
                "chhhg "+ "Lizho666 "+"all the FIZ's number ")]

            public bool Enabled = true;

            public string File = "playerlog.txt";

            [TomlInlineComment("$ChatBot.PlayerListLogger.Delay$")]
            public double Delay = 25;


            public void OnSettingUpdate()
            {
                File ??= string.Empty;

                if (Delay < 1.0)
                    Delay = 1.0;
            }
        }

        private int count = 0;

        
        public override void Update()
        {
            count++;
            if (count >= Settings.DoubleToTick(Config.Delay))
            {
                LogDebugToConsole("Saving Player List");

                string playerListFilePath = Settings.Config.AppVar.ExpandVars(Config.File);
                if (System.IO.File.Exists(playerListFilePath))
                {
                    System.IO.File.Delete(playerListFilePath);
                }


               

                StringBuilder sb = new();

                sb.AppendLine(string.Join(", ", GetOnlinePlayers())).AppendLine();


          
                System.IO.File.AppendAllText(playerListFilePath, sb.ToString());

                count = 0;
            }
        }
    }
}
