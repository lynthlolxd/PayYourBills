using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace PayYourBills
{
    public partial class SettingsForm : Form
    {


        public SettingsForm()
        {
            InitializeComponent();
        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Fullscreen.Checked = SettingsManager.CurrentSettings.IsFullscreen;

            if (SettingsManager.CurrentSettings.IsFullscreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }

            
        }
        private void BackToMenubtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            SettingsManager.CurrentSettings.IsFullscreen = Fullscreen.Checked;
            SettingsManager.Save(); // сохраняем в settings.json
            MessageBox.Show("Настройки применятся при выходе из настроек!");

        }

        private void ResetProgress_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Сброс прогресса", "Вы уверены?", MessageBoxButtons.YesNo);
            if (reset == DialogResult.Yes)
            {
                SettingsManager.SetCoins(0);  // Устанавливаем 0 монет
                SettingsManager.SetClickPower(1);
                SettingsManager.SetPassiveUp(0);
;               SettingsManager.Save();
                MessageBox.Show("Прогресс сброшен.Вы снова нам должны:)");
            }
            else if(reset == DialogResult.No)
            {
               
            }
        }
    }
}
