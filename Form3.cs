using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayYourBills
{
    public partial class GamePauseForm : Form
    {

        private double coin;
        public GamePauseForm(double currentCoin)
        {
            InitializeComponent();
            coin = currentCoin;
        }
        private void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                EnableControls(c);
            }
            con.Enabled = true;
        }
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        

        private void GamePauseForm_Load(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {

                if (form is GameForm)
                {
                    EnableControls(form);
                }
            }
            foreach (Form form in Application.OpenForms)
            {
                if(form is GameForm)
                {
                    DisableControls(form);
                }

            }
        }

        private void SaveAndExitbtn_Click(object sender, EventArgs e)
        {

            SettingsManager.SetCoins(coin); // Устанавливаем новое значение монет
            SettingsManager.Save();

            foreach (Form form in Application.OpenForms)
            { 
                if (form is GameForm)
                {
                    form.Close();
                    break;
                }
            
            }

            MenuForm menuForm = new MenuForm();
            menuForm.Show();

            foreach (Form form in Application.OpenForms)
            {
                if (form is GamePauseForm)
                {
                    form.Close();
                    break;
                }

            }

        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is GameForm)
                {
                    EnableControls(form);
                    break;
                }

            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is GamePauseForm)
                {
                    form.Close();
                    break;
                }

            }
        }

        
    }
}
