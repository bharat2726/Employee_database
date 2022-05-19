using System;
using System.Windows;
using System.Windows.Controls;

namespace Employee_Database
{
    /// <summary>
    /// Interaction logic for RecordsList.xaml
    /// </summary>
    public partial class RecordsList : Window
    {
        readonly VM vm;
        Details details;

        public RecordsList()
        {
            InitializeComponent();
            vm = VM.Instance;//
            DataContext = vm;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (details == null)
            {
                details = new Details();
                details.Owner = this;
                details.Closed += Details_Closed;
                details.Show();
            }
        }

        private void Details_Closed(object sender, EventArgs e)
        {
            details = null;
        }

        private void Close_RecordList(object sender, RoutedEventArgs e)
        {
            RecordList.SelectedIndex = -1; //
            this.Close();
        }
    }
}
