List<int>randomNumbers=new List<int>();
Random random=new Random();
for (int i = 0; i < 5; i++)
{
    int randomNumber=random.Next(1,100);
    randomNumbers.Add(randomNumber);
}

foreach (var item in randomNumbers)
{
    System.Console.WriteLine(item);
}
