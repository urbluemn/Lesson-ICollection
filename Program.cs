using Lesson.ICollection;

var sum = new SumCollection();

int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

sum.AddRange(arr);

foreach(var i in sum)
{
    System.Console.WriteLine(i);
}

Console.ReadLine();