using System;

namespace Bubblesort
{
    public class BubbleSorter
    {
        public void Sort(string[] source,  Func<string, string, int> comparator)
        {
            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = i + 1; j < source.Length; j++)
                {
                    if (comparator(source[i], source[j]) > 0)
                    {
                        string buffer = source[i];
                        source[i] = source[j];
                        source[j] = buffer;
                    }
                }
            }
        }

    }
}