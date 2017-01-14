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
    public partial class TimerSelector : UserControl
    {
        public static DependencyProperty TextProperty;
        public TimerSelector()
        {
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(TimerSelector), new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnTextChanged)));
            InitializeComponent();
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TimerSelector selector = (TimerSelector)d;
            selector.TText.Text = selector.Text;
        }
    }
}
