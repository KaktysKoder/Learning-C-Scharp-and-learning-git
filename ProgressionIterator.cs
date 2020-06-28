using System.Collections;
using System.Collections.Generic;

namespace SetTypes
{
    internal class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount; //Max count element
        private int _position; //текщий номер последовательности
        private int _current;//текщий значение последовательности

        public ProgressionIterator(int itemCount)
        {
            _itemCount = itemCount;
            _current = 1;
            _position = 0;
        }

        #region Реализация интерфейса IEnumerator<int> IEnumerator
        public void Dispose()
        {
            //заглушка
        }

        public bool MoveNext()
        {
            //MoveNext осущ движение по последовательности и вычисления текущ эл

            //Смотрим позиция += 3
            if (_position > 0)
            {
                _current += 3;
            }

            //проверка на макс лимит
            if(_position < _itemCount)
            {
                _position++;

                //можем
                return true;
            }

            return false;
        }

        public void Reset()
        {
            //сброс состояния
            _position = 0;
            _current = 1;
        }

        public int Current
        {
            //возвращает содержимое переменной текщий значение последовательности
            get { return _current; }
        }

        object IEnumerator.Current
        {
            //Необобщ форма вызывает обобщ форму
            get { return Current; }
        }

        #endregion
    }
}