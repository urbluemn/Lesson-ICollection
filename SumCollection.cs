using System.Reflection.Metadata;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson.ICollection
{
    public class SumCollection : IEnumerable
    {
        private readonly SumEnumerator SumEnum;
        private List<int> intList = new List<int>();
        public SumCollection() => SumEnum = new SumEnumerator(intList);

        public void Add(int i)
        {
            intList.Add(i);
        }

        public void AddRange(int[] arri)
        {
            intList.AddRange(arri);
        }

        public void Get()
        {
           Console.WriteLine(SumEnum.Current);
        }

        public IEnumerator GetEnumerator()
        {
            return SumEnum;
            // for(int i = 0; i<intList.Count-1; i++)
            // {
            //     yield return intList[i] + intList[i+1];
            // }
        }
    }

    public class SumEnumerator : IEnumerator
    {
        int index = -1;
        private List<int> intList = new List<int>();
        public SumEnumerator(List<int> intList) => this.intList = intList;
        public object Current => index < 0 ? intList[index+1] : intList[index] + intList[index+1];

        public bool MoveNext()
        {
            if(index<intList.Count-2)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}