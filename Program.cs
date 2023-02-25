using Lesson.ICollection;

var sum = new SumCollection();

int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

sum.AddRange(arr);

var sumEnum = sum.GetEnumerator();

System.Console.WriteLine(sumEnum.Current);

sum.Get();

foreach(var i in sum)
{
    System.Console.WriteLine(i);
    sum.Get();
}

Console.ReadLine();