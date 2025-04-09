using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PayYourBills
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //загрузка настроек
            string json = File.ReadAllText("settings.json");
            GameSettings settings = JsonConvert.DeserializeObject<GameSettings>(json);
            SettingsManager.Load(); // <--- Загружаем JSON в класс GameSettings


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
