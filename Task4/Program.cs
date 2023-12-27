List<double> numbers = new List<double>{ 3.5, 2.7, 6.9, 1.2 };
List<double> doubles=new List<double>();
doubles.AddRange(numbers);

double sum=0;
foreach (var item in doubles)
{
    sum+=item;

}
Console.WriteLine("The average value of all the elements in the list is: " + sum/(doubles.Count()));