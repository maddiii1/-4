// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()
/*
int degree(int number,int stepen){
int rez=1;

for (;stepen>0; stepen--)
{
  rez*=number;    
}

return rez;
}

int A;
int B;
Console.Write("Введите число: ");
A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: "); 
B = Convert.ToInt32(Console.ReadLine());

int v = degree(A,B);
Console.Write("Результат: "+ v); 
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0; 
for (;number > 0;)
{
   int lastNumber = number%10;
   sum = sum + lastNumber;
   number = number/10;
}

Console.Write("Результат суммы: " + sum);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

object [] array = new object[] {1,2,3,4,5,6,7,8};
Console.WriteLine("[{0}]", string.Join(", ",array));




