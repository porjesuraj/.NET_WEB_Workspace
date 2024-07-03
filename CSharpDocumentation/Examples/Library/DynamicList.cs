using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Library
{

    internal class DynamicList<T>
    {
        const int DefaultCapacity = 4;

        T[] _items;

        int _count;


        public DynamicList(int capacity = DefaultCapacity)
        {

            _items = new T[capacity];

        }


        public int Count => _count;

        public int Capacity
        {
            get
            {
                return _items.Length;
            }

            set
            {
                if (value < _count) value = _count;

                if (value != _items.Length)
                {
                    T[] newItems = new T[value];

                    Array.Copy(_items, 0, newItems, 0, _count);

                    _items = newItems;
                }
            }

        }


        public T this[int index]
        {
            get => _items[index];
            set
            {
                _items[index] = value;
                OnChanged();
            }
        }


        public void Add(T value)
        {
            if (_count == Capacity) Capacity = _count * 2;

            _items[_count] = value;
            _count++;
            OnChanged();

        }






        protected virtual void OnChanged() => Changed?.Invoke(this, EventArgs.Empty);

        public override bool Equals(object obj) => Equals(this, obj as DynamicList<T>);


        static bool Equals(DynamicList<T> a, DynamicList<T> b)
        {
            if (ReferenceEquals(a, null)) return ReferenceEquals(b, null);

            if (ReferenceEquals(b, null) || a._count != b._count)
                return false;

            for (int i = 0; i < a._count; i++)
            {
                if (!Equals(a._items[i], b._items[i]))
                {
                    return false;
                }

            }
            return true;
        }

        public event EventHandler? Changed;

        public static bool operator ==(DynamicList<T> a, DynamicList<T> b) => Equals(a, b);
        public static bool operator !=(DynamicList<T> a, DynamicList<T> b) => !Equals(a, b);

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
