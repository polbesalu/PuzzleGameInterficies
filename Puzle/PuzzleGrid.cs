using System.Windows.Controls;

namespace Puzle
{
    internal class PuzzleGrid : Grid
    {
        public PuzzleButton Forat { get; set; }
        public int NFiles { get; set; }
        public int NColumnes { get; set; }
        public int[] PosicionsFitxes { get; set; }
        public int NCorrectes { get; set; }
    }
}
