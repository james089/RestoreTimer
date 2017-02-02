using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

        int focusSpanMinues;                                // pre-set minutes, your focusing time span
        TimeSpan setTime;
        int setValue;                                       // Convert set time to a value (how many seconds)
        TimeSpan nowTime;
        int nowValue;                                       //Indicates how long you have been worked
        int leftValue;                                      // Left value (seconds) from last working period
        int elapsedValue;

        SoundPlayer click_sound = new SoundPlayer(System.Environment.CurrentDirectory + @"\Res\camera-shutter-click-03.wav");
        SoundPlayer redAlert_sound = new SoundPlayer(System.Environment.CurrentDirectory + @"\Res\redAlert.wav");

        public MainWindow()
        {
            InitializeComponent();
            mMode = mode.rest;
            resetAll();
            timeUpdate();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        bool mainInterface = true;
        private void moreButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainInterface)
            {
                timeSelector.Visibility = Visibility.Visible;
                progressRing.Visibility = Visibility.Hidden;
                timeSelector.timeUpdate();
                mainInterface = false;
            }
            else
            {
                timeSelector.Visibility = Visibility.Hidden;
                progressRing.Visibility = Visibility.Visible;
                mainInterface = true;
                timeUpdate();
            }
        }

        private void timeUpdate()
        {
            focusSpanMinues = Properties.Settings.Default.Time;
            setTime = new TimeSpan(0, 0, focusSpanMinues, 0, 0);
            setValue = setTime.Minutes * 60;
            TB_time.Content = (setTime).ToString();
        }

        private void progressRing_CenterBtn_clicked(object sender, EventArgs e)
        {
            click_sound.Play();
            if (progressRing.Value == 100 && mMode == mode.rest)                  //if not 100, you can't work!
            {
                mMode = mode.work;
                decreaseEngergy();
            }
            else if (mMode == mode.work)
            {
                timer.Stop();
                timer.Tick -= Timer_Tick_drop;
                mMode = mode.rest;
                restoreEngergy();
            }
            else if (mMode == mode.rest)
            {
                timer.Stop();
                timer.Tick -= Timer_Tick_restore;
                progressRing.Text = "Have more rest!";
            }
        }

        #region drop energy
        private void decreaseEngergy()
        {
            nowTime = new TimeSpan(0, 0, 0, 0, 0);

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,0, 1, 0);
            timer.Tick += Timer_Tick_drop;
            timer.Start();
        }

        private void Timer_Tick_drop(object sender, EventArgs e)
        {
            nowTime += timer.Interval;
            nowValue = nowTime.Minutes * 60 + nowTime.Seconds;                     

            if (progressRing.Value > p.warningLevel)
            {
                progressRing.Text = "Now working!";
                TB_time.Foreground =
                progressRing.TValue.Foreground =
                progressRing.TText.Foreground = Brushes.White;
                TB_time.Content = (setTime - nowTime).ToString();
            }  
            if (progressRing.Value > p.dyingLevel && progressRing.Value <= p.warningLevel)
            {
                progressRing.Text = "Take it easy...";
                TB_time.Foreground =
                progressRing.TValue.Foreground = 
                progressRing.TText.Foreground = Brushes.Yellow;
                TB_time.Content = (setTime - nowTime).ToString();
            }
            if (progressRing.Value > 0 && progressRing.Value <= p.dyingLevel)   //this time, time left is already 0;
            {
                progressRing.Text = "Time to have a rest!\nClick to start a rest";
                redAlert_sound.Play();
                TB_time.Foreground =
                progressRing.TValue.Foreground =
                progressRing.TText.Foreground = Brushes.Red;
                TB_time.Content = (setTime - nowTime).ToString();
            }
            leftValue = (int)engergyDecrease(fitAlg.linear, nowValue);
            progressRing.Value = Convert.ToByte(leftValue);
            elapsedValue = nowValue;
        }

        private double engergyDecrease(fitAlg fit, int x)
        {
            double result = 0;
            switch (fit)
            {
                case fitAlg.linear:
                    result = -((double)100 / (double)setValue) * x + 100;
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
        #endregion drop energy

        #region  restore energy

        private void restoreEngergy()
        {
            nowTime = new TimeSpan(0, 0, 0, 0, 0);

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.Tick += Timer_Tick_restore;
            timer.Start();
        }
        private void Timer_Tick_restore(object sender, EventArgs e)
        {
            nowTime += timer.Interval;
            nowValue = nowTime.Minutes * 60 + nowTime.Seconds;

            progressRing.Text = "Restoring!";
            TB_time.Foreground =
            progressRing.TValue.Foreground =
            progressRing.TText.Foreground = Brushes.White;
            TB_time.Content = (nowTime).ToString();
            progressRing.Value = Convert.ToByte(engergyIncrease(nowValue));

        }
        private double engergyIncrease(int x)
        {
            double result = 0;
            result = ((double)(100 - leftValue) / (elapsedValue / p.restoreSpeed)) * x + leftValue;
            if (result < 100)
                return result;
            else 
            {
                resetAll();
                return 100;
            }
        }

        #endregion  restore energy

        private void resetAll()
        {
            progressRing.Text = "Click to start working";
            leftValue = 0;                                      // Left value (seconds) from last working period
            elapsedValue = 0;
            if (timer != null)
                timer.Tick -= Timer_Tick_restore;
            nowTime = new TimeSpan(0,0,0,0,0);
            TB_time.Content = (nowTime).ToString();
        }




        /*
        bool _mouseDown;
        Point p0, p1;
        double k0, k1, theta;
        Point center = new Point(200, 200);

        private void selector_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mouseDown = true;
            p0 = Mouse.GetPosition(selector);
            k0 = (p0.Y - center.Y) / (p0.X - center.X);
            selector.Arrow.RenderTransform = new RotateTransform(0, center.X, center.Y);
            selector.Text = "45 min";
        }
        private bool mouseInArrow(Point p)
        {
            if (p.X > center.X - 15 && p.X < center.X + 15
                && p.Y > center.Y * 2 - 20 && p.Y < center.Y * 2)
                return true;
            else
                return false;
        }
        private void selector_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Cursor = Cursors.Hand;
                p1 = Mouse.GetPosition(selector);
                k1 = (p1.Y - center.Y) / (p1.X - center.X);
                theta = Math.Atan((k1 - k0) / (1 + k0 * k1)) * 180 / Math.PI;
                if (theta < 89 && theta > -89 )
                {
                    selector.Arrow.RenderTransform = new RotateTransform(theta, center.X, center.Y);
                    selector.Text = (45 + theta * (35f / 90)).ToString("#") + " min";
                }
                else
                    _mouseDown = false;
            }
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            _mouseDown = false;
            p0 = new Point();
            p1 = new Point();
            k0 = 0;
            k1 = 0;
        }

        */
    }
}
