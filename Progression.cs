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
            return new ProgressionIterator(_itemCount);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
