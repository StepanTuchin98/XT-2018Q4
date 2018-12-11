using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Dynamic_Array;

namespace Task4.DynamicArrayHardcoremode
{
    public class DynamicArrayHardcoremode<T> : DynamicArray<T>, ICloneable
    {
        #region ctors
        public DynamicArrayHardcoremode()
        {
        }

        public DynamicArrayHardcoremode(int n) : base(n)
        {
        }

        public DynamicArrayHardcoremode(IEnumerable<T> mas, int length) : base(mas, length)
        {
        }

        #endregion ctors

        public new T this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    return base[index];
                }

                return base[index + this.Length];
            }

            set
            {
                if (index >= 0)
                {
                    base[index] = value;
                }

                base[index + this.Length] = value;
            }
        }

        #region methods
        public void SetCapacity(int index)
        {
            if (index < this.Length)
            {
                this.Length = index;
            }

            var tmp = new T[index];
            for (var i = 0; i < index && i < this.Capacity; i++)
            {
                tmp[i] = this.Array[i];
            }

            this.Array = tmp;
        }

        public object Clone()
        {
            var tmp = new DynamicArrayHardcoremode<T>(this.Capacity);
            tmp.AddRange(this.Array, this.Length);
            tmp.Length = this.Length;
            return tmp;
        }

        public T[] ToArray()
        {
            var res = new T[this.Length];
            for (var i = 0; i < this.Length; i++)
            {
                res[i] = this.Array[i];
            }

            return res;
        }

        #endregion methods
    }
}
