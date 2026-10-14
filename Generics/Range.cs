using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced_Task.Generics
{
    public class Range<T> where T : IComparable<T>
    {
        private T Min;
        private T Max;

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min cannot be greater than Max.");

            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public dynamic Length()
        {
            dynamic minVal = Min;
            dynamic maxVal = Max;
            return maxVal - minVal;            
        }
    }
}