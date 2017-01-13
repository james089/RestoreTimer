using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RestoreTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        mode mMode;
        DispatcherTimer timer;

        int focusSpanMinues;                                //pre-set minutes, your focusing time span
        TimeSpan setTime;
        int setValue;
        TimeSpan nowTime = new TimeSpan(0, 0, 0, 0, 0);

        public MainWindow()
        {
            InitializeComponent();
            focusSpanMinues = Properties.Settings.Default.Time;
        }

        private void progressRing_CenterBtn_clicked(object sender, EventArgs e)
        {
            if (progressRing.Value == 100)
            {
                mMode = mode.work;
                progressRing.Text = "Now working!";
                decreasePoint();
            }
        }

        private void decreasePoint()
        {
            setTime = new TimeSpan(0, 0, 1, 0, 0); //new TimeSpan(0, 0, focusSpanMinues, 0, 0);
            setValue = setTime.Minutes * 60;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,0, 1, 0);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            nowTime += timer.Interval;
            int nowValue = nowTime.Minutes * 60 + nowTime.Seconds;

            TB_time.Text = nowTime.ToString();
            progressRing.Value = Convert.ToByte(engergyDecrease(fitAlg.gradient, nowValue));
        }

        private double engergyDecrease(fitAlg fit, int x)
        {
            double result = 0;
            switch (fit)
            {
                case fitAlg.linear:
                    result = ((double)100 / (double)setValue) * x;
                    if (result >= 0)
                        return result;
                    else
                        return 0;
                case fitAlg.gradient:
                    double a1 = (Math.Pow(1f / p.dyingLevel, 1f / 3) - Math.Pow(1f / 100, 1f / 3)) / setValue;
                    double a2 = Math.Pow(1f / 100, 1f / 3);
                    result = 1f / Math.Pow(a1 * x + a2, 3);
                    return result;
            }
            return result;

        }
    }
}
