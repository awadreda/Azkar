using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data
    ;
using System.Linq;

namespace WindowsFormsApp1
{
    public static class clsAZKARlogic
    {
        public static int TimerDurration = 5000 * 60;





        public static void FireNotfiy(NotifyIcon notifyIcon , ref Timer timer)
        {
            //notifyIcon.Icon = SystemIcons.Application;
            timer.Interval = TimerDurration;

            notifyIcon.BalloonTipText = AzkariDataBase.GetRandowZekr();
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(3000);

            
        }


        public static void setTheTimer ( NumericUpDown NumericUpDown,ref int timerDurration,ref Timer timer)
            {
            timerDurration = Convert.ToInt16(NumericUpDown.Value);
            timer.Interval = 1000 * 60 * timerDurration;

                }


        public static DataTable GetAzkarList()
        
        {
            return AzkariDataBase.Azkarlist();
        }


        public static bool AddZekir(string zekir)
        {
            return AzkariDataBase.AddZekr(zekir);
        }


        public static bool DeleteZekir(int ID)
        {
            return AzkariDataBase.Delete(ID);
        }

    }
}
