using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Dynamic_Array;

namespace Task4.DynamicArrayHardcoremode
{
    public class CycledDynamicArray<T> : DynamicArray<T>, IEnumerable<T>, IEnumerator<T>
    {
        private int pos;
        public CycledDynamicArray()
        {
        }

        public CycledDynamicArray(int n) : base(n)
        {
        }

        public CycledDynamicArray(IEnumerable<T> mas, int length) : base(mas, length)
        {
        }

        public new IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return base.GetEnumerator();
        }


        public T Current => this.Array[pos];

        object IEnumerator.Current => this.Array[pos];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            pos++;
            pos %= this.Length;
            if (Current != null)
            {
                return true;
            }
            return false;
        }
        public void Reset()
        {
            this.pos = 0;
        }
    }
}
