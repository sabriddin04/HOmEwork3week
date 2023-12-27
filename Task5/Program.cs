List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };

List<int> evenNumbers=new List<int>();
evenNumbers.AddRange(numbers.FindAll(x=>x%2==0));
foreach(int number in evenNumbers)
{
 Console.WriteLine(number);
}
