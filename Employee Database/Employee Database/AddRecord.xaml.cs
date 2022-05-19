using System.Windows;

namespace Employee_Database
{
    /// <summary>
    /// Interaction logic for AddRecord.xaml
    /// </summary>
    public partial class AddRecord : Window
    {
        readonly VM vm;
        public AddRecord()
        {
            InitializeComponent();
            vm = VM.Instance;
            DataContext = vm;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            vm.Save();
            Name.Text = "";
            IdNum.Text = "";
            Dep.Text = "";
            Position.Text = "";
            MessageBox.Show("Record Saved!");
            this.Close();
        }
    }
}
