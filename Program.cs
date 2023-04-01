// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool IsPalindrome(int num)
// {
//     int tempNum = num;
//     int reversNum = 0;
//     int lastDigit = 0;
//     while (tempNum > 0)
//     {
//         lastDigit = tempNum % 10;
//         reversNum = reversNum * 10 + lastDigit;
//         tempNum /= 10;
//     }

//     if (reversNum == num) return true;
//     return false;
// }

// System.Console.Write("Input you number please: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Is your number {num} palindrome?\nResuit: {IsPalindrome(num)}");





// Task 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// double DistRange(double[] arrA, double[] arrB)
// {
//     return Math.Sqrt(Math.Pow(arrB[0] - arrA[0], 2) + Math.Pow(arrB[1] - arrA[1], 2) + Math.Pow(arrB[2] - arrA[2], 2));
// }


// Console.WriteLine("Input coordinates for point 'A'.\nUse combination '<x> enter <y> enter <z> enter':");
//     double[] arrA = new double[3];
//     for (int i = 0; i < arrA.Length; i++)
//     {
//         arrA[i] = Convert.ToInt32(Console.ReadLine());
//     }

//     Console.WriteLine("Input coordinates for point 'B'.\nUse combination '<x> enter <y> enter <z> enter':");
//     double[] arrB = new double[3];
//     for (int i = 0; i < arrB.Length; i++)
//     {
//         arrB[i] = Convert.ToInt32(Console.ReadLine());
//     }

// Console.WriteLine($"The distance between 'A' and 'B' is equal {Math.Round(DistRange(arrA, arrB), 2)}");





// Task 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


// void ExponCube(int n)
// {
// 	for (int i = 1; i <= n; i++)
// 	{
// 		Console.WriteLine($"{i} -> {Math.Pow(i, 3)}");
// 	}
// }

// Console.Write("Input your number 'N': ");
// int n = Convert.ToInt32(Console.ReadLine());

// ExponCube(n);

