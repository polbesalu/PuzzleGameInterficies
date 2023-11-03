using System.Windows;

namespace Puzle
{
    /// <summary>
    /// Interaction logic for wndPausa.xaml
    /// </summary>
    public partial class wndPausa : Window
    {
        public wndPausa()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnReiniciar_Click(object sender, RoutedEventArgs e)
        {
            wndPuzle wndPare = (wndPuzle)Window.GetWindow(this.Owner);
            wndPare.ReiniciarGrid(wndPare.grdPuzle.PosicionsFitxes);
            wndPare.IniciarRellotge();
            this.Close();
        }

        private void btnInici_Click(object sender, RoutedEventArgs e)
        {
            wndPuzle wndPare = (wndPuzle)Window.GetWindow(this.Owner);
            wndPare.Close();
            this.Close();
        }
    }
}
