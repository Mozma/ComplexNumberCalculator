using System;
using System.Windows;

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
        public event EventHandler EqlEvent = null;
        public event EventHandler ClrEvent = null;

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

        private void btnEql_Click(object sender, RoutedEventArgs e)
        {
            EqlEvent.Invoke(sender, e);
        }
    }
}
