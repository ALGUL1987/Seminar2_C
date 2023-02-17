// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1,
//то программа выводит остаток от деления


Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber == 0)
{
    Console.Write("На ноль делить нельзя");
    return;
}

if (firstNumber % secondNumber == 0) // проверка на равенство
{
    Console.WriteLine("Число кратное");
}
else
{
    //Console.WriteLine("Число некратное, остаток от деления равен: " + firstNumber % secondNumber);
    Console.WriteLine($"Число некратное, остаток от деления {firstNumber} на {secondNumber} равен {firstNumber % secondNumber}"); //$ - интерполяция
}