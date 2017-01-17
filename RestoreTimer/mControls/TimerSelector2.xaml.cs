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

namespace RestoreTimer.mControls
{
    /// <summary>
    /// Interaction logic for TimerSelector.xaml
    /// </summary>
    public partial class TimerSelector2 : UserControl
    {
        public static DependencyProperty TextProperty;
        public TimerSelector2()
        {
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(TimerSelector), new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnTextChanged)));
            InitializeComponent();
        }

        private void UserControl_GotFocus(object sender, RoutedEventArgs e)
        {
            timeUpdate();
        }

        private void UserControl_LostFocus(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TimerSelector2 selector = (TimerSelector2)d;
            selector.TText.Text = selector.Text;
        }

        private void Btn_down_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Time -= 5;
            timeUpdate();
        }

        private void Btn_up_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Time += 5;
            timeUpdate();
        }
        /*
        private void Btn_center_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        */
        public void timeUpdate()
        {
            TText.Text = Properties.Settings.Default.Time + " min";
        }

    }
}
