using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayYourBills
{
    internal class GameSettings
    {
        public bool IsFullscreen { get; set; } = false;
        public double Coin { get; set; } = 0;

        public double PassiveUp { get; set; } = 0;  // Количество монет за секунду
        public double ClickPower { get; set; } = 1;  // Количество монет за клик

    }
}
