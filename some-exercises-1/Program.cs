
int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
}

int[] numbers1 = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine(numbers.Sum());

int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };
int result = 1;
int i = 0;

while (i < numbers2.Length)
{
    result *= numbers2[i];
    i++;
}
Console.WriteLine(result);

int getN = int.Parse(Console.ReadLine());
int res = 0;
for (int r = 0; r < getN + 1; r++)
{
    res += r;
}

Console.WriteLine(res);

int cube = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Pow(cube, 3));