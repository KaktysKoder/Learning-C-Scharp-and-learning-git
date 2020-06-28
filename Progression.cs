using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SetTypes
{
    class Progression : IEnumerable<int>
    {
        private readonly int _itemCount; //Максимальное кол-во последовательностей

        public Progression(int itemCount)
        {
            this._itemCount = itemCount;
        }

        //Обобщенный GetEnumerator()
        public IEnumerator<int> GetEnumerator()
        {
            //int current = 1;

            //for (int i = 0; i < _itemCount - 1; i++)
            //{
            //    if (i == 0)
            //    {
            //        yield return 1;
            //    }

            //    current += 3;

            //    yield return current;
            //}

            // ProgressionIterator описание IEnumerator
            return new ProgressionIterator(_itemCount);
        }

        //Не обобщенный GetEnumerator() который сводится к вызыву обощ метода 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
