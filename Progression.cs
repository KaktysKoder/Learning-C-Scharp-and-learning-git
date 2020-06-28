using System.Collections;
using System.Collections.Generic;

namespace SetTypes
{
    class Progression : IEnumerable<int>
    {
        private readonly int _itemCount;    //Максимальное кол-во чисел в последовательности.

        public Progression(int itemCount)
        {
            _itemCount = itemCount;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int current = 1;

            for (int i = 0; i < _itemCount - 1; i++)
            {
                if (i == 0) yield return 1;

                current += 3;

                yield return current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
