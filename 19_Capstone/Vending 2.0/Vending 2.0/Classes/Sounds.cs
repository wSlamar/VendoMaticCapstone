using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Vending_2._0
{
    class Sounds
    {

        public void Player()
        {
            SoundPlayer splayer = new SoundPlayer(Vending_2._0.Properties.Resources.click);
            splayer.Play();

            //SoundPlayer splayer = new SoundPlayer(@"C:\Users\Student\Git\c-module-1-capstone-team-3\19_Capstone\Vending 2.0\img\click.wav");
            //splayer.Play();
        }
    }
}
