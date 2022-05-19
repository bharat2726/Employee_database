using System;
using System.Windows;

namespace Employee_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RecordsList rl;
        AddRecord ar;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void View_List(object sender, RoutedEventArgs e)
        {
            if (rl == null)
            {
                rl = new RecordsList();
                rl.Owner = this;
                rl.Closed += Rl_Closed;
                rl.Show();
            }
        }

        private void Rl_Closed(object sender, EventArgs e)
        {
            rl = null;
        }

        private void Add_Record(object sender, RoutedEventArgs e)
        {
            if (ar == null)
            {
                ar = new AddRecord();
                ar.Owner = this;
                ar.Closed += Ar_Closed;
                ar.Show();
            }
        }

        private void Ar_Closed(object sender, EventArgs e)
        {
            ar = null;
        }
    }
}
