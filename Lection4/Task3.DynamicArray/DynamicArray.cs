using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Dynamic_Array
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        #region fields

        private const int startCapacity = 8;
        public T[] Array { get; set; }
        public int Capacity { get; protected set; }
        public int Length { get; protected set; }

        #endregion fields

        #region ctors
        public DynamicArray()
        {
            this.Array = new T[startCapacity];
            this.Length = 0;
            this.Capacity = startCapacity;
        }

        public DynamicArray(int Capacity)
        {
            this.Array = new T[Capacity];
            this.Length = 0;
            this.Capacity = Capacity;
        }

        public DynamicArray(IEnumerable<T> mas, int length)
        {
            
            this.Length = 0;
            this.Capacity = 2 * length;
            this.Array = new T[Capacity];
            foreach (var item in mas)
            {
                Add(item);
            }
            
        }

        #endregion ctors

        #region methods
        public void Add(T item)
        {
            if(this.Capacity - this.Length == 0)
            {
                Allocate();
            }
            else
            {
                this.Array[this.Length] = item;
                this.Length++;
            }
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
            this.Array = new T[Capacity];
            this.Length = 0;
            AddCol(tmp);
        }

        public void Allocate(int fullLenght)
        {
            var tmp = this.Array;
            this.Capacity = fullLenght;
            this.Array = new T[Capacity];
            this.Length = 0;
            AddCol(tmp);
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
            if(IsCorrect(index))
            {
                return false;
            }
            else if(index == this.Length)
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
                Allocate(fullLenght);
                AddCol(collection);
            }
            else
            {
                AddCol(collection);
            }
        }


      
        public bool IsCorrect(int index)
        {
            if (index < 0 || index > this.Length)
            {
                return false;
            }
            return true;
        }

            #endregion methods
        }
}
