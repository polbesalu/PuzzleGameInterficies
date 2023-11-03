using System.Windows;
using System.Windows.Controls;

namespace Puzle
{
    public class PuzzleButton : Button
    {
        public int NActual { get; set; }
        public int NObjectiu { get; set; }
        public int Fila { get; set; }
        public int Columna { get; set; }
        public bool IsCorrect { get; set; } = false;
        public bool Refresh
        {
            get => (bool)GetValue(RefreshDP);
            set => SetValue(RefreshDP, value);
        }

        public static readonly DependencyProperty RefreshDP =
            DependencyProperty.Register(
                name: "Refresh",
                propertyType: typeof(bool),
                ownerType: typeof(PuzzleButton),
                typeMetadata: new FrameworkPropertyMetadata(defaultValue: false)
                );
    }
}
