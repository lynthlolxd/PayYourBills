using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PayYourBills
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
       

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (SettingsManager.CurrentSettings.IsFullscreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void GameStartButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Hide();
       
            
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
            this.Hide();
        }

        private void GameExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра создана компанией lynth ака Николай Марихин. Огромную благодарность в финансировании и помощи в разработке выражаю стримеру Metaphorid ака Фокин Денис.Спасибо, что играете💕💕💕", "Об игре");
        }
    }
}
