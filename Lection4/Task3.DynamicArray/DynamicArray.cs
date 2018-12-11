using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Dynamic_Array
{
    public class DynamicArray<T> : IEnumerable<T>
    {

        private const int StartCapacity = 8;

        #region ctors
        public DynamicArray()
        {
            this.Array = new T[StartCapacity];
            this.Length = 0;
            this.Capacity = StartCapacity;
        }

        public DynamicArray(int capacity)
        {
            this.Array = new T[capacity];
            this.Length = 0;
            this.Capacity = capacity;
        }

        public DynamicArray(IEnumerable<T> mas, int length)
        {
            this.Length = 0;
            this.Capacity = 2 * length;
            this.Array = new T[this.Capacity];
            foreach (var item in mas)
            {
                this.Add(item);
            }
        }
        #endregion ctors

        #region fields
        public T[] Array { get; set; }

        public int Capacity { get; protected set; }

        public int Length { get; protected set; }

        public T this[int index]
        {
            get
            {
                if (!this.IsCorrect(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.Array[index];
            }

            set
            {
                if (!this.IsCorrect(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.Array[index] = value;
            }
        }

        #endregion fields

        #region methods
        public void Add(T item)
        {
            if (this.Capacity == this.Length)
            {
                this.Allocate();
            }

            this.Array[this.Length] = item;
            this.Length++;
        }

        public void AddCol(IEnumerable<T> col)
        {
            foreach (var item in col)
            {
                this.Array[this.Length++] = item;
            }
        }

        public void Allocate()
        {
            var tmp = this.Array;
            this.Capacity *= 2;
            this.Array = new T[this.Capacity];
            this.Length = 0;
            this.AddCol(tmp);
        }

        public void Allocate(int fullLenght)
        {
            var tmp = this.Array;
            this.Capacity = fullLenght;
            this.Array = new T[this.Capacity];
            this.Length = 0;
            this.AddCol(tmp);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < this.Length; i++)
            {
                yield return this.Array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Remove(int index)
        {
            if (!this.IsCorrect(index))
            {
                return false;
            }
            else if (index == this.Length)
            {
                this.Length--;
                return true;
            }
            else
            {
                for (int i = index; i < this.Length; i++)
                {
                    this.Array[i] = this.Array[i + 1];
                }

                this.Length--;
                return true;
            }
        }

        public void AddRange(IEnumerable<T> collection, int length)
        {
            int fullLenght = this.Length + length;
            if (fullLenght > this.Capacity)
            {
                this.Allocate(fullLenght);
            }

            this.AddCol(collection);
        }
      
        public bool IsCorrect(int index)
        {
            if (index < 0 || index > this.Length)
            {
                return false;
            }

            return true;
        }

        public bool Insert(T item, int index)
        {
            if (!this.IsCorrect(index))
            {
                return false;
            }

            int fullLenght = this.Length + 1;
            if (fullLenght > this.Capacity)
            {
                this.Allocate();
            }

            for (var i = this.Length - 1; i >= index; i--)
            {
                this.Array[i + 1] = this.Array[i];
            }

            this.Array[index] = item;
            this.Length++;
            return true;
        }

        #endregion methods
    }
}
