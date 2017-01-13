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
    /// Interaction logic for ProgressRing.xaml
    /// </summary>
    public partial class ProgressRing : UserControl
    {
        public static DependencyProperty ValueProperty;
        public event EventHandler CenterBtn_clicked;

        public ProgressRing()
        {
            ValueProperty = DependencyProperty.Register("Value", typeof(byte), typeof(ProgressRing), new FrameworkPropertyMetadata((byte)0, new PropertyChangedCallback(OnValueChanged)));
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(ProgressRing), new FrameworkPropertyMetadata("-", new PropertyChangedCallback(OnTextChanged)));
            InitializeComponent();
        }

        public byte Value
        {
            get { return (byte)GetValue(ValueProperty);}
            set { SetValue(ValueProperty, value);}
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ProgressRing progressRing = (ProgressRing)d;

            // Color change
            if (progressRing.Value > 100) progressRing.Value = 100;
            if (progressRing.Value >= p.warningLevel) progressRing.EllipseFill.Fill = Brushes.Green;
            if (progressRing.Value >= p.dyingLevel && progressRing.Value < p.warningLevel) progressRing.EllipseFill.Fill = Brushes.Yellow;
            if (progressRing.Value >= 0 && progressRing.Value < p.dyingLevel) progressRing.EllipseFill.Fill = Brushes.Red;
            if (progressRing.Value < 0) progressRing.Value = 0;
            // Arc shape change
            progressRing.EllipseFill.StartAngle = (100 - progressRing.Value) * 0.01 * 360;
            // Display value change
            progressRing.TValue.Text = progressRing.Value.ToString() + "%";
        }

        public static DependencyProperty TextProperty;
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ProgressRing progressRing = (ProgressRing)d;
            progressRing.TText.Text = progressRing.Text;
        }

        private void Btn_center_Click(object sender, RoutedEventArgs e)
        {
            if (this.CenterBtn_clicked != null)
                CenterBtn_clicked(new object(), new EventArgs());
        }
    }
}
