using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using NMeCab;

namespace NMeCabDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var started = DateTime.UtcNow;
            Tagger = NMeCabIpaDic.CreateTagger();
            ElapsedTime.DataContext = DateTime.UtcNow - started;
            OutputGrid.ItemsSource = new MeCabIpaDicNode[0]; // to initialize the DataGrid column header
        }

        private MeCabIpaDicTagger Tagger;

        private bool Busy
        {
            get { return !IsEnabled; }
            set
            {
                IsEnabled = !value;
                Cursor = value ? Cursors.Wait : null;
            }
        }

        private async void GoButton_Click(object sender, RoutedEventArgs e)
        {
            if (Busy) return;
            Busy = true;
            try
            {
                var input = Input.Text;
                var started = DateTime.UtcNow;
                var output = await Task.Run(() => Tagger.Parse(input));
                ElapsedTime.DataContext = DateTime.UtcNow - started;
                OutputGrid.ItemsSource = output;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Exception");
            }
            finally
            {
                Busy = false;
            }
        }
    }
}
