using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaFracciones
{
    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public T[] Sort(T[] list)
        {
            T[] result = (T[])list.Clone();
            QuickSort(result, 0, result.Length - 1);
            return result;
        }

        private void QuickSort(T[] data, int min, int max)
        {
            int partition;
            if ((max - min) > 0)
            {
                partition = FindPartition(data, min, max);
                QuickSort(data, min, partition - 1);
                QuickSort(data, partition + 1, max);
            }
        }

        private int FindPartition(T[] data, int min, int max)
        {
            int left, right;
            T temp, partiton;
            partiton = data[min];
            left = min;
            right = max;
            while (left < right)
            {
                while (data[left].CompareTo(partiton) <= 0 && left < right)
                {
                    left++;
                }
                while (data[right].CompareTo(partiton) > 0)
                {
                    right--;
                }
                if (left < right)
                {
                    temp = data[left];
                    data[left] = data[right];
                    data[right] = temp;
                }
            }
            temp = data[min];
            data[min] = data[right];
            data[right] = temp;

            return right;
        }
    }
}