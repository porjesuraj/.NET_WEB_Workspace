using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Library
{
    internal class TStack<T>
    {
        Entry? _top;

        public void Push(T Tdata)
        {
            _top = new Entry(next: _top, tData: Tdata);
        }


        public T Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException();
            }

            T data = _top.TData;

            _top = _top.Next;
            return data;
        }




        class Entry
        {
            public Entry Next { get; set; }

            public T TData { get; set; }

            public Entry(TStack<T>.Entry next, T tData)
            {
                Next = next;
                TData = tData;
            }
        }

    }
}
