using System.Collections.Generic;

namespace Puzle
{
    public static class Extensions
    {
        public static void Swap<T>(this List<T> list, PuzzleButton i, PuzzleButton j)
        {
            T temp = list[i.NActual - 1];
            list[i.NActual - 1] = list[j.NActual - 1];
            list[j.NActual - 1] = temp;
        }
    }
}
