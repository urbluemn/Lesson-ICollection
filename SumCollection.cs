using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson.ICollection
{
    public class SumCollection : IEnumerable
    {

        private List<int> intList = new List<int>();

        public void Add(int i)
        {
            intList.Add(i);
        }

        public void AddRange(int[] arri)
        {
            intList.AddRange(arri);
        }

        public IEnumerator GetEnumerator()
        {
            var current = 0;
            for(int i = current+1; i<intList.Count; i++)
            {
                yield return intList[current] + intList[i];
                current++;
            }
            }
    }

    public class SumEnumerator : IEnumerator
    {
        int index = -1;
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}