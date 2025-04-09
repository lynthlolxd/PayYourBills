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
    public partial class GameForm : Form
    {

        private double coin;

        

        public GameForm()
        {
            InitializeComponent();
            LoadGameSettings();

        }

        
        private void LoadGameSettings()
        {
            // Загружаем настройки
            SettingsManager.Load();  // Загружаем все настройки из settings.json

            // Подгружаем значение монет
            coin = SettingsManager.GetCoins();  // Получаем монеты из настроек
           


            // Отображаем значение на метке (или другом элементе UI)
            CoinLabel.Text = $"{coin}";

            passiveIncomeTimer.Tick += PassiveIncomeTimer_Tick;
            passiveIncomeTimer.Start();
        }

        private void AdjustUpgradePanelPosition()
        {
            bool isFullscreen = SettingsManager.CurrentSettings.IsFullscreen;

            if (isFullscreen)
            {
                // Вычисляем новую позицию от правого края
                int panelX = this.ClientSize.Width - UpgradePanel.Width;         // 392px ширина
                int buttonX = this.ClientSize.Width - ToggleShopButton.Width;    // кнопки на одном уровне

                // Обновляем позиции
                ToggleShopButton.Location = new Point(buttonX, 10);
                CloseShopButton.Location = new Point(buttonX, 10);
                UpgradePanel.Location = new Point(panelX, 39);
            }
            else
            {
                // Обычные позиции в оконном режиме
                ToggleShopButton.Location = new Point(1264, 10);
                CloseShopButton.Location = new Point(1264, 10);
                UpgradePanel.Location = new Point(1264, 39);
            }
        }





        private void GameForm_Load(object sender, EventArgs e)
        {
            
                if (SettingsManager.CurrentSettings.IsFullscreen)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                
                }

            ButtonInvisible();

            SettingsManager.Load();
            AdjustUpgradePanelPosition();

            double a = SettingsManager.GetClickPower();
            ClickPowerLabel.Text = "Один клик = " + a.ToString() + "$";
            double b = SettingsManager.GetPassiveUp();
            InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + b.ToString() + "$";

        }

        private void PassiveIncomeTimer_Tick(object sender, EventArgs e)
        {
            coin += SettingsManager.GetPassiveUp();           // Прибавляем пассивный доход
            CoinLabel.Text = coin.ToString();                 // Обновляем отображение
            SettingsManager.SetCoins(coin);                   // Обновляем значение в настройках
        SettingsManager.Save();                        // (можно сохранять не каждый тик, если будет тормозить)
        }

        private void ButtonInvisible()
        {

            // Проверяем, если игрок накопил триллион деняк
            if (coin >= 1000000000000) // 1 триллион
            {
                PayBills.Visible = true; // Показываем кнопку "Выплатить долг"
            }
            else
            {
                PayBills.Visible = false; // Кнопка скрыта
            }

            if (coin <= 999999999999)
            {
                GetCoinButton.Visible = true;
            }
            else
            {
                GetCoinButton.Visible = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GamePauseForm gamePause = new GamePauseForm(coin);
            gamePause.Show();
        }


        private void GetCoinButton_Click_1(object sender, EventArgs e)
        {
            coin += SettingsManager.GetClickPower();
            CoinLabel.Text = coin.ToString();

            ButtonInvisible();

          

        }

        private void PayBills_Click(object sender, EventArgs e)
        {
            
            Form4 form = new Form4();
            form.Show();


        }

        private void ToggleShopButton_Click(object sender, EventArgs e)
        {
            UpgradePanel.Visible = true;
            ToggleShopButton.Visible = false;
            CloseShopButton.Visible = true;
        }

        private void CloseShopButton_Click(object sender, EventArgs e)
        {
            UpgradePanel.Visible = false;
            ToggleShopButton.Visible = true;
            CloseShopButton.Visible = false;
        }



        // Кнопки апгрейдов

        private void ClickUpgrade1_Click(object sender, EventArgs e)
        {
            if(coin >= 100)
            {

                coin -= 100;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetClickPower();
                SettingsManager.SetClickPower(CurrentPower + 1);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetClickPower();
                ClickPowerLabel.Text = "Один клик = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для улучшения!");
            }
        }
        private void Upgrade2_Click(object sender, EventArgs e)
        {
            if (coin >= 1000)
            {

                coin -= 1000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetClickPower();
                SettingsManager.SetClickPower(CurrentPower + 4);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetClickPower();
                ClickPowerLabel.Text = "Один клик = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для улучшения!");
            }
        }

        private void Upgrade3_Click(object sender, EventArgs e)
        {
            if (coin >= 10000)
            {

                coin -= 10000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetClickPower();
                SettingsManager.SetClickPower(CurrentPower + 10);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetClickPower();
                ClickPowerLabel.Text = "Один клик = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для улучшения!");
            }
        }

        private void Upgrade4_Click(object sender, EventArgs e)
        {
            if (coin >= 150000)
            {

                coin -= 150000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetClickPower();
                SettingsManager.SetClickPower(CurrentPower + 50);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetClickPower();
                ClickPowerLabel.Text = "Один клик = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для улучшения!");
            }
        }

        private void Upgrade5_Click(object sender, EventArgs e)
        {
            if (coin >= 1500000)
            {

                coin -= 1500000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetClickPower();
                SettingsManager.SetClickPower(CurrentPower + 500);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetClickPower();
                ClickPowerLabel.Text = "Один клик = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для улучшения!");
            }
        }

        private void Upgrade6_Click(object sender, EventArgs e)
        {
            if (coin >= 20000000)
            {

                coin -= 20000000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetClickPower();
                SettingsManager.SetClickPower(CurrentPower + 1000);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetClickPower();
                ClickPowerLabel.Text = "Один клик = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для улучшения!");
            }
        }

        private void Upgrade7_Click(object sender, EventArgs e)
        {
            if (coin >= 350000000)
            {

                coin -= 350000000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetClickPower();
                SettingsManager.SetClickPower(CurrentPower + 2500);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetClickPower();
                ClickPowerLabel.Text = "Один клик = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для улучшения!");
            }
        }

        private void Upgrade8_Click(object sender, EventArgs e)
        {
            if (coin >= 5000000000)
            {

                coin -= 5000000000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetClickPower();
                SettingsManager.SetClickPower(CurrentPower + 50000);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetClickPower();
                ClickPowerLabel.Text = "Один клик = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для улучшения!");
            }
        }

        private void Investment1_Click(object sender, EventArgs e)
        {
            if (coin >= 2500)
            {

                coin -= 2500;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetPassiveUp();
                SettingsManager.SetPassiveUp(CurrentPower + 5);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetPassiveUp();
                InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для инвестиции!");
            }
        }

        private void Investment2_Click(object sender, EventArgs e)
        {
            if (coin >= 7500)
            {

                coin -= 7500;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetPassiveUp();
                SettingsManager.SetPassiveUp(CurrentPower + 10);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetPassiveUp();
                InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для инвестиции!");
            }
        }

        private void Investment3_Click(object sender, EventArgs e)
        {
            if (coin >= 75000)
            {

                coin -= 75000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetPassiveUp();
                SettingsManager.SetPassiveUp(CurrentPower + 25);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetPassiveUp();
                InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для инвестиции!");
            }
        }

        private void Investment4_Click(object sender, EventArgs e)
        {
            if (coin >= 750000)
            {

                coin -= 750000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetPassiveUp();
                SettingsManager.SetPassiveUp(CurrentPower + 75);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetPassiveUp();
                InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для инвестиции!");
            }
        }

        private void Investment5_Click(object sender, EventArgs e)
        {
            if (coin >= 7500000)
            {

                coin -= 7500000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetPassiveUp();
                SettingsManager.SetPassiveUp(CurrentPower + 3500);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetPassiveUp();
                InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для инвестиции!");
            }
        }

        private void Investment6_Click(object sender, EventArgs e)
        {
            if (coin >= 75000000)
            {

                coin -= 75000000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetPassiveUp();
                SettingsManager.SetPassiveUp(CurrentPower + 35000);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetPassiveUp();
                InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для инвестиции!");
            }
        }

        private void Investment7_Click(object sender, EventArgs e)
        {
            if (coin >= 750000000)
            {

                coin -= 750000000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetPassiveUp();
                SettingsManager.SetPassiveUp(CurrentPower + 75000);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetPassiveUp();
                InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для инвестиции!");
            }
        }

        private void Investment8_Click(object sender, EventArgs e)
        {
            if (coin >= 7500000000)
            {

                coin -= 750000000;
                CoinLabel.Text = coin.ToString();

                double CurrentPower = SettingsManager.GetPassiveUp();
                SettingsManager.SetPassiveUp(CurrentPower + 150000);

                SettingsManager.SetCoins(coin);
                SettingsManager.Save();
                double newCurrentPower = SettingsManager.GetPassiveUp();
                InvestmentPowerLabel.Text = "Диведент от инвестиций в секунду = " + newCurrentPower.ToString() + "$";

            }
            else
            {
                MessageBox.Show("Недостаточно монет для инвестиции!");
            }
        }
        //Кнопки апгрейдов


    }
}
