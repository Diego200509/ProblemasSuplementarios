using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaFracciones
{
    public interface ISorter<T> where T:IComparable<T>
    {
        public T[] Sort(T[] list);
    }
}