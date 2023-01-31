Console.WriteLine("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomArray(numbers);
GetArray(numbers);
int sum = 0;

for (int oddposition = 0; oddposition < numbers.Length; oddposition+=2)
    sum = sum + numbers[oddposition];
    Console.WriteLine($"Сумма " + sum);

void RandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,100);
        }
}
void GetArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}