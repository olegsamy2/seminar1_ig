//  Напишите программу, которая на вход принимает число (N), 
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Ввведите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int counter = 1; 
Console.Write("четные числа из диапозона {1..." + N + "}:  ");
while (counter < N)
{
    Console.Write((counter+1) + " ");
    // or Console.WriteLine(counter++);
    counter+=2;
}
