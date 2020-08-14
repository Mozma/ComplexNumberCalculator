using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ComplexNumberCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler AddEvent = null;
        public event EventHandler SubEvent = null;
        public event EventHandler MulEvent = null;
        public event EventHandler DivEvent = null;
        public event EventHandler ClrEvent = null;
        public event EventHandler CopyEvent = null;
     
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEvent.Invoke(sender, e);
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            SubEvent.Invoke(sender, e);      
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            MulEvent.Invoke(sender, e);
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            DivEvent.Invoke(sender, e);
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            ClrEvent.Invoke(sender, e);
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            CopyEvent.Invoke(sender, e);
        }

        #region Text input check.
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !((Char.IsDigit(e.Text, 0) || ((e.Text == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString()) && (DS_Count(((TextBox)sender).Text) < 1))));
        }        
        public int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }
        #endregion

    }
}
