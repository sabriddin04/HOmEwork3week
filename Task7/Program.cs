List<int>numbers =new List<int>(){1,2,3,4,5,1,2,1,5};
numbers.Remove(3);
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}
