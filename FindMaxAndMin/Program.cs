Console.WriteLine("Enter arary element with space between two elements");
string inputAsArray = Console.ReadLine();
int[] arr = Array.ConvertAll(inputAsArray.Split(' '), int.Parse);
int max = arr[0], min = arr[0];
for (int i = 0; i < arr.Length - 1; i++)
{
    if (max < arr[i]) max = arr[i];
    if (min > arr[i]) min = arr[i];
}

Console.WriteLine($"max element of given array is {max} and min element is {min}");
Console.ReadLine();

