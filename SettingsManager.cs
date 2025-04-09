using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace PayYourBills
{
    internal class SettingsManager
    {
       
            private static readonly string FilePath = "settings.json";

            public static GameSettings CurrentSettings { get; private set; }

            public static void Load()
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    CurrentSettings = JsonConvert.DeserializeObject<GameSettings>(json);
                }
                else
                {
                    CurrentSettings = new GameSettings(); // настройки по умолчанию
                    Save(); // создаём settings.json
                }
            }

            public static void Save()
            {
                string json = JsonConvert.SerializeObject(CurrentSettings, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }

            public static void SetCoins(double coin)
                {
                CurrentSettings.Coin = coin;
                }

            public static double GetCoins()
            {
                return CurrentSettings.Coin;
            }

            public static void SetPassiveUp(double passiveUp)
            {
                CurrentSettings.PassiveUp = passiveUp;
            }

            public static double GetPassiveUp()
            {
                 return CurrentSettings.PassiveUp;
            }

            public static void SetClickPower(double clickPower)
            {
            CurrentSettings.ClickPower = clickPower;
            }

            public static double GetClickPower()
            {
            return CurrentSettings.ClickPower;
            }

    }
}
