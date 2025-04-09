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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {

            SettingsManager.SetCoins(0);  // Устанавливаем 0 монет
            SettingsManager.Save();


            foreach (Form form in Application.OpenForms)
            {
                if (form is GameForm)
                {
                    form.Close();
                    break;
                }

            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is Form4)
                
                {
                    form.Close();
                    break;
                }    
                    
            }

            MenuForm menuForm = new MenuForm();
            menuForm.Show();

        }
    }
}
