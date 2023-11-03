using System.Windows;

namespace Puzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
             InitializeComponent();
        }

        private void btnComenca_Click(object sender, RoutedEventArgs e)
        {
            wndPuzle wndPuzzle = new((int)sldFiles.Value, (int)sldColumnes.Value);
            wndPuzzle.Owner = this;
            this.Hide();
            wndPuzzle.Show();
        }
    }
}
